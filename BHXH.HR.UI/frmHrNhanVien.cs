using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using System.IO;
using System.Collections;



namespace BHXH.HR.UI
{
    public partial class frmHrNhanVien : Form
    {
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
            //kgghtkhjtkjh fdf
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
            this.LoadTabThongTinNhanVien(e.Link.Item.Tag.ToString());

            this.GridControlQuaTrinhCongTac.DataSource = BHXH.HR.Business.HrQuaTrinhCongTac.GetData(e.Link.Item.Tag.ToString());
            this.GridControlQuanHeGiaDinh.DataSource = BHXH.HR.Business.HrQuanHeGiaDinh.GetData(e.Link.Item.Tag.ToString());


        }
        void LoadTabThongTinNhanVien(string NhanVienID)
        {


            //MessageBox.Show(NhanVienID);
            MruEditSoHieuNV.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).SoHieuNV;
            MruEditTenNhanVien.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).TenNhanVien;
            cboEditGioiTinh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).GioiTinh;
            MruEditTenKhac.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).TenKhac;
            ////////Chức vụ Đảng
            MruEditMaChucVuDang.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaCapUy;
            MruEditTenChucVuDang.EditValue = BHXH.List.Business.ListChucVuDang.GetData(MruEditMaChucVuDang.Text).TenChucVu;
            
            ///////////////Chức vu Đảng kiêm
            MruEditMaCVDangKiem.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaCapUyKiem;
            MruEditTenCVDangKiem.EditValue = BHXH.List.Business.ListChucVuDang.GetData(MruEditMaCVDangKiem.Text).TenChucVu;

            ////////////CHức vụ
            MruEditMaChucVu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaChucVu;
            MruEditTenChucVu.EditValue = BHXH.List.Business.ListChucVu.GetData(MruEditMaChucVu.Text).TenChucVu;
            ////////////CHức danh
            MruEditMaChucDanh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaChucDanh;
            MruEditTenChucDanh.EditValue = BHXH.List.Business.ListChucDanh.GetData(MruEditMaChucDanh.Text).TenChucDanh;
            ////
            CalcEditPCChucVu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).PCChucVu;
            DateEditNgayBoNhiem.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayBoNhiem;
            DateEditNgaySinh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgaySinh;
            MruEditNoiSinh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NoiSinh;
            //Quê quán
            MruEditMaTinhQQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaTinhQQ;
            MruEditMaQuanQQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).QuanHuyenIDQQ;
            MruEditMaPhuongQQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).XaPhuongIDQQ;
            string mTenPhuongQQ = "";
            string mTenQuanQQ = "";
            string mTenTinhQQ = "";
            mTenPhuongQQ = BHXH.List.Business.ListXaPhuong.GetData(int.Parse(MruEditMaPhuongQQ.Text)).TenXaPhuong;
            mTenQuanQQ = BHXH.List.Business.ListQuanHuyen.GetData(int.Parse(MruEditMaQuanQQ.Text)).TenQuanHuyen;
            mTenTinhQQ = BHXH.List.Business.ListTinh.GetTinh(MruEditMaTinhQQ.Text).TenTinh;
            TenQueQuan(mTenPhuongQQ, mTenQuanQQ, mTenTinhQQ);
            MruEditQueQuan.EditValue = mTenPhuongQQ + ", " + mTenQuanQQ + ", " + mTenTinhQQ;
            ///Trú quán (nơi ở hiện nay)
            MruEditMaTinhTQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MatinhTQ;
            MruEditMaQuanTQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).QuanHuyenIDTQ;
            MruEditMaPhuongTQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).XaPhuongIDTQ;
            string mTenPhuongTQ = "";
            string mTenQuanTQ = "";
            string mTenTinhTQ = "";
            mTenPhuongTQ = BHXH.List.Business.ListXaPhuong.GetData(int.Parse(MruEditMaPhuongTQ.Text)).TenXaPhuong;
            mTenQuanTQ = BHXH.List.Business.ListQuanHuyen.GetData(int.Parse(MruEditMaQuanTQ.Text)).TenQuanHuyen;
            mTenTinhTQ = BHXH.List.Business.ListTinh.GetTinh(MruEditMaTinhTQ.Text).TenTinh;
            MruEditTruQuan.EditValue = mTenPhuongTQ + ", " + mTenQuanTQ + ", " + mTenTinhTQ;
            /////////////////////
            MruEditSoNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).SoNha;
            MruEditTruQuan.EditValue = mTenPhuongTQ + ", " + mTenQuanTQ + ", " + mTenTinhTQ;
            ///////////
            MruEditDTNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).DTNha;
            MruEditDTCoQuan.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).DTCoQuan;
            MruEditDTDiDong.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).DTDiDong;
            MruEditEmail.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).Email;
            MruEditDTNguoiNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).DTNguoiNha;
            MruEditTenNguoiNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).DTNguoiNha;
            /////Dân tộc
            MruEditMaDanToc.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaDanToc;
            MruEditTenDanToc.EditValue = BHXH.List.Business.ListDanToc.GetData(MruEditMaDanToc.Text).TenDanToc;
            /////Tôn giáo
            MruEditMaTonGiao.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaTonGiao;
            MruEditTenTonGiao.EditValue = BHXH.List.Business.ListTonGiao.GetTonGiao(MruEditMaTonGiao.Text).TenTonGiao;
            /////////
            DateEditNgay_TD.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayTD;
            DateEditNgay_CQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayCQ;
            DateEditNgay_CM.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayCM;
            DateEditNgay_Dang.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayDang;
            DateEditNgay_DangCT.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayDangCT;
            //chi bộ
            MruEditMaChiBo.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaChiBo;
            if (!string.IsNullOrEmpty(MruEditMaChiBo.Text))
            {
                MruEditTenChiBo.EditValue = BHXH.List.Business.ListChiBo.GetData(MruEditMaChiBo.Text).TenChiBo;
            }
            else
            {
                MruEditTenChiBo.EditValue = "";
            }
        
            //////
            DateEditNgay_TCXH.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayTCXH;
            DateEditNgayNhapNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayNhapNgu;
            DateEditNgayXuatNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NgayXuatNgu;
            MruEditQuanHam.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).QuanHam;
            //Trình độ văn hóa
            MruEditMaTDVanHoa.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaTDVanHoa;
            MruEditTenTDVanHoa.EditValue = BHXH.List.Business.ListTDVanHoa.GetTDVanHoa(MruEditMaTDVanHoa.Text).TenTDVanHoa;
            ///Trình độ đào tạo
            MruEditMaTDDaoTao.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaTDDaoTao;
            MruEditTenTDDaoTao.EditValue = BHXH.List.Business.ListTDDaoTao.GetData(MruEditMaTDDaoTao.Text).TenTDDaoTao;
            //Trình độ lí luận chính trị
            MruEditMaTDLLCT.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaTDLLCT;
            MruEditTenTDLLCT.EditValue = BHXH.List.Business.ListTDLLCT.GetData(MruEditMaTDLLCT.Text).TenTDLLCT;
            //Ngoại ngữ
            MruEditMaNgoaiNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaNgoaiNgu;
            MruEditTenNgoaiNgu.EditValue = BHXH.List.Business.ListNgoaiNgu.GetData(MruEditMaNgoaiNgu.Text).TenNgoaiNgu;

            //Trình độ ngoại ngữ
            MruEditMaTDNgoaiNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaTDNgoaiNgu;
            MruEditTenTDNgoaiNgu.EditValue = BHXH.List.Business.ListTDNgoaiNgu.GetData(MruEditMaTDNgoaiNgu.Text).TenTDNgoaiNgu;
            ////
            MruEditCVDangLam.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).CVDangLam;
            MruEditMaNgach.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaNgach;
            MruEditBac.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).Bac;
            MruEditHSL.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).HSL;
            //tên ngạch
            MruEditTenNgach.EditValue = BHXH.HR.Business.HrThangBangLuong.GetTenNgach(MruEditMaNgach.Text).TenNgach;
            MruEditDHDuocPhong.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).DHDuocPhong;
            MruEditSoTruongCT.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).SoTruongCT;
            MruEditCVLamLN.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).CVLamLN;
            MruEditKhenThuong.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).KhenThuong;
            MruEditKyLuat.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).KyLuat;
            MruEditSucKhoe.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).SucKhoe;
            MruEditChieuCao.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).ChieuCao;
            MruEditCanNang.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).CanNang;
            cboEditNhomMau.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).NhomMau;
            MruEditSoCMND.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).SoCMND;
            CheckEditGDLietSy.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).GDLietSy;
            //thương binh
            MruEditMaLoaiTB.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID).MaLoaiTB;
            if (!string.IsNullOrEmpty(MruEditMaLoaiTB.Text))
            {
                MruEditTenLoaiTB.EditValue = BHXH.List.Business.ListLoaiTB.GetData(MruEditMaLoaiTB.Text).TenLoaiTB;
            }
            //ảnh
            //try
            //{
            //    byte[] img = RetrieveImage();
            //    MemoryStream str = new MemoryStream(img);

            //    this.PictureEdit1.Image = Image.FromStream(str);

            //}
            //catch (Exception ex)
            //{
            //    this.PictureEdit1.Image = null;
            //}


        }

        private void XtraTabPageQuaTrinhCongTac_Paint()
        {

        }

        private void NavBarControlDSNhanVien_Click(object sender, EventArgs e)
        {

        }
        //public byte[] RetrieveImage()
        //{
        //    byte[] imageData = null;
        //    SqlCommand cmd = new SqlCommand(" select AnhNV from dsnhanvien where idnhanvien = " + mIDChon.ToString, SoLieu);
        //    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
        //    {
        //        reader.Read();
        //        long bytesize = reader.GetBytes(0, 0, null, 0, 0);
        //        // Allocate byte array to hold image data
        //        imageData = new byte[bytesize];
        //        long bytesread = 0;
        //        int curpos = 0;
        //        int chunkSize = 1;
        //        while (bytesread < bytesize)
        //        {
        //            bytesread += reader.GetBytes(0, curpos, imageData, curpos, chunkSize);
        //            curpos += chunkSize;
        //        }
        //    }
        //    return imageData;
        //}

    }
}
