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

namespace BHXH.HR.UI
{
    public partial class frmHrNhanVien : Form
    {
        DataView ViewDMChucVu = new DataView();
        DataTable TableDMChucVu = new DataTable();
        public BHXH.Data.HrNhanVien nv = null;
        public frmHrNhanVien()
        {
            InitializeComponent();
        }
        private void TenQueQuan(string mTenPhuongQQ, string mTenQuanQQ, string mTenTinhQQ)
        {
            mTenPhuongQQ = "";
            mTenQuanQQ = "";
            mTenTinhQQ = "";
            this.MruEditQueQuan.EditValue = mTenPhuongQQ;
            if (!string.IsNullOrEmpty(mTenQuanQQ))
            {
                if (string.IsNullOrEmpty(this.MruEditQueQuan.EditValue.ToString()))
                {
                    this.MruEditQueQuan.EditValue = this.MruEditQueQuan.EditValue + mTenQuanQQ.ToString();
                }
                else
                {
                    this.MruEditQueQuan.EditValue = this.MruEditQueQuan.EditValue + ", " + mTenQuanQQ.ToString();
                }
            }
            if (!string.IsNullOrEmpty(mTenTinhQQ))
            {
                if (string.IsNullOrEmpty(this.MruEditQueQuan.EditValue.ToString()))
                {
                    this.MruEditQueQuan.EditValue = this.MruEditQueQuan.EditValue + mTenTinhQQ.ToString();
                }
                else
                {
                    this.MruEditQueQuan.EditValue = this.MruEditQueQuan.EditValue + ", " + mTenTinhQQ.ToString();
                }
            }
        }
        private void frmHrNhanVien_Load(object sender, EventArgs e)
        {
            
            string MaPhongBan;
            MaPhongBan = "";
            BHXH.Data.BHXHEntities ctx = new BHXH.Data.BHXHEntities();
            var queryPhongBan = from c in ctx.ListPhongBan
                                    //where c.MaTDVanHoa == MaTDVanHoa
                                select new
                                {
                                    c.MaPhongBan,
                                    c.TenPhongBan
                                };


            foreach (var qPB in queryPhongBan)
            {
                NavBarGroup group = new NavBarGroup();
                group.Caption = qPB.TenPhongBan;
                group.Tag = qPB.MaPhongBan;
                MaPhongBan = qPB.MaPhongBan;
                NavBarControlDSNhanVien.Groups.Add(group);
                var queryNhanVien = from c in ctx.HrNhanVien
                                    where c.MaPhongBan == MaPhongBan
                                    select new
                                    {
                                        c.MaNhanVien,
                                        c.TenNhanVien
                                    };
                foreach (var qNV in queryNhanVien)
                {
                    NavBarItem item = new NavBarItem();
                    item.Caption = qNV.TenNhanVien;
                    item.Tag = qNV.MaNhanVien;
                    group.ItemLinks.Add(item);
                }
            }
           
        }
        private void NavBarControlDSNhanVien_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            nv= BHXH.HR.Business.HrNhanVien.GetNhanVien( e.Link.Item.Tag.ToString());
            this.LoadTabThongTinNhanVien(e.Link.Item.Tag.ToString());
            this.GridControlChiTietDaoTao.DataSource = BHXH.HR.Business.HrChiTietDaoTao.GetData(e.Link.Item.Tag.ToString());

            this.GridControlQuaTrinhCongTac.DataSource = BHXH.HR.Business.HrQuaTrinhCongTac.GetData(e.Link.Item.Tag.ToString());
            this.GridControlQuanHeGiaDinh.DataSource = BHXH.HR.Business.HrQuanHeGiaDinh.GetData(e.Link.Item.Tag.ToString());

            this.GridControlKhenThuongKyLuat.DataSource = BHXH.HR.Business.HrKhenThuongKyLuat.GetData(e.Link.Item.Tag.ToString());
            this.GridControlQuaTrinhLuong.DataSource = BHXH.HR.Business.HrQuaTrinhLuong.GetData(e.Link.Item.Tag.ToString());
            this.GridControlQuaTrinhBHXH.DataSource = BHXH.HR.Business.HrQuaTrinhBHXH.GetData(e.Link.Item.Tag.ToString());




        }
        void LoadTabThongTinNhanVien(string NhanVienID)
        {
           
            //MessageBox.Show(NhanVienID);
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
            MruEditMaTinhQQ.EditValue = nv.MaTinhQQ;
            MruEditMaQuanQQ.EditValue = nv.QuanHuyenIDQQ;
            MruEditMaPhuongQQ.EditValue = nv.XaPhuongIDQQ;
            string mTenPhuongQQ = "";
            string mTenQuanQQ = "";
            string mTenTinhQQ = "";
            mTenPhuongQQ = BHXH.List.Business.ListXaPhuong.GetData(int.Parse(MruEditMaPhuongQQ.Text)).TenXaPhuong;
            mTenQuanQQ = BHXH.List.Business.ListQuanHuyen.GetData(int.Parse(MruEditMaQuanQQ.Text)).TenQuanHuyen;
            mTenTinhQQ = BHXH.List.Business.ListTinh.GetTinh(MruEditMaTinhQQ.Text).TenTinh;
            TenQueQuan(mTenPhuongQQ, mTenQuanQQ, mTenTinhQQ);
            MruEditQueQuan.EditValue = mTenPhuongQQ + ", " + mTenQuanQQ + ", " + mTenTinhQQ;
            ///Trú quán (nơi ở hiện nay)
            MruEditMaTinhTQ.EditValue = nv.MatinhTQ;
            MruEditMaQuanTQ.EditValue = nv.QuanHuyenIDTQ;
            MruEditMaPhuongTQ.EditValue = nv.XaPhuongIDTQ;
            string mTenPhuongTQ = "";
            string mTenQuanTQ = "";
            string mTenTinhTQ = "";
            mTenPhuongTQ = BHXH.List.Business.ListXaPhuong.GetData(int.Parse(MruEditMaPhuongTQ.Text)).TenXaPhuong;
            mTenQuanTQ = BHXH.List.Business.ListQuanHuyen.GetData(int.Parse(MruEditMaQuanTQ.Text)).TenQuanHuyen;
            mTenTinhTQ = BHXH.List.Business.ListTinh.GetTinh(MruEditMaTinhTQ.Text).TenTinh;
            MruEditTruQuan.EditValue = mTenPhuongTQ + ", " + mTenQuanTQ + ", " + mTenTinhTQ;
            /////////////////////
            MruEditSoNha.EditValue = nv.SoNha;
            MruEditTruQuan.EditValue = mTenPhuongTQ + ", " + mTenQuanTQ + ", " + mTenTinhTQ;
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
            lookUpEditDanToc.EditValue = nv.MaChucVu;
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
            if (!string.IsNullOrEmpty(MruEditMaKCB.Text))
                MruEditTenKCB.EditValue = BHXH.List.Business.ListNoiKCB.GetNoiKCB(MruEditMaKCB.Text).TenNoiKCB.ToString();
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
           
        }

        private void GridViewChiTietDaoTao_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)

        {
            
            //MessageBox.Show( GridViewChiTietDaoTao.GetRowCellValue(GridViewChiTietDaoTao.GetSelectedRows().First(), "MaCMDaoTao").ToString());
        }

        private void MruEditMaChucVu_Click(object sender, EventArgs e)
        {
          
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

        }
        private void SimpleButtonGhi_Click(object sender, EventArgs e)
        {
            nv.TenNhanVien = this.MruEditTenNhanVien.Text;
            nv.SoHieuNV = this.MruEditSoHieuNV.Text;
            nv.GioiTinh = this.cboEditGioiTinh.Text;
            nv.TenKhac = this.MruEditTenKhac.Text;
            nv.MaCapUy = this.lookUpEditChucVuDang.EditValue.ToString();
            nv.MaCapUyKiem = this.lookUpEditChucVuDangKiem.EditValue.ToString();
            nv.MaChucVu = this.lookUpEditChucVu.EditValue.ToString();
            nv.MaChucDanh = this.lookUpEditChucDanh.EditValue.ToString();
            nv.PCChucVu = Convert.ToDecimal(CalcEditPCChucVu.EditValue);
            nv.NgayBoNhiem = Convert.ToDateTime(DateEditNgayBoNhiem.Text);
            nv.NgaySinh = Convert.ToDateTime(DateEditNgaySinh.Text);
            //QQ,TQ
            nv.SoNha = this.MruEditSoNha.Text;
            nv.DTNha = this.MruEditDTNha.Text;
            nv.DTCoQuan = this.MruEditDTCoQuan.Text;
            nv.DTDiDong = this.MruEditDTDiDong.Text;
            nv.Email = this.MruEditEmail.Text;
            nv.DTNguoiNha = this.MruEditDTNguoiNha.Text;
            nv.TenNguoiNha = this.MruEditTenNguoiNha.Text;
            nv.MaDanToc = this.lookUpEditDanToc.EditValue.ToString();
            nv.MaTonGiao = this.lookUpEditTonGiao.EditValue.ToString();
            nv.MaThanhPhanGD = this.lookUpEditThanhPhanGD.EditValue.ToString();
            nv.NgheTruocTD = this.MruEditNgheTruocTD.Text;
            nv.NgayTD = Convert.ToDateTime(this.DateEditNgayTD.Text);
            nv.NgayCQ = Convert.ToDateTime(this.DateEditNgayCQ.Text);
            nv.CoQuanTD = this.MruEditCoQuanTD.Text;

            try
            {
                nv.NgayCM = Convert.ToDateTime(this.DateEditNgayCM.EditValue);
            }
            catch
            {
                nv.NgayCM = null;
            }

            nv.NgayDang = Convert.ToDateTime(this.DateEditNgayDang.Text);
            nv.NgayDangCT = Convert.ToDateTime(this.DateEditNgayDangCT.Text);
            nv.NgayTCXH = Convert.ToDateTime(this.DateEditNgayTCXH.Text);
            nv.NgayNhapNgu = Convert.ToDateTime(this.DateEditNgayNhapNgu.Text);
            nv.NgayXuatNgu = Convert.ToDateTime(this.DateEditNgayXuatNgu.Text);
            nv.QuanHam = this.MruEditQuanHam.Text;
            nv.MaTDVanHoa = this.lookUpEditTDVanHoa.EditValue.ToString();
            nv.MaTDDaoTao = this.lookUpEditTDDaoTao.EditValue.ToString();
            nv.MaNgoaiNgu = this.lookUpEditNgoaiNgu.EditValue.ToString();
            nv.MaTDNgoaiNgu = this.lookUpEditTDNgoaiNgu.EditValue.ToString();
            nv.CVDangLam = this.MruEditCVDangLam.Text;
            nv.MaNgach = this.lookUpEditNgach.EditValue.ToString();
            nv.Bac = this.MruEditBac.Text;
            nv.HSL = Convert.ToDecimal(this.MruEditHSL.Text);
            nv.DHDuocPhong = this.MruEditDHDuocPhong.Text;
            nv.SoTruongCT = this.MruEditSoTruongCT.Text;
            nv.CVLamLN = this.MruEditCVLamLN.Text;
            nv.KhenThuong = this.MruEditKhenThuong.Text;
            nv.KyLuat = this.MruEditKyLuat.Text;
            nv.SucKhoe = this.MruEditSucKhoe.Text;
            nv.ChieuCao = this.MruEditChieuCao.Text;
            nv.CanNang = this.MruEditCanNang.Text;
            nv.NhomMau = this.cboEditNhomMau.Text;
            nv.SoCMND = this.MruEditSoCMND.Text;
            nv.MaLoaiTB = this.lookUpEditTB.EditValue.ToString();
            Boolean GDLietSy = this.CheckEditGDLietSy.Checked;
            DialogResult d = MessageBox.Show("Bạn có muốn sửa thông tin nhân viên" + nv.TenNhanVien, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                //BHXH.HR.Business.HrNhanVien.Edit (MaNhanVienSua,nv.TenNhanVien,SoHieuNV,GioiTinh,TenKhac,MaCapUy,MaCapUyKiem,MaChucVu,MaChucDanh,PCCV,NgayBoNhiem,NgaySinh,
                //    SoNha,DTNha,DTCoQuan,DTDiDong,Email,DTNguoiNha, TenNguoiNha, MaDanToc,MaTonGiao, MaTPGiaDinh,  NgheTruocTD, NgayTD, NgayCQ, CoQuanTD, NgayCM,NgayDang,
                //    NgayDangCT, NgayTCXH, NgayNhapNgu, NgayXuatNgu, QuanHam, MaTDVanHoa, MaTDDaoTao, MaNgoaiNgu, MaTDNgoaiNgu, CVDangLam, MaNgach, Bac, HSL, DHDuocPhong,
                //    SoTruongCT, CVLamLN, KhenThuong, KyLuat, SucKhoe, ChieuCao, CanNang, NhomMau, SoCMND, MaLoaiTB, GDLietSy);
                //    BHXH.List.Business.ListKTKL.Edit(txtMa.Text, txtTen.Text);

                BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

                
                
                ctx. SaveChanges();
                
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
    
