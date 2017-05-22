using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using System.IO;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using System.Data.Entity;
using CrystalDecisions.CrystalReports.Engine;

namespace BHXH.HR.UI
{
        public partial class frmHrNhanVien : Form
    {
        
        DataView ViewDMChucVu = new DataView();
        DataTable TableDMChucVu = new DataTable();
        public BHXH.Data.HrNhanVien nv = null;
        public string MaPhongBan;
        public string MaBoPhan;
        public string ID = "";
        public Int16 ToaDo = 0;
        public frmHrNhanVien()
        {
            InitializeComponent();
        }
       
        private void frmHrNhanVien_Load(object sender, EventArgs e)
        {
            this.Panel1.Height = this.Height - 200;
            CalcEditPCChucVu.EditValue = 0;
            MaPhongBan = "";
            MaBoPhan = "";
            int TongSo = 0;
            BHXH.Data.BHXHEntities ctx = new BHXH.Data.BHXHEntities();
            var queryPhongBan = from c in ctx.ListPhongBan
                                select new
                                {
                                    c.MaPhongBan,
                                    c.TenPhongBan,
                                    c.BoPhan
                                };

            var queryBoPhan = from c in ctx.ListBoPhan
                              select new
                              {
                                  c.MaBoPhan,
                                  c.TenBoPhan,
                              };
            ////////////////add Bo Phan
            foreach (var qBP in queryBoPhan)
            {
                NavBarGroup groupBP = new NavBarGroup();
                groupBP.Caption = qBP.TenBoPhan;
                groupBP.Tag = qBP.MaBoPhan;
                //MaBoPhan = qBP.MaBoPhan;
                NavBarControlDSNhanVien1.Groups.Add(groupBP);
            }
            ////////
            foreach (var qPB in queryPhongBan)
            {
                NavBarGroup group = new NavBarGroup();
                group.Caption = qPB.TenPhongBan;
                group.Tag = qPB.MaPhongBan;
                MaPhongBan = qPB.MaPhongBan;
                NavBarControlDSNhanVien.Groups.Add(group);

                ///////Phòng ko có bộ phận
                if (qPB.BoPhan == false)
                {

                    var queryNhanVien = from c in ctx.HrNhanVien
                                        where c.MaPhongBan == MaPhongBan
                                        orderby c.MaChucVu descending
                                        select new
                                        {
                                            c.MaNhanVien,
                                            c.TenNhanVien,
                                            c.MaChucVu
                                        };
                    TongSo = 0;
                    foreach (var qNV in queryNhanVien)
                    {
                        TongSo++;
                        NavBarItem item = new NavBarItem();
                        item.Caption = qNV.TenNhanVien;
                        item.Tag = qNV.MaNhanVien;
                        group.ItemLinks.Add(item);
                        //if ((qNV.MaChucVu.ToString() == "01") || (qNV.MaChucVu.ToString() == "02") || (qNV.MaChucVu.ToString() == "03") || (qNV.MaChucVu.ToString() == "04"))
                        //{
                        //    item.Appearance.ForeColor = Color.Red;
                        //    item.Appearance.Font = new Font(this.Font, FontStyle.Bold);
                        //    item.Appearance.Font = new Font(item.Appearance.Font.FontFamily, 10);

                        //}
                    }
                }
                group.Caption = qPB.TenPhongBan + " (" + TongSo + ")";
            }
            
            this.lookUpEditTinhQQ.Properties.DataSource = BHXH.List.Business.ListTinh.GetAll();
            this.lookUpEditTinhQQ.Properties.DisplayMember = "TenTinh";
            this.lookUpEditTinhQQ.Properties.ValueMember = "MaTinh";
            ToaDo = Convert.ToInt16(XtraTabControlHoSoNhanVien.Left.ToString());
            XtraTabControlHoSoNhanVien.Left = NavBarControlDSNhanVien1.Left;
            XtraTabControlHoSoNhanVien.Width = this.Width - ToaDo + NavBarControlDSNhanVien1.Width - 50;

        }
        public class bientoancuc
        {
            public static string MaNhanVien;
            
        }
        private void NavBarControlDSNhanVien_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ID = e.Link.Item.Tag.ToString();
            nv = BHXH.HR.Business.HrNhanVien.GetNhanVien(e.Link.Item.Tag.ToString());
            bientoancuc.MaNhanVien = nv.MaNhanVien.ToString();
            LoadData();
        }
        
        void LoadTabThongTinNhanVien(string NhanVienID)
        {
            
            LabelControlIDNhanVien.Text = "Mã nhân viên: " + nv.MaNhanVien;
            
            MruEditSoHieuNV.EditValue = nv.SoHieuNV;
            MruEditTenNhanVien.EditValue = nv.TenNhanVien;
            cboEditGioiTinh.EditValue = nv.GioiTinh;
            MruEditTenKhac.EditValue = nv.TenKhac;
            ////////Chức vụ Đảng
            this.lookUpEditChucVuDang.Properties.DataSource = BHXH.List.Business.ListChucVuDang.GetAll();
            this.lookUpEditChucVuDang.Properties.DisplayMember = "TenChucVu";
            this.lookUpEditChucVuDang.Properties.ValueMember = "MaChucVu";
            lookUpEditChucVuDang.EditValue = nv.MaCapUy;

            ///////////////Chức vu Đảng kiêm
            this.lookUpEditChucVuDangKiem.Properties.DataSource = BHXH.List.Business.ListChucVuDang.GetAll();
            this.lookUpEditChucVuDangKiem.Properties.DisplayMember = "TenChucVu";
            this.lookUpEditChucVuDangKiem.Properties.ValueMember = "MaChucVu";
            lookUpEditChucVuDangKiem.EditValue = nv.MaCapUyKiem ;

            ////////////CHức vụ
            this.lookUpEditChucVu.Properties.DataSource = BHXH.List.Business.ListChucVu.GetAll();
            this.lookUpEditChucVu.Properties.DisplayMember = "TenChucVu";
            this.lookUpEditChucVu.Properties.ValueMember = "MaChucVu";
            lookUpEditChucVu.EditValue= nv.MaChucVu;

            ////////////CHức danh
            this.lookUpEditChucDanh.Properties.DataSource = BHXH.List.Business.ListChucDanh.GetAll();
            this.lookUpEditChucDanh.Properties.DisplayMember = "TenChucDanh";
            this.lookUpEditChucDanh.Properties.ValueMember = "MaChucDanh";
            lookUpEditChucDanh.EditValue = nv.MaChucDanh ;
            ////
            CalcEditPCChucVu.EditValue = nv.PCChucVu;
            DateEditNgayBoNhiem.EditValue = nv.NgayBoNhiem;
            DateEditNgaySinh.EditValue = nv.NgaySinh;
            MruEditNoiSinh.EditValue = nv.NoiSinh;
            //Quê quán
            //tỉnh
            this.lookUpEditTinhQQ.Properties.DataSource = BHXH.List.Business.ListTinh.GetAll();
            this.lookUpEditTinhQQ.Properties.DisplayMember = "TenTinh";
            this.lookUpEditTinhQQ.Properties.ValueMember = "MaTinh";
            this.lookUpEditTinhQQ.EditValue = nv.MaTinhQQ;
            //Quận
            try
            {
                this.lookUpEditQuanQQ.Properties.DataSource = BHXH.List.Business.ListQuanHuyen.GetToTinh(lookUpEditTinhQQ.EditValue.ToString());
                this.lookUpEditQuanQQ.Properties.DisplayMember = "TenQuanHuyen";
                this.lookUpEditQuanQQ.Properties.ValueMember = "QuanHuyenID";
                this.lookUpEditQuanQQ.EditValue = nv.QuanHuyenIDQQ;
            }
            catch
            {            }
            //xã phường
            try
            {
                this.lookUpEditPhuongQQ.Properties.DataSource = BHXH.List.Business.ListXaPhuong.GetAll(lookUpEditQuanQQ.EditValue.ToString());
                this.lookUpEditPhuongQQ.Properties.DisplayMember = "TenXaPhuong";
                this.lookUpEditPhuongQQ.Properties.ValueMember = "XaPhuongID";
                this.lookUpEditPhuongQQ.EditValue = nv.XaPhuongIDQQ;
            }
            catch { }
            txtQueQuan.Text  = lookUpEditTinhQQ.Text  + ", " + lookUpEditQuanQQ.Text  + ", " + lookUpEditPhuongQQ.Text ;
            ///Trú quán (nơi ở hiện nay)
             //tỉnh
            this.lookUpEditTinhTQ.Properties.DataSource = BHXH.List.Business.ListTinh.GetAll();
            this.lookUpEditTinhTQ.Properties.DisplayMember = "TenTinh";
            this.lookUpEditTinhTQ.Properties.ValueMember = "MaTinh";
            this.lookUpEditTinhTQ.EditValue = nv.MatinhTQ;
            //Quận
            try
            {
                this.lookUpEditQuanTQ.Properties.DataSource = BHXH.List.Business.ListQuanHuyen.GetToTinh(lookUpEditTinhTQ.EditValue.ToString());
                this.lookUpEditQuanTQ.Properties.DisplayMember = "TenQuanHuyen";
                this.lookUpEditQuanTQ.Properties.ValueMember = "QuanHuyenID";
                this.lookUpEditQuanTQ.EditValue = nv.QuanHuyenIDTQ;
            }
            catch
            {

            }
            
            //xã phường
            try
            {
                this.lookUpEditPhuongTQ.Properties.DataSource = BHXH.List.Business.ListXaPhuong.GetAll(lookUpEditQuanTQ.EditValue.ToString());
                this.lookUpEditPhuongTQ.Properties.DisplayMember = "TenXaPhuong";
                this.lookUpEditPhuongTQ.Properties.ValueMember = "XaPhuongID";
                this.lookUpEditPhuongTQ.EditValue = nv.XaPhuongIDTQ;
            }
            catch { }
            
            /////////////////////
            MruEditSoNha.EditValue = nv.SoNha;
            
            ///////////
            MruEditDTNha.EditValue = nv.DTNha;
            MruEditDTCoQuan.EditValue = nv.DTCoQuan;
            MruEditDTDiDong.EditValue = nv.DTDiDong;
            MruEditEmail.EditValue = nv.Email;
            MruEditDTNguoiNha.EditValue = nv.DTNguoiNha;
            MruEditTenNguoiNha.EditValue = nv.DTNguoiNha;
            /////Dân tộc
            this.lookUpEditDanToc.Properties.DataSource = BHXH.List.Business.ListDanToc.GetAll();
            this.lookUpEditDanToc.Properties.DisplayMember = "TenDanToc";
            this.lookUpEditDanToc.Properties.ValueMember = "MaDanToc";
            lookUpEditDanToc.EditValue = nv.MaDanToc;
            /////Tôn giáo
            this.lookUpEditTonGiao.Properties.DataSource = BHXH.List.Business.ListTonGiao.GetAll();
            this.lookUpEditTonGiao.Properties.DisplayMember = "TenTonGiao";
            this.lookUpEditTonGiao.Properties.ValueMember = "MaTonGiao";
            lookUpEditTonGiao.EditValue = nv.MaTonGiao;
            ////thành phần gia đình
            this.lookUpEditThanhPhanGD.Properties.DataSource = BHXH.List.Business.ListThanhPhanGD.GetAll();
            this.lookUpEditThanhPhanGD.Properties.DisplayMember = "TenThanhPhanGD";
            this.lookUpEditThanhPhanGD.Properties.ValueMember = "MaThanhPhanGD";
            lookUpEditThanhPhanGD.EditValue = nv.MaThanhPhanGD ;
            /////////
            DateEditNgayTD.EditValue = nv.NgayTD;
            DateEditNgayCQ.EditValue = nv.NgayCQ;
            DateEditNgayCM.EditValue = nv.NgayCM;
            DateEditNgayDang.EditValue = nv.NgayDang;
            DateEditNgayDangCT.EditValue = nv.NgayDangCT;
            //chi bộ
            this.lookUpEditChiBo.Properties.DataSource = BHXH.List.Business.ListChiBo.GetAll();
            this.lookUpEditChiBo.Properties.DisplayMember = "TenChiBo";
            this.lookUpEditChiBo.Properties.ValueMember = "MaChiBo";
            if (nv.MaChiBo != null)
                lookUpEditChiBo.EditValue = nv.MaChiBo;
            else
                lookUpEditChiBo.EditValue = "";
            
            //////
            DateEditNgayTCXH.EditValue = nv.NgayTCXH;
            DateEditNgayNhapNgu.EditValue = nv.NgayNhapNgu;
            DateEditNgayXuatNgu.EditValue = nv.NgayXuatNgu;
            MruEditQuanHam.EditValue = nv.QuanHam;
            //Trình độ văn hóa
            this.lookUpEditTDVanHoa.Properties.DataSource = BHXH.List.Business.ListTDVanHoa.GetAll();
            this.lookUpEditTDVanHoa.Properties.DisplayMember = "TenTDVanHoa";
            this.lookUpEditTDVanHoa.Properties.ValueMember = "MaTDVanHoa";
            lookUpEditTDVanHoa.EditValue = nv.MaTDVanHoa;
            ///Trình độ đào tạo
            this.lookUpEditTDDaoTao.Properties.DataSource = BHXH.List.Business.ListTDDaoTao.GetAll();
            this.lookUpEditTDDaoTao.Properties.DisplayMember = "TenTDDaoTao";
            this.lookUpEditTDDaoTao.Properties.ValueMember = "MaTDDaoTao";
            lookUpEditTDDaoTao.EditValue = nv.MaTDDaoTao ;
            //Trình độ lí luận chính trị
            this.lookUpEditTDLLCT.Properties.DataSource = BHXH.List.Business.ListTDLLCT.GetAll();
            this.lookUpEditTDLLCT.Properties.DisplayMember = "TenTDLLCT";
            this.lookUpEditTDLLCT.Properties.ValueMember = "MaTDLLCT";
            lookUpEditTDLLCT.EditValue = nv.MaTDLLCT ;
            //Ngoại ngữ
            this.lookUpEditNgoaiNgu.Properties.DataSource = BHXH.List.Business.ListNgoaiNgu.GetAll();
            this.lookUpEditNgoaiNgu.Properties.DisplayMember = "TenNgoaiNgu";
            this.lookUpEditNgoaiNgu.Properties.ValueMember = "MaNgoaiNgu";
            lookUpEditNgoaiNgu.EditValue = nv.MaNgoaiNgu;

            //Trình độ ngoại ngữ
            this.lookUpEditTDNgoaiNgu.Properties.DataSource = BHXH.List.Business.ListTDNgoaiNgu.GetAll();
            this.lookUpEditTDNgoaiNgu.Properties.DisplayMember = "TenTDNgoaiNgu";
            this.lookUpEditTDNgoaiNgu.Properties.ValueMember = "MaTDNgoaiNgu";
            lookUpEditTDNgoaiNgu.EditValue = nv.MaTDNgoaiNgu;

            ////
            MruEditCVDangLam.EditValue = nv.CVDangLam;
            
            MruEditBac.EditValue = nv.Bac;
            MruEditHSL.EditValue = nv.HSL;
            //tên ngạch
            this.lookUpEditNgach.Properties.DataSource = BHXH.HR.Business.HrThangBangLuong.GetAll();
            this.lookUpEditNgach.Properties.DisplayMember = "TenNgach";
            this.lookUpEditNgach.Properties.ValueMember = "MaNgach";
            lookUpEditNgach.EditValue = nv.MaNgach;
            
            ///////////////
            MruEditDHDuocPhong.EditValue = nv.DHDuocPhong;
            MruEditSoTruongCT.EditValue = nv.SoTruongCT;
            MruEditCVLamLN.EditValue = nv.CVLamLN;
            MruEditKhenThuong.EditValue = nv.KhenThuong;
            MruEditKyLuat.EditValue = nv.KyLuat;
            MruEditSucKhoe.EditValue = nv.SucKhoe;
            MruEditChieuCao.EditValue = nv.ChieuCao;
            MruEditCanNang.EditValue = nv.CanNang;
            cboEditNhomMau.EditValue = nv.NhomMau;
            MruEditSoCMND.EditValue = nv.SoCMND;
            CheckEditGDLietSy.EditValue = nv.GDLietSy;
            //thương binh
            this.lookUpEditTB.Properties.DataSource = BHXH.List.Business.ListLoaiTB.GetAll();
            this.lookUpEditTB.Properties.DisplayMember = "TenLoaiTB";
            this.lookUpEditTB.Properties.ValueMember = "MaLoaiTB";
            lookUpEditTB.EditValue = nv.MaLoaiTB;
            //ảnh

            this.PictureEdit1.Image = BHXH.Util.Image.BinaryToImage(nv.AnhNV);
            //load tab Khác
            MemoEditTuDay.EditValue = nv.TuDay;
            MemoEditCheDoCu.EditValue = nv.CheDoCu;
            MemoEditTNNuocNgoai.EditValue = nv.TNNuocNgoai;
            MruEditSoBHXH.EditValue = nv.SoBHXH;
            MruEditTheBHYT.EditValue = nv.TheBHYT;
            MruEditTaiKhoanATM.EditValue = nv.TaiKhoanATM;
            DateEditNgayNangLuong.EditValue = nv.NgayNangLuong;
            CheckEditDaNLTruocTH.EditValue = nv.DaNLTruocTH;
            DateEditNgayCMND.EditValue = nv.NgayCMND;
            MruEditNoiCMND.EditValue = nv.NoiCMND;
            MruEditMaTinhKCB.EditValue = nv.MaTinhKCB;
            MruEditMaKCB.EditValue = nv.MaNoiKCB;
            //if (!string.IsNullOrEmpty(MruEditMaKCB.Text))
                //MruEditTenKCB.EditValue = BHXH.List.Business.ListNoiKCB.GetNoiKCB(MruEditMaKCB.Text).TenNoiKCB.ToString();
        }
   private void XtraTabPageQuaTrinhCongTac_Paint()
        {

        }

        private void NavBarControlDSNhanVien_Click(object sender, EventArgs e)
        {
            
        }
           

        private void MruEditMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void MruEditMaChucVu_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void GridControlChiTietDaoTao_Click(object sender, EventArgs e)
        {

        }

        private void GridControlChiTietDaoTao_MouseEnter(object sender, EventArgs e)
        {
                   }

        private void GridControlQuaTrinhCongTac_Click(object sender, EventArgs e)
        {

        }

        private void GridViewChiTietDaoTao_MouseEnter(object sender, EventArgs e)
        {
            lookUpEditNganhHoc.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenCMDaoTao").ToString();
            txtNganhHoc.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "NganhHoc").ToString();
            txtTenTruong.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenTruong").ToString();
            txtThoiGian.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "ThoiGian").ToString();
            lookUpEditLoaiHinhDaoTao.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenLHDaoTao").ToString();
            lookUpEditBangCap.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenBangCap").ToString();
            ComboBoxEditXepLoai.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "XepLoai").ToString();
        }

        private void GridViewChiTietDaoTao_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)

        {
            
            //MessageBox.Show( GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "MaCMDaoTao").ToString());
        }

        private void MruEditMaChucVu_Click(object sender, EventArgs e)
        {
           // BHXH.HR.UI.frmChonDanhMuc f = new BHXH.HR.UI.frmChonDanhMuc();
            //f.ShowDialog(this);
            //f.DataGridViewDanhMuc.DataSource = BHXH.List.Business.ListChucVu.GetAll();
        }

        private void GridViewChiTietDaoTao_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void GridViewChiTietDaoTao_RowCellClick(object sender, RowCellClickEventArgs e)
        {
             
        }

        private void lookUpEditTenChucVu_EditValueChanged(object sender, EventArgs e)
                    {

                   }

        private void lookUpEditTenChucVu_ListChanged(object sender, ListChangedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lookUpEditChucVu.Text = BHXH.List.Business.ListChucVu.GetData("01").TenChucVu;
        }
        private void SimpleButtonSua_Click(object sender, EventArgs e)
        {
            this.MruEditTenNhanVien.Enabled = true;
            this.MruEditSoHieuNV.Enabled = true;
            this.cboEditGioiTinh.Enabled = true;
            this.MruEditTenKhac.Enabled = true;
            this.lookUpEditChucVuDang.Enabled = true;
            this.lookUpEditChucVuDangKiem.Enabled = true;
            this.lookUpEditChucVu.Enabled = true;
            this.lookUpEditChucDanh.Enabled = true;
            this.CalcEditPCChucVu.Enabled = true;
            this.DateEditNgayBoNhiem.Enabled  = true;
            this.DateEditNgaySinh.Enabled = true;
            this.MruEditNoiSinh.Enabled = true;

            //QQ,TQ
            this.lookUpEditTinhQQ.Enabled = true;
            this.lookUpEditQuanQQ.Enabled = true;
            this.lookUpEditPhuongQQ.Enabled = true;
            this.lookUpEditTinhTQ.Enabled = true;
            this.lookUpEditQuanTQ.Enabled = true;
            this.lookUpEditPhuongTQ.Enabled = true;

            this.MruEditSoNha.Enabled = true;
            this.MruEditDTNha.Enabled = true;
            this.MruEditDTCoQuan.Enabled = true;
            this.MruEditDTDiDong.Enabled = true;
            this.MruEditEmail.Enabled = true;
            this.MruEditDTNguoiNha.Enabled = true;
            this.MruEditTenNguoiNha.Enabled = true;
            this.lookUpEditDanToc.Enabled = true;
            this.lookUpEditTonGiao.Enabled = true;
            this.lookUpEditThanhPhanGD.Enabled = true;
            this.MruEditNgheTruocTD.Enabled = true;
            this.DateEditNgayTD.Enabled = true;
            this.DateEditNgayCQ.Enabled = true;
            this.MruEditCoQuanTD.Enabled = true;
            this.DateEditNgayCM.Enabled = true;
            this.DateEditNgayDang.Enabled = true;
            this.DateEditNgayDangCT.Enabled = true;
            this.DateEditNgayTCXH.Enabled = true;
            this.DateEditNgayNhapNgu.Enabled = true;
            this.DateEditNgayXuatNgu.Enabled = true;
            this.MruEditQuanHam.Enabled = true;
            this.lookUpEditTDLLCT.Enabled = true;
            this.lookUpEditTDVanHoa.Enabled = true;
            this.lookUpEditTDDaoTao.Enabled = true;
            this.lookUpEditNgoaiNgu.Enabled = true;
            this.lookUpEditTDNgoaiNgu.Enabled = true;
            this.MruEditCVDangLam.Enabled = true;
            this.lookUpEditNgach.Enabled = true;
            this.MruEditBac.Enabled = true;
            this.MruEditHSL.Enabled = true;
            this.MruEditDHDuocPhong.Enabled = true;
            this.MruEditSoTruongCT.Enabled = true;
            this.MruEditCVLamLN.Enabled = true;
            this.MruEditKhenThuong.Enabled = true;
            this.MruEditKyLuat.Enabled = true;
            this.MruEditSucKhoe.Enabled = true;
            this.MruEditChieuCao.Enabled = true;
            this.MruEditCanNang.Enabled = true;
            this.cboEditNhomMau.Enabled = true;
            this.MruEditSoCMND.Enabled = true;
            this.lookUpEditTB.Enabled = true;
            this.CheckEditGDLietSy.Enabled = true;
            this.lookUpEditChiBo.Enabled = true;
            //tab khác
            this.MemoEditTuDay.Enabled = true;
            this.MemoEditCheDoCu.Enabled = true;
            this.MemoEditTCNuocNgoai.Enabled = true;
            this.MruEditSoBHXH.Enabled = true;
            this.MruEditTheBHYT.Enabled = true;
            this.MruEditTaiKhoanATM.Enabled = true;
            this.DateEditNgayNangLuong.Enabled = true;
            this.CheckEditDaNLTruocTH.Enabled = true;
            this.DateEditNgayCMND.Enabled = true;
            this.MruEditNoiCMND.Enabled = true;
            ////////
            this.SimpleButtonGhi.Enabled = true;
            this.SimpleButtonSua.Enabled = false ;

        }
          
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
            try
            {
                string TenNhanVien = this.MruEditTenNhanVien.Text;
                string SoHieuNV = this.MruEditSoHieuNV.Text;
                string GioiTinh = this.cboEditGioiTinh.Text;
                string TenKhac = this.MruEditTenKhac.Text;
                string MaCapUy = this.lookUpEditChucVuDang.EditValue.ToString();
                string MaCapUyKiem = "";
                if (lookUpEditChucVuDangKiem.Text != "") MaCapUyKiem = this.lookUpEditChucVuDangKiem.EditValue.ToString();
                string MaChucVu = "";
                if (lookUpEditChucVu.Text != "") MaChucVu = this.lookUpEditChucVu.EditValue.ToString();
                string MaChucDanh = "";
                if (lookUpEditChucDanh.Text != "") MaChucDanh = this.lookUpEditChucDanh.EditValue.ToString();
                decimal PCChucVu = 0;
                if (CalcEditPCChucVu.Text != "") PCChucVu = Convert.ToDecimal(CalcEditPCChucVu.Text);
                DateTime? NgayBoNhiem = null;
                if (DateEditNgayBoNhiem.Text != "") NgayBoNhiem = Convert.ToDateTime(DateEditNgayBoNhiem.Text);
                DateTime? NgaySinh = null;
                if (DateEditNgaySinh.Text != "") NgaySinh = Convert.ToDateTime(DateEditNgaySinh.Text);

                // //QQ
                string MaTinhQQ = this.lookUpEditTinhQQ.EditValue.ToString();
                Decimal? QuanHuyenIDQQ = Convert.ToDecimal(this.lookUpEditQuanQQ.EditValue.ToString());
                Decimal? XaPhuongIDQQ = Convert.ToDecimal(this.lookUpEditPhuongQQ.EditValue.ToString());
                //TQ
                string MatinhTQ = this.lookUpEditTinhTQ.EditValue.ToString();
                Decimal? QuanHuyenIDTQ = Convert.ToInt64(this.lookUpEditQuanTQ.EditValue.ToString());
                Decimal? XaPhuongIDTQ = Convert.ToInt64(this.lookUpEditPhuongTQ.EditValue.ToString());
                // //
                string SoNha = this.MruEditSoNha.Text;
                string DTNha = this.MruEditDTNha.Text;
                string DTCoQuan = this.MruEditDTCoQuan.Text;
                string DTDiDong = this.MruEditDTDiDong.Text;
                string Email = this.MruEditEmail.Text;
                string DTNguoiNha = this.MruEditDTNguoiNha.Text;
                string TenNguoiNha = this.MruEditTenNguoiNha.Text;
                string MaDanToc = this.lookUpEditDanToc.EditValue.ToString();
                string MaTonGiao = this.lookUpEditTonGiao.EditValue.ToString();
                string MaThanhPhanGD = this.lookUpEditThanhPhanGD.EditValue.ToString();
                string NgheTruocTD = this.MruEditNgheTruocTD.Text;
                DateTime? NgayTD = null;
                if (DateEditNgayTD.Text != "") NgayTD = Convert.ToDateTime(this.DateEditNgayTD.Text);
                DateTime? NgayCQ = null;
                if (DateEditNgayCQ.Text != "") NgayCQ = Convert.ToDateTime(this.DateEditNgayCQ.Text);
                string CoQuanTD = this.MruEditCoQuanTD.Text;
                DateTime? NgayCM = null;
                if (DateEditNgayCM.Text != "") NgayCM = Convert.ToDateTime(DateEditNgayCM.Text);
                DateTime? NgayDang = null;
                if (DateEditNgayDang.Text != "") NgayDang = Convert.ToDateTime(this.DateEditNgayDang.Text);
                DateTime? NgayDangCT = null;
                if (DateEditNgayDangCT.Text != "") NgayDangCT = Convert.ToDateTime(this.DateEditNgayDangCT.Text);

                DateTime? NgayTCXH = null;
                if (DateEditNgayTCXH.Text != "") NgayTCXH = Convert.ToDateTime(this.DateEditNgayTCXH.Text);

                DateTime? NgayNhapNgu = null;
                if (DateEditNgayNhapNgu.Text != "") NgayNhapNgu = Convert.ToDateTime(this.DateEditNgayNhapNgu.Text);

                DateTime? NgayXuatNgu = null;
                if (DateEditNgayNhapNgu.Text != "") NgayXuatNgu = Convert.ToDateTime(this.DateEditNgayNhapNgu.Text);
                string QuanHam = this.MruEditQuanHam.Text;
                string MaTDVanHoa = this.lookUpEditTDVanHoa.EditValue.ToString();
                string MaTDDaoTao = this.lookUpEditTDDaoTao.EditValue.ToString();
                string MaTDLLCT= this.lookUpEditTDLLCT.EditValue.ToString();
                string MaNgoaiNgu = this.lookUpEditNgoaiNgu.EditValue.ToString();
                string MaTDNgoaiNgu = this.lookUpEditTDNgoaiNgu.EditValue.ToString();
                string CVDangLam = this.MruEditCVDangLam.Text;
                string MaNgach = this.lookUpEditNgach.EditValue.ToString();
                string Bac = this.MruEditBac.Text;
                Decimal? HSL =0;
                if (MruEditHSL.Text !="") HSL = Convert.ToDecimal(this.MruEditHSL.Text);
                string DHDuocPhong = this.MruEditDHDuocPhong.Text;
                string SoTruongCT = this.MruEditSoTruongCT.Text;
                string CVLamLN = this.MruEditCVLamLN.Text;
                string KhenThuong = this.MruEditKhenThuong.Text;
                string KyLuat = this.MruEditKyLuat.Text;
                string SucKhoe = this.MruEditSucKhoe.Text;

                string ChieuCao = this.MruEditChieuCao.Text;
                string CanNang = this.MruEditCanNang.Text;
                string NhomMau = this.cboEditNhomMau.Text;
                string SoCMND = this.MruEditSoCMND.Text;
                string MaLoaiTB = this.lookUpEditTB.EditValue.ToString();
                Boolean GDLietSy = this.CheckEditGDLietSy.Checked;
                //tab khác
                MemoEditTuDay.EditValue = nv.TuDay;
                //string CheDoCu = MemoEditCheDoCu.EditValue;
                //MemoEditTNNuocNgoai.EditValue = nv.TNNuocNgoai;
                string SoBHXH = MruEditSoBHXH.Text;
                string TheBHYT = MruEditTheBHYT.Text;
                string TaiKhoanATM = MruEditTaiKhoanATM.Text;
                DateTime? NgayNangLuong = null;
                if (DateEditNgayNangLuong.Text != "") NgayNangLuong = Convert.ToDateTime(this.DateEditNgayNangLuong.Text);
                Boolean DaLNTruocHan = false;
                if (CheckEditDaNLTruocTH.Text != "") DaLNTruocHan = true; // Convert.ToBoolean(CheckEditDaNLTruocTH.EditValue.ToString());
                DateTime? NgayCMND = null;
                if (DateEditNgayCMND.Text != "") NgayCMND = Convert.ToDateTime(this.DateEditNgayCMND.Text);
                string NoiCMND = MruEditNoiCMND.Text;
                string MaTinhKCB = MruEditMaTinhKCB.Text;
                string MaNoiKCB = MruEditMaKCB.Text;


                DialogResult d = MessageBox.Show("Bạn có muốn sửa thông tin nhân viên" + nv.TenNhanVien, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BHXH.HR.Business.HrNhanVien.Edit(nv.MaNhanVien.ToString(), TenNhanVien, SoHieuNV, GioiTinh, TenKhac, MaCapUy, MaCapUyKiem, MaChucVu, MaChucDanh, PCChucVu, NgayBoNhiem,
                        NgaySinh, MaTinhQQ, QuanHuyenIDQQ, XaPhuongIDQQ, MatinhTQ, QuanHuyenIDTQ, XaPhuongIDTQ, SoNha, DTNha, DTCoQuan, DTDiDong, Email, DTNguoiNha, TenNguoiNha,
                        MaDanToc, MaTonGiao, MaThanhPhanGD, NgheTruocTD, NgayTD, NgayCQ, CoQuanTD, NgayCM, NgayDang, NgayDangCT, NgayTCXH, NgayNhapNgu, NgayXuatNgu, QuanHam,
                        MaTDVanHoa, MaTDDaoTao, MaTDLLCT, MaNgoaiNgu, MaTDNgoaiNgu, CVDangLam, MaNgach, Bac, HSL, DHDuocPhong, SoTruongCT, CVLamLN, KhenThuong, KyLuat, SucKhoe, ChieuCao, CanNang, NhomMau, SoCMND, MaLoaiTB, GDLietSy,
                        SoBHXH, TheBHYT, TaiKhoanATM, NgayNangLuong, DaLNTruocHan, NgayCMND, MaTinhKCB, MaNoiKCB, NoiCMND);
                    MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.SimpleButtonGhi.Enabled = false;
                this.SimpleButtonSua.Enabled = true;
                Init();
            }
            catch
            {
                MessageBox.Show("Đề nghị nhập đầy đủ thông tin");
            }
        }
        private void Init()
        {
            this.MruEditTenNhanVien.Enabled = false;
            this.MruEditSoHieuNV.Enabled = false;
            this.cboEditGioiTinh.Enabled = false;
            this.MruEditTenKhac.Enabled = false;
            this.lookUpEditChucVuDang.Enabled = false;
            this.lookUpEditChucVuDangKiem.Enabled = false;
            this.lookUpEditChucVu.Enabled = false;
            this.lookUpEditChucDanh.Enabled = false;
            this.CalcEditPCChucVu.Enabled = false;
            this.DateEditNgayBoNhiem.Enabled = false;
            this.DateEditNgaySinh.Enabled = false;
            this.MruEditNoiSinh.Enabled = false;

            //QQ,TQ
            this.lookUpEditTinhQQ.Enabled = false;
            this.lookUpEditQuanQQ.Enabled = false;
            this.lookUpEditPhuongQQ.Enabled = false;
            this.lookUpEditTinhTQ.Enabled = false;
            this.lookUpEditQuanTQ.Enabled = false;
            this.lookUpEditPhuongTQ.Enabled = false;

            this.MruEditSoNha.Enabled = false;
            this.MruEditDTNha.Enabled = false;
            this.MruEditDTCoQuan.Enabled = false;
            this.MruEditDTDiDong.Enabled = false;
            this.MruEditEmail.Enabled = false;
            this.MruEditDTNguoiNha.Enabled = false;
            this.MruEditTenNguoiNha.Enabled = false;
            this.lookUpEditDanToc.Enabled = false;
            this.lookUpEditTonGiao.Enabled = false;
            this.lookUpEditThanhPhanGD.Enabled = false;
            this.MruEditNgheTruocTD.Enabled = false;
            this.DateEditNgayTD.Enabled = false;
            this.DateEditNgayCQ.Enabled = false;
            this.MruEditCoQuanTD.Enabled = false;
            this.DateEditNgayCM.Enabled = false;
            this.DateEditNgayDang.Enabled = false;
            this.DateEditNgayDangCT.Enabled = false;
            this.DateEditNgayTCXH.Enabled = false;
            this.DateEditNgayNhapNgu.Enabled = false;
            this.DateEditNgayXuatNgu.Enabled = false;
            this.MruEditQuanHam.Enabled = false;
            this.lookUpEditTDLLCT.Enabled = false;
            this.lookUpEditTDVanHoa.Enabled = false;
            this.lookUpEditTDDaoTao.Enabled = false;
            this.lookUpEditNgoaiNgu.Enabled = false;
            this.lookUpEditTDNgoaiNgu.Enabled = false;
            this.MruEditCVDangLam.Enabled = false;
            this.lookUpEditNgach.Enabled = false;
            this.MruEditBac.Enabled = false;
            this.MruEditHSL.Enabled = false;
            this.MruEditDHDuocPhong.Enabled = false;
            this.MruEditSoTruongCT.Enabled = false;
            this.MruEditCVLamLN.Enabled = false;
            this.MruEditKhenThuong.Enabled = false;
            this.MruEditKyLuat.Enabled = false;
            this.MruEditSucKhoe.Enabled = false;
            this.MruEditChieuCao.Enabled = false;
            this.MruEditCanNang.Enabled = false;
            this.cboEditNhomMau.Enabled = false;
            this.MruEditSoCMND.Enabled = false;
            this.lookUpEditTB.Enabled = false;
            this.CheckEditGDLietSy.Enabled = false;
            this.lookUpEditChiBo.Enabled = false;
            //tab khác
            this.MemoEditTuDay.Enabled = false;
            this.MemoEditCheDoCu.Enabled = false;
            this.MemoEditTCNuocNgoai.Enabled = false;
            this.MruEditSoBHXH.Enabled = false;
            this.MruEditTheBHYT.Enabled = false;
            this.MruEditTaiKhoanATM.Enabled = false;
            this.DateEditNgayNangLuong.Enabled = false;
            this.CheckEditDaNLTruocTH.Enabled = false;
            this.DateEditNgayCMND.Enabled = false;
            this.MruEditNoiCMND.Enabled = false;
        }

        private void SimpleButtonQua_Click(object sender, EventArgs e)
        {
            this.SimpleButtonGhi.Enabled = false;
            this.SimpleButtonSua.Enabled = true;
            Init();
        }

        private void lookUpEditTinh_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lookUpEditTinhQQ_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.lookUpEditQuanQQ.Properties.DataSource = BHXH.List.Business.ListQuanHuyen.GetToTinh(this.lookUpEditTinhQQ.EditValue.ToString());
                this.lookUpEditQuanQQ.Properties.DisplayMember = "TenQuanHuyen";
                this.lookUpEditQuanQQ.Properties.ValueMember = "QuanHuyenID";
            }
            catch
            {

            }
           
        }

        private void lookUpEditQuanQQ_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.lookUpEditPhuongQQ.Properties.DataSource = BHXH.List.Business.ListXaPhuong.GetToQuan (this.lookUpEditQuanQQ.EditValue.ToString());
                this.lookUpEditPhuongQQ.Properties.DisplayMember = "TenXaPhuong";
                this.lookUpEditPhuongQQ.Properties.ValueMember = "XaPhuongID";
            }
            catch
            {

            }
        }

        private void lookUpEditQuanQQ_MouseDown(object sender, MouseEventArgs e)
        {
            this.lookUpEditPhuongQQ.Properties.DataSource = BHXH.List.Business.ListXaPhuong.GetToQuan (lookUpEditQuanQQ.EditValue.ToString());
            this.lookUpEditPhuongQQ.Properties.DisplayMember = "TenXaPhuong";
            this.lookUpEditPhuongQQ.Properties.ValueMember = "XaPhuongID";
            //this.lookUpEditPhuongQQ.EditValue = nv.XaPhuongIDQQ;
        }

        private void DropDownButtonIn_Click(object sender, EventArgs e)
        {
            BHXH.HR.UI.frmInLyLich2C f = new BHXH.HR.UI.frmInLyLich2C();
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();



        }
        private void SourceReport()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SimpleButtonThemQTDT_Click(object sender, EventArgs e)
        {
            lookUpEditNganhHoc.Enabled = true;
            txtNganhHoc.Enabled = true;
            lookUpEditLoaiHinhDaoTao.Enabled = true;
            ComboBoxEditXepLoai.Enabled = true;
            txtTenTruong.Enabled = true;
            txtThoiGian.Enabled = true;
            lookUpEditBangCap.Enabled = true;
            lookUpEditNganhHoc.Text  ="";
            txtNganhHoc.Text  = "";
            lookUpEditLoaiHinhDaoTao.Text  = "";
            ComboBoxEditXepLoai.Text  = "";
            txtTenTruong.Text  = "";
            txtThoiGian.Text  = "";
            lookUpEditBangCap.Text  = "";
            GridControlChiTietDaoTao.Enabled = false;
            SimpleButtonThemQTDT.Enabled = false;
            SimpleButtonSuaQTDT.Enabled = false;
            SimpleButtonXoaQTDT.Enabled = false;
            SimpleButtonGhiQTDT.Enabled = true;
            SimpleButtonQuaQTDT.Enabled = true;


        }

        private void lookUpEditNganhHoc_EditValueChanged(object sender, EventArgs e)
        {
            this.lookUpEditNganhHoc.Properties.DataSource = BHXH.List.Business.ListCMDaoTao.GetAll();
            this.lookUpEditNganhHoc.Properties.DisplayMember = "TenCMDaoTao";
            this.lookUpEditNganhHoc.Properties.ValueMember = "MaCMDaoTao";

        }

        private void lookUpEditLoaiHinhDaoTao_EditValueChanged(object sender, EventArgs e)
        {

            this.lookUpEditLoaiHinhDaoTao.Properties.DataSource = BHXH.List.Business.ListLHDaoTao.GetAll();
            this.lookUpEditLoaiHinhDaoTao.Properties.DisplayMember = "TenLHDaoTao";
            this.lookUpEditLoaiHinhDaoTao.Properties.ValueMember = "MaLHDaoTao";

        }

        private void lookUpEditBangCap_EditValueChanged(object sender, EventArgs e)
        {

            this.lookUpEditBangCap.Properties.DataSource = BHXH.List.Business.ListBangCap.GetAll();
            this.lookUpEditBangCap.Properties.DisplayMember = "TenBangCap";
            this.lookUpEditBangCap.Properties.ValueMember = "MaBangCap";
        }

        private void SimpleButtonGhiQTDT_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt16(GridViewChiTietDaoTao.RowCount.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
               BHXH.HR.Business.HrChiTietDaoTao.New(bientoancuc.MaNhanVien, stt + 1,lookUpEditNganhHoc.EditValue.ToString(), txtTenTruong.Text, txtNganhHoc.Text,
            txtThoiGian.Text, lookUpEditLoaiHinhDaoTao.EditValue.ToString() , lookUpEditBangCap.EditValue.ToString() , ComboBoxEditXepLoai.Text );
            }

            SimpleButtonThemQTDT.Enabled = true;
            SimpleButtonSuaQTDT.Enabled = true;
            SimpleButtonXoaQTDT.Enabled = true;
            SimpleButtonGhiQTDT.Enabled = false;
            SimpleButtonQuaQTDT.Enabled = true;
            this.GridControlChiTietDaoTao.DataSource = BHXH.HR.Business.HrChiTietDaoTao.GetData(bientoancuc.MaNhanVien);
            GridControlChiTietDaoTao.Enabled = true;
        }

        private void GridControlQuaTrinhCongTac_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GridViewQuaTrinhCongTac_MouseEnter(object sender, EventArgs e)
        {
            MruEditThoiGianQTCT.Text = GridViewQuaTrinhCongTac.GetRowCellValue(GridViewQuaTrinhCongTac.GetSelectedRows().First(), "ThoiGian").ToString();
            MruEditChiTietQTCT.Text = GridViewQuaTrinhCongTac.GetRowCellValue(GridViewQuaTrinhCongTac.GetSelectedRows().First(), "CongViec").ToString();
        }

        private void GridViewQuanHeGiaDinh_MouseEnter(object sender, EventArgs e)
        {
            lookUpEditQuanHeGiaDinh.Text = GridViewQuanHeGiaDinh.GetRowCellValue(GridViewQuanHeGiaDinh.GetSelectedRows().First(), "TenQuanHeGD").ToString();
            MruEditHoTen.Text = GridViewQuanHeGiaDinh.GetRowCellValue(GridViewQuanHeGiaDinh.GetSelectedRows().First(), "HoTen").ToString();
            MruEditNamSinh.Text= GridViewQuanHeGiaDinh.GetRowCellValue(GridViewQuanHeGiaDinh.GetSelectedRows().First(), "NamSinh").ToString();
            MemoEditChiTiet.Text = GridViewQuanHeGiaDinh.GetRowCellValue(GridViewQuanHeGiaDinh.GetSelectedRows().First(), "ChiTiet").ToString();
        }

        private void lookUpEditQuanHeGiaDinh_EditValueChanged(object sender, EventArgs e)
        {
            this.lookUpEditQuanHeGiaDinh.Properties.DataSource = BHXH.List.Business.ListQuanHeGD.GetAll();
            this.lookUpEditQuanHeGiaDinh.Properties.DisplayMember = "TenQuanHeGD";
            this.lookUpEditQuanHeGiaDinh.Properties.ValueMember = "MaQuanHeGD";
        }

        private void GridViewKhenThuongKyLuat_MouseEnter(object sender, EventArgs e)
        {
            lookUpEditKTKL.Text = GridViewKhenThuongKyLuat.GetRowCellValue(GridViewKhenThuongKyLuat.GetSelectedRows().First(), "TenKTKL").ToString();
            ComboBoxEditLoaiKTKL.Text = GridViewKhenThuongKyLuat.GetRowCellValue(GridViewKhenThuongKyLuat.GetSelectedRows().First(), "LoaiKTKL").ToString();
            MruEditNam.Text = GridViewKhenThuongKyLuat.GetRowCellValue(GridViewKhenThuongKyLuat.GetSelectedRows().First(), "Nam").ToString();
            MruEditGhiChu.Text = GridViewKhenThuongKyLuat.GetRowCellValue(GridViewKhenThuongKyLuat.GetSelectedRows().First(), "GhiChu").ToString();
        }

        private void MruEditTenKTKL_SelectedIndexChanged(object sender, EventArgs e)
        {
                  }

        private void GridControlQuanHeGiaDinh_Click(object sender, EventArgs e)
        {

        }

        private void GridViewQuaTrinhLuong_MouseEnter(object sender, EventArgs e)
        {
            ComboBoxEditLoaiQTL.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "Loai").ToString();
            MruEditTuThang.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "TuThang").ToString();
            MruEditDenThang.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "DenThang").ToString();
            MruEditMucLuong.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "MucLuong").ToString();
            MruEditHSLQTL.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "HSL").ToString();
            MruEditPCChucVu.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "PCChucVu").ToString();
            MruEditPCThamNien.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "PCThamNien").ToString();
            MruEditPCDocHai.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "PCDocHai").ToString();
            MruEditPCTrachNhiem.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "PCTrachNhiem").ToString();
            MruEditPCKhuVuc.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "PCKhuVuc").ToString();
            MruEditCongViec.Text = GridViewQuaTrinhLuong.GetRowCellValue(GridViewQuaTrinhLuong.GetSelectedRows().First(), "CongViec").ToString();
        }

        private void GridViewQuaTrinhBHXH_MouseEnter(object sender, EventArgs e)
        {
            ComboBoxEditLoaiBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "Loai").ToString();
            MruEditTuThangBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "TuThang").ToString();
            MruEditDenThangBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "DenThang").ToString();
            MruEditMucLuongBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "MucLuong").ToString();
            MruEditHSLBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "HSL").ToString();
            MruEditPCChucVuBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "PCChucVu").ToString();
            MruEditPCThamNienBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "PCThamNien").ToString();
            MruEditPCKhuVucBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "PCKhuVuc").ToString();
            MruEditCongViecBHXH.Text = GridViewQuaTrinhBHXH.GetRowCellValue(GridViewQuaTrinhBHXH.GetSelectedRows().First(), "CongViec").ToString();
        }

        private void GridControlChiTietDaoTao_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GridViewChiTietDaoTao_KeyDown(object sender, KeyEventArgs e)
        {
            lookUpEditNganhHoc.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenCMDaoTao").ToString();
            txtNganhHoc.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "NganhHoc").ToString();
            txtTenTruong.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenTruong").ToString();
            txtThoiGian.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "ThoiGian").ToString();
            lookUpEditLoaiHinhDaoTao.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenLHDaoTao").ToString();
            lookUpEditBangCap.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "TenBangCap").ToString();
            ComboBoxEditXepLoai.Text = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "XepLoai").ToString();
        }

        private void SimpleButtonThemQTCT_Click(object sender, EventArgs e)
        {
            MruEditThoiGianQTCT.Enabled = true;
            MruEditThoiGianQTCT.Text = "";
            MruEditChiTietQTCT.Enabled = true;
            MruEditChiTietQTCT.Text = "";
            SimpleButtonSuaQTCT.Enabled = false;
            SimpleButtonXoaQTCT.Enabled = false;
            SimpleButtonGhiQTCT.Enabled = true;
        }

        private void SimpleButtonXoaQTDT_Click(object sender, EventArgs e)
        {
            try
            {
                string code = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "QuaTrinhDaoTaoID").ToString();
                DialogResult d = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BHXH.HR.Business.HrChiTietDaoTao.Delete(code);
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải chọn dòng cần xóa. \n Chi tiết: " + ex.Message);
            }
            finally
            {
                this.GridControlChiTietDaoTao.DataSource = BHXH.HR.Business.HrChiTietDaoTao.GetData(bientoancuc.MaNhanVien.ToString());
            }
        }

        private void SimpleButtonQuaQTDT_Click(object sender, EventArgs e)
        {
            lookUpEditNganhHoc.Enabled = true;
            txtNganhHoc.Enabled = true;
            lookUpEditLoaiHinhDaoTao.Enabled = true;
            ComboBoxEditXepLoai.Enabled = true;
            txtTenTruong.Enabled = true;
            txtThoiGian.Enabled = true;
            lookUpEditBangCap.Enabled = true;
            lookUpEditNganhHoc.Text = "";
            txtNganhHoc.Text = "";
            lookUpEditLoaiHinhDaoTao.Text = "";
            ComboBoxEditXepLoai.Text = "";
            txtTenTruong.Text = "";
            txtThoiGian.Text = "";
            lookUpEditBangCap.Text = "";
            GridControlChiTietDaoTao.Enabled = true;
            SimpleButtonThemQTDT.Enabled = true;
            SimpleButtonSuaQTDT.Enabled = true;
            SimpleButtonXoaQTDT.Enabled = true;
            SimpleButtonGhiQTDT.Enabled = false;
            SimpleButtonQuaQTDT.Enabled = true;
        }

        private void SimpleButtonSuaQTDT_Click(object sender, EventArgs e)
        {
            lookUpEditNganhHoc.Enabled = true;
            txtNganhHoc.Enabled = true;
            lookUpEditLoaiHinhDaoTao.Enabled = true;
            ComboBoxEditXepLoai.Enabled = true;
            txtTenTruong.Enabled = true;
            txtThoiGian.Enabled = true;
            lookUpEditBangCap.Enabled = true;
            GridControlChiTietDaoTao.Enabled = true;
            SimpleButtonThemQTDT.Enabled = false ;
            SimpleButtonSuaQTDT.Enabled = false ;
            SimpleButtonXoaQTDT.Enabled = false ;
            SimpleButtonGhiQTDT.Enabled = false ;
            SimpleButtonGhiSuaQTDT.Enabled = true;
            SimpleButtonQuaQTDT.Enabled = true;
        }

        private void SimpleButtonGhiSuaQTDT_Click(object sender, EventArgs e)
        {
            string code = GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "QuaTrinhDaoTaoID").ToString();
            DialogResult d = MessageBox.Show("Bạn có muốn sửa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.HR.Business.HrChiTietDaoTao.Edit(code, lookUpEditNganhHoc.EditValue.ToString(), txtTenTruong.Text, txtNganhHoc.Text, txtThoiGian.Text,
                lookUpEditLoaiHinhDaoTao.EditValue.ToString(), ComboBoxEditXepLoai.Text);

                MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GridControlChiTietDaoTao.DataSource = BHXH.HR.Business.HrChiTietDaoTao.GetData(bientoancuc.MaNhanVien.ToString());
            }
            SimpleButtonGhiSuaQTDT.Enabled = true;
            GridControlChiTietDaoTao.Enabled = true;
            SimpleButtonThemQTDT.Enabled = true;
            SimpleButtonSuaQTDT.Enabled = true;
            SimpleButtonXoaQTDT.Enabled = true;
            SimpleButtonGhiQTDT.Enabled = true;
            SimpleButtonGhiSuaQTDT.Enabled = false;
            SimpleButtonQuaQTDT.Enabled = true;
        }

        private void SimpleButtonGhiQTCT_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt16(GridViewQuaTrinhCongTac.RowCount.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.HR.Business.HrQuaTrinhCongTac.New(bientoancuc.MaNhanVien, stt+1, MruEditThoiGianQTCT.EditValue.ToString(), MruEditChiTietQTCT.EditValue.ToString());
            }

            SimpleButtonThemQTCT.Enabled = true;    
            SimpleButtonSuaQTCT.Enabled = true;
            SimpleButtonXoaQTCT.Enabled = true;
            SimpleButtonGhiQTCT.Enabled = false;
            SimpleButtonQuaQTCT.Enabled = true;
            this.GridControlQuaTrinhCongTac.DataSource = BHXH.HR.Business.HrQuaTrinhCongTac.GetData(bientoancuc.MaNhanVien);
            GridControlQuaTrinhCongTac.Enabled = true;
            MruEditThoiGianQTCT.Enabled =false ;
            MruEditThoiGianQTCT.Text = "";
            MruEditChiTietQTCT.Enabled = false ;
            MruEditChiTietQTCT.Text = "";
            SimpleButtonSuaQTCT.Enabled =true ;
            SimpleButtonXoaQTCT.Enabled =true ;
            SimpleButtonGhiQTCT.Enabled =false ;
        }

        private void SimpleButtonXoaQTCT_Click(object sender, EventArgs e)
        {
            try
            {
                string code = GridViewQuaTrinhCongTac.GetRowCellValue(GridViewQuaTrinhCongTac.GetSelectedRows().First(), "QuaTrinhCongTacID").ToString();
                DialogResult d = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BHXH.HR.Business.HrQuaTrinhCongTac.Delete(code);
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải chọn dòng cần xóa. \n Chi tiết: " + ex.Message);
            }
            finally
            {
                this.GridControlQuaTrinhCongTac.DataSource = BHXH.HR.Business.HrQuaTrinhCongTac.GetData(bientoancuc.MaNhanVien.ToString());
            }
        }

        private void SimpleButtonSuaQTCT_Click(object sender, EventArgs e)
        {
            MruEditThoiGianQTCT.Enabled = true;
            MruEditChiTietQTCT.Enabled = true;
            lookUpEditBangCap.Enabled = true;
            GridControlChiTietDaoTao.Enabled = true;
            SimpleButtonThemQTCT.Enabled =false  ;
            SimpleButtonSuaQTCT.Enabled = false;
            SimpleButtonXoaQTCT.Enabled = false;
            SimpleButtonGhiQTCT.Enabled = false;
            SimpleButtonGhiSuaQTCT.Enabled =true ;
            SimpleButtonQuaQTCT.Enabled = true;
        }

        private void SimpleButtonGhiSuaQTCT_Click(object sender, EventArgs e)
        {
            string code = GridViewQuaTrinhCongTac.GetRowCellValue(GridViewQuaTrinhCongTac.GetSelectedRows().First(), "QuaTrinhCongTacID").ToString();
            DialogResult d = MessageBox.Show("Bạn có muốn sửa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.HR.Business.HrQuaTrinhCongTac.Edit(code, MruEditThoiGianQTCT.EditValue.ToString(), MruEditChiTietQTCT.EditValue.ToString() );

                MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GridControlQuaTrinhCongTac.DataSource = BHXH.HR.Business.HrQuaTrinhCongTac.GetData(bientoancuc.MaNhanVien.ToString());
            }
            SimpleButtonGhiSuaQTCT.Enabled =false ;
            GridControlQuaTrinhCongTac.Enabled = true;
            SimpleButtonThemQTCT.Enabled = true;
            SimpleButtonSuaQTCT.Enabled = true;
            SimpleButtonXoaQTCT.Enabled = true;
            SimpleButtonGhiQTCT.Enabled = true;
            SimpleButtonGhiSuaQTCT.Enabled = false;
            SimpleButtonQuaQTCT.Enabled = true;
        }

        private void SimpleButtonThemQHGD_Click(object sender, EventArgs e)
        {
            lookUpEditQuanHeGiaDinh.Enabled = true;
            lookUpEditQuanHeGiaDinh.Text = "";
            MruEditHoTen.Enabled = true;
            MruEditHoTen.Text = "";
            MemoEditChiTiet.Enabled = true;
            MemoEditChiTiet.Text = "";
            MruEditNamSinh.Enabled = true;
            MruEditNamSinh.Text = "";
            SimpleButtonSuaQHGD.Enabled = false;
            SimpleButtonXoaQHGD.Enabled = false;
            SimpleButtonGhiQHGD.Enabled = true;
        }

        private void SimpleButtonGhiQHGD_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt16(GridViewQuanHeGiaDinh.RowCount.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.HR.Business.HrQuanHeGiaDinh.New(bientoancuc.MaNhanVien, stt + 1, lookUpEditQuanHeGiaDinh.EditValue.ToString(), MruEditHoTen.EditValue.ToString(),MruEditNamSinh.EditValue.ToString(),MemoEditChiTiet.Text);
            }

            SimpleButtonThemQHGD.Enabled = true;
            SimpleButtonSuaQHGD.Enabled = true;
            SimpleButtonXoaQHGD.Enabled = true;
            SimpleButtonGhiQHGD.Enabled = false;
            SimpleButtonQuaQHGD.Enabled = true;
            this.GridControlQuanHeGiaDinh.DataSource = BHXH.HR.Business.HrQuanHeGiaDinh.GetData(bientoancuc.MaNhanVien);
            GridControlQuanHeGiaDinh.Enabled = true;
            lookUpEditQuanHeGiaDinh.Enabled = false;
            lookUpEditQuanHeGiaDinh.Text = "";
            MruEditHoTen.Enabled = false;
            MruEditHoTen.Text = "";
            MruEditNamSinh.Enabled = false;
            MruEditNamSinh.Text = "";
            MemoEditChiTiet.Enabled = false;
            MemoEditChiTiet.Text = "";
            SimpleButtonSuaQTCT.Enabled = true;
            SimpleButtonXoaQTCT.Enabled = true;
            SimpleButtonGhiQTCT.Enabled = false;
        }

        private void SimpleButtonXoaQHGD_Click(object sender, EventArgs e)
        {
            try
            {
                string code = GridViewQuanHeGiaDinh.GetRowCellValue(GridViewQuanHeGiaDinh.GetSelectedRows().First(), "QuanHeGiaDinhID").ToString();
                DialogResult d = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BHXH.HR.Business.HrQuanHeGiaDinh.Delete(code);
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải chọn dòng cần xóa. \n Chi tiết: " + ex.Message);
            }
            finally
            {
                this.GridControlQuanHeGiaDinh.DataSource = BHXH.HR.Business.HrQuanHeGiaDinh.GetData(bientoancuc.MaNhanVien.ToString());
            }
        }

        private void SimpleButtonSuaQHGD_Click(object sender, EventArgs e)
        {
            lookUpEditQuanHeGiaDinh.Enabled = true;
            MruEditHoTen.Enabled = true;
            MruEditNamSinh.Enabled = true;
            MemoEditChiTiet.Enabled = true;
            GridControlQuanHeGiaDinh.Enabled = false;
            SimpleButtonThemQHGD.Enabled = false;
            SimpleButtonSuaQHGD.Enabled = false;
            SimpleButtonXoaQHGD.Enabled = false;
            SimpleButtonGhiQHGD.Enabled = false;
            SimpleButtonGhiSuaQHGD.Enabled = true;
            SimpleButtonQuaQTCT.Enabled = true;
        }

        private void SimpleButtonGhiSuaQHGD_Click(object sender, EventArgs e)
        {
            string code = GridViewQuanHeGiaDinh.GetRowCellValue(GridViewQuanHeGiaDinh.GetSelectedRows().First(), "QuanHeGiaDinhID").ToString();
            DialogResult d = MessageBox.Show("Bạn có muốn sửa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.HR.Business.HrQuanHeGiaDinh.Edit(code, lookUpEditQuanHeGiaDinh.EditValue.ToString(), MruEditHoTen.Text, MruEditNamSinh.Text , MemoEditChiTiet.Text );

                MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GridControlQuanHeGiaDinh.DataSource = BHXH.HR.Business.HrQuanHeGiaDinh.GetData(bientoancuc.MaNhanVien.ToString());
            }
            SimpleButtonGhiSuaQTCT.Enabled = false;
            GridControlQuanHeGiaDinh.Enabled = true;
            SimpleButtonThemQHGD.Enabled = true;
            SimpleButtonSuaQHGD.Enabled = true;
            SimpleButtonXoaQHGD.Enabled = true;
            SimpleButtonGhiQHGD.Enabled = true;
            SimpleButtonGhiSuaQHGD.Enabled = false;
            SimpleButtonQuaQHGD.Enabled = true;
        }

        private void SimpleButtonThemKTKL_Click(object sender, EventArgs e)
        {
            ComboBoxEditLoaiKTKL.Enabled = true;
            ComboBoxEditLoaiKTKL.Text = "";
            lookUpEditKTKL.Enabled = true;
            lookUpEditKTKL.Text = "";
            MruEditNam.Enabled = true;
            MruEditNam.Text = "";
            MruEditGhiChu.Enabled = true;
            MruEditGhiChu.Text = "";
            GridControlKhenThuongKyLuat.Enabled = false;
            SimpleButtonSuaKTKL.Enabled = false;
            SimpleButtonXoaKTKL.Enabled = false;
            SimpleButtonGhiKTKL.Enabled = true;
        }

        private void SimpleButtonGhiKTKL_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt16(GridViewKhenThuongKyLuat.RowCount.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.HR.Business.HrKhenThuongKyLuat.New(bientoancuc.MaNhanVien, stt + 1, lookUpEditKTKL.EditValue.ToString(), MruEditNam.Text, MruEditGhiChu.Text);
            }

            SimpleButtonThemKTKL.Enabled = true;
            SimpleButtonSuaKTKL.Enabled = true;
            SimpleButtonXoaKTKL.Enabled = true;
            SimpleButtonGhiKTKL.Enabled = false;
            SimpleButtonQuaKTKL.Enabled = true;
            this.GridControlKhenThuongKyLuat.DataSource = BHXH.HR.Business.HrKhenThuongKyLuat.GetData(bientoancuc.MaNhanVien);
            GridControlKhenThuongKyLuat.Enabled = true;
            ComboBoxEditLoaiKTKL.Enabled = false;
            ComboBoxEditLoaiKTKL.Text = "";
            lookUpEditKTKL.Enabled = false;
            lookUpEditKTKL.Text = "";
            MruEditNam.Enabled = false;
            MruEditNam.Text = "";
            MruEditGhiChu.Enabled = false;
            MruEditGhiChu.Text = "";
            SimpleButtonSuaKTKL.Enabled = true;
            SimpleButtonXoaKTKL.Enabled = true;
            SimpleButtonGhiKTKL.Enabled = false;
        }

        private void SimpleButtonThemQTL_Click(object sender, EventArgs e)
        {
            ComboBoxEditLoaiQTL.Enabled = true;
            ComboBoxEditLoaiQTL.Text = "";
            MruEditTuThang.Enabled = true;
            MruEditTuThang.Text = "";
            MruEditDenThang.Enabled = true;
            MruEditDenThang.Text = "";
            MruEditMucLuong.Enabled = true;
            MruEditMucLuong.Text = "";
            MruEditHSLQTL.Enabled = true;
            MruEditHSLQTL.Text = "";
            MruEditPCChucVu.Enabled = true;
            MruEditPCChucVu.Text = "";

            MruEditPCThamNien.Enabled = true;
            MruEditPCThamNien.Text = "";
            MruEditPCDocHai.Enabled = true;
            MruEditPCDocHai.Text = "";
            MruEditPCTrachNhiem.Enabled = true;
            MruEditPCTrachNhiem.Text = "";
            MruEditPCKhuVuc.Enabled = true;
            MruEditPCKhuVuc.Text = "";
            MruEditCongViec.Enabled = true;
            MruEditCongViec.Text = "";

            SimpleButtonSuaQTL.Enabled = false;
            SimpleButtonXoaQTL.Enabled = false;
            SimpleButtonGhiQTL.Enabled = true;
        }

        private void SimpleButtonGhiQTL_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt16(GridViewQuaTrinhLuong.RowCount.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                BHXH.HR.Business.HrQuaTrinhLuong.New(bientoancuc.MaNhanVien, stt + 1, ComboBoxEditLoaiQTL.Text, MruEditTuThang.Text,
                    MruEditDenThang.EditValue.ToString(), Convert.ToUInt16 (MruEditMucLuong.EditValue.ToString()), Convert.ToDecimal(MruEditHSLQTL.Text), 
                    Convert.ToDecimal(MruEditPCChucVu.Text), Convert.ToDecimal (MruEditPCThamNien.Text),
                    Convert.ToDecimal(MruEditPCDocHai.Text) , Convert.ToDecimal (MruEditPCTrachNhiem.Text), Convert.ToDecimal(MruEditPCKhuVuc.Text) , MruEditCongViec.Text);
            }

            SimpleButtonThemQTL.Enabled = true;
            SimpleButtonSuaQTL.Enabled = true;
            SimpleButtonXoaQTL.Enabled = true;
            SimpleButtonGhiQTL.Enabled = false;
            SimpleButtonQuaQTL.Enabled = true;
            this.GridControlQuaTrinhLuong.DataSource = BHXH.HR.Business.HrQuaTrinhLuong.GetData(bientoancuc.MaNhanVien);
            GridControlQuaTrinhLuong.Enabled = true;
        }

        private void lookUpEditKTKL_EditValueChanged(object sender, EventArgs e)
        {
            this.lookUpEditKTKL.Properties.DataSource = BHXH.List.Business.ListKTKL.GetAll();
            this.lookUpEditKTKL.Properties.DisplayMember = "TenKTKL";
            this.lookUpEditKTKL.Properties.ValueMember = "MaKTKL";
        }

        private void lookUpEditTinhTQ_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.lookUpEditQuanTQ.Properties.DataSource = BHXH.List.Business.ListQuanHuyen.GetToTinh(this.lookUpEditTinhTQ.EditValue.ToString());
                this.lookUpEditQuanTQ.Properties.DisplayMember = "TenQuanHuyen";
                this.lookUpEditQuanTQ.Properties.ValueMember = "QuanHuyenID";
            }
            catch
            {

            }
        }

        private void lookUpEditQuanTQ_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.lookUpEditPhuongTQ.Properties.DataSource = BHXH.List.Business.ListXaPhuong.GetToQuan(this.lookUpEditQuanTQ.EditValue.ToString());
                this.lookUpEditPhuongTQ.Properties.DisplayMember = "TenXaPhuong";
                this.lookUpEditPhuongTQ.Properties.ValueMember = "XaPhuongID";
            }
            catch
            {

            }
        }

        private void lookUpEditPhuongQQ_EditValueChanged(object sender, EventArgs e)
        {
            txtQueQuan.Text = lookUpEditTinhQQ.Text + ", " + lookUpEditQuanQQ.Text + ", " + lookUpEditPhuongQQ.Text;
        }

        private void lookUpEditPhuongTQ_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void NavBarControlDSNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void NavBarControlDSNhanVien_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            
        }

        private void NavBarControlDSNhanVien_GroupCollapsed(object sender, NavBarGroupEventArgs e)
        {
            
        }

        

        private void NavBarControlDSNhanVien1_Click(object sender, EventArgs e)
        {

        }

        private void NavBarControlDSNhanVien1_GroupCollapsed(object sender, NavBarGroupEventArgs e)
        {
         
        }

        private void NavBarControlDSNhanVien1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ID = e.Link.Item.Tag.ToString();
            nv = BHXH.HR.Business.HrNhanVien.GetNhanVien(e.Link.Item.Tag.ToString());
            bientoancuc.MaNhanVien = nv.MaNhanVien.ToString();
            LoadData();
            
        }
        private void LoadData()
        {
            this.Text = "Hồ sơ lí lịch cán bộ công chức -{" + nv.TenNhanVien + "}";
            this.LoadTabThongTinNhanVien(ID);
            //chi tiết đào tạo
            this.GridControlChiTietDaoTao.DataSource = BHXH.HR.Business.HrChiTietDaoTao.GetData(ID);
            this.lookUpEditNganhHoc.Properties.DataSource = BHXH.List.Business.ListCMDaoTao.GetAll();
            this.lookUpEditNganhHoc.Properties.DisplayMember = "TenCMDaoTao";
            this.lookUpEditNganhHoc.Properties.ValueMember = "MaCMDaoTao";

            this.lookUpEditLoaiHinhDaoTao.Properties.DataSource = BHXH.List.Business.ListLHDaoTao.GetAll();
            this.lookUpEditLoaiHinhDaoTao.Properties.DisplayMember = "TenLHDaoTao";
            this.lookUpEditLoaiHinhDaoTao.Properties.ValueMember = "MaLHDaoTao";

            this.lookUpEditBangCap.Properties.DataSource = BHXH.List.Business.ListBangCap.GetAll();
            this.lookUpEditBangCap.Properties.DisplayMember = "TenBangCap";
            this.lookUpEditBangCap.Properties.ValueMember = "MaBangCap";
            //Quá trình công tác
            this.GridControlQuaTrinhCongTac.DataSource = BHXH.HR.Business.HrQuaTrinhCongTac.GetData(ID);

            //Quan hệ gia đình
            this.GridControlQuanHeGiaDinh.DataSource = BHXH.HR.Business.HrQuanHeGiaDinh.GetData(ID);

            this.lookUpEditQuanHeGiaDinh.Properties.DataSource = BHXH.List.Business.ListQuanHeGD.GetAll();
            this.lookUpEditQuanHeGiaDinh.Properties.DisplayMember = "TenQuanHeGD";
            this.lookUpEditQuanHeGiaDinh.Properties.ValueMember = "MaQuanHeGD";
            //Khen thưởng kỹ luật
            this.GridControlKhenThuongKyLuat.DataSource = BHXH.HR.Business.HrKhenThuongKyLuat.GetData(ID);
            this.lookUpEditKTKL.Properties.DataSource = BHXH.List.Business.ListKTKL.GetAll();
            this.lookUpEditKTKL.Properties.DisplayMember = "TenKTKL";
            this.lookUpEditKTKL.Properties.ValueMember = "MaKTKL";
            //Quá trình lương
            this.GridControlQuaTrinhLuong.DataSource = BHXH.HR.Business.HrQuaTrinhLuong.GetData(ID);
            //Quá trình BHXH
            this.GridControlQuaTrinhBHXH.DataSource = BHXH.HR.Business.HrQuaTrinhBHXH.GetData(ID);
        }

        private void NavBarControlDSNhanVien_GroupExpanded(object sender, NavBarGroupEventArgs e)
        {
            int TongSo = 0;
            string st = NavBarControlDSNhanVien.Groups[NavBarControlDSNhanVien.Groups.IndexOf(NavBarControlDSNhanVien.ActiveGroup)].Tag.ToString();
            MaPhongBan = st;
            string TenPhongBan= NavBarControlDSNhanVien.Groups[NavBarControlDSNhanVien.Groups.IndexOf(NavBarControlDSNhanVien.ActiveGroup)].Caption.ToString();
            if (TenPhongBan.Substring(0, 4) != "BHXH")
            {
                NavBarControlDSNhanVien1.Visible = false;
                XtraTabControlHoSoNhanVien.Left  = NavBarControlDSNhanVien1.Left ;
                XtraTabControlHoSoNhanVien.Width = this.Width  - NavBarControlDSNhanVien.Width -50;
            }
            else
            {
                NavBarControlDSNhanVien1.Visible = true;
                XtraTabControlHoSoNhanVien.Left = ToaDo;
                XtraTabControlHoSoNhanVien.Width = this.Width - ToaDo + NavBarControlDSNhanVien1.Width -220;
            }
                
            ///xóa cũ

            for (int i = 0; i < NavBarControlDSNhanVien1.Groups.Count; i++)
                                NavBarControlDSNhanVien1.Groups[i].ItemLinks.Clear();
           
            ////add vào item bộ phận
            for (int i = 0; i < NavBarControlDSNhanVien1.Groups.Count; i++)
            {
                //////
                NavBarGroup currGroup = NavBarControlDSNhanVien1.Groups[i];
                MaBoPhan = NavBarControlDSNhanVien1.Groups[i].Tag.ToString();
                BHXH.Data.BHXHEntities ctx = new BHXH.Data.BHXHEntities();
                var queryNhanVien = from c in ctx.HrNhanVien
                                    join b in ctx.ListChucVu on c.MaChucVu equals b.MaChucVu
                                    where (c.MaBoPhan == MaBoPhan) && (c.MaPhongBan == MaPhongBan)
                                    orderby b.TenChucVu descending
                                    select new
                                    {
                                        c.MaNhanVien,
                                        c.TenNhanVien,
                                        b.MaChucVu    
                                    } ;
                foreach (var qNV in queryNhanVien)
                {
                    TongSo = 0;
                    NavBarItem item = new NavBarItem();
                    item.Caption = qNV.TenNhanVien;
                    item.Tag = qNV.MaNhanVien;
                    NavBarControlDSNhanVien1.Groups[i].ItemLinks.Add(item);
                    if ((qNV.MaChucVu.ToString()  =="20") || (qNV.MaChucVu.ToString() == "21") || (qNV.MaChucVu.ToString() == "30") || (qNV.MaChucVu.ToString() == "31"))
                    {
                        item.Appearance.ForeColor = Color.Red;
                        item.Appearance.Font= new Font(this.Font, FontStyle.Bold);
                        item.Appearance.Font = new Font(item.Appearance.Font.FontFamily, 10);


                    }
                        

                    TongSo++;
                }
                //if (BHXH.Util.TextUtil.TrimAccent(qNV.TenChucVu.ToString()) == "Pho giam doc BHXH quan")
                //{
                //    item.Appearance.BackColor2 = Color.Red;
                //    NavBarControlDSNhanVien1.
  


                //    }

            }
            
        }

        private void MruEditCVLamLN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SimpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    
