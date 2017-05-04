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

            BHXH.Data.HrNhanVien nv = BHXH.HR.Business.HrNhanVien.GetNhanVien(NhanVienID);
            //MessageBox.Show(NhanVienID);
            MruEditSoHieuNV.EditValue = nv.SoHieuNV;
            MruEditTenNhanVien.EditValue = nv.TenNhanVien;
            cboEditGioiTinh.EditValue = nv.GioiTinh;
            MruEditTenKhac.EditValue = nv.TenKhac;
            ////////Chức vụ Đảng
            MruEditMaChucVuDang.EditValue = nv.MaCapUy;
            MruEditTenChucVuDang.EditValue = BHXH.List.Business.ListChucVuDang.GetData(MruEditMaChucVuDang.Text).TenChucVu;
            
            ///////////////Chức vu Đảng kiêm
            MruEditMaCVDangKiem.EditValue = nv.MaCapUyKiem;
            MruEditTenCVDangKiem.EditValue = BHXH.List.Business.ListChucVuDang.GetData(MruEditMaCVDangKiem.Text).TenChucVu;

            ////////////CHức vụ
            MruEditMaChucVu.EditValue = nv.MaChucVu;
            MruEditTenChucVu.EditValue = BHXH.List.Business.ListChucVu.GetData(MruEditMaChucVu.Text).TenChucVu;
            ////////////CHức danh
            MruEditMaChucDanh.EditValue = nv.MaChucDanh;
            MruEditTenChucDanh.EditValue = BHXH.List.Business.ListChucDanh.GetData(MruEditMaChucDanh.Text).TenChucDanh;
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
            MruEditMaDanToc.EditValue = nv.MaDanToc;
            MruEditTenDanToc.EditValue = BHXH.List.Business.ListDanToc.GetData(MruEditMaDanToc.Text).TenDanToc;
            /////Tôn giáo
            MruEditMaTonGiao.EditValue = nv.MaTonGiao;
            MruEditTenTonGiao.EditValue = BHXH.List.Business.ListTonGiao.GetTonGiao(MruEditMaTonGiao.Text).TenTonGiao;
            /////////
            DateEditNgay_TD.EditValue = nv.NgayTD;
            DateEditNgay_CQ.EditValue = nv.NgayCQ;
            DateEditNgay_CM.EditValue = nv.NgayCM;
            DateEditNgay_Dang.EditValue = nv.NgayDang;
            DateEditNgay_DangCT.EditValue = nv.NgayDangCT;
            //chi bộ
            MruEditMaChiBo.EditValue = nv.MaChiBo;
            if (!string.IsNullOrEmpty(MruEditMaChiBo.Text))
            {
                MruEditTenChiBo.EditValue = BHXH.List.Business.ListChiBo.GetData(MruEditMaChiBo.Text).TenChiBo;
            }
            else
            {
                MruEditTenChiBo.EditValue = "";
            }
        
            //////
            DateEditNgay_TCXH.EditValue = nv.NgayTCXH;
            DateEditNgayNhapNgu.EditValue = nv.NgayNhapNgu;
            DateEditNgayXuatNgu.EditValue = nv.NgayXuatNgu;
            MruEditQuanHam.EditValue = nv.QuanHam;
            //Trình độ văn hóa
            MruEditMaTDVanHoa.EditValue = nv.MaTDVanHoa;
            MruEditTenTDVanHoa.EditValue = BHXH.List.Business.ListTDVanHoa.GetTDVanHoa(MruEditMaTDVanHoa.Text).TenTDVanHoa;
            ///Trình độ đào tạo
            MruEditMaTDDaoTao.EditValue = nv.MaTDDaoTao;
            MruEditTenTDDaoTao.EditValue = BHXH.List.Business.ListTDDaoTao.GetData(MruEditMaTDDaoTao.Text).TenTDDaoTao;
            //Trình độ lí luận chính trị
            MruEditMaTDLLCT.EditValue = nv.MaTDLLCT;
            MruEditTenTDLLCT.EditValue = BHXH.List.Business.ListTDLLCT.GetData(MruEditMaTDLLCT.Text).TenTDLLCT;
            //Ngoại ngữ
            MruEditMaNgoaiNgu.EditValue = nv.MaNgoaiNgu;
            MruEditTenNgoaiNgu.EditValue = BHXH.List.Business.ListNgoaiNgu.GetData(MruEditMaNgoaiNgu.Text).TenNgoaiNgu;

            //Trình độ ngoại ngữ
            MruEditMaTDNgoaiNgu.EditValue = nv.MaTDNgoaiNgu;
            MruEditTenTDNgoaiNgu.EditValue = BHXH.List.Business.ListTDNgoaiNgu.GetData(MruEditMaTDNgoaiNgu.Text).TenTDNgoaiNgu;
            ////
            MruEditCVDangLam.EditValue = nv.CVDangLam;
            MruEditMaNgach.EditValue = nv.MaNgach;
            MruEditBac.EditValue = nv.Bac;
            MruEditHSL.EditValue = nv.HSL;
            //tên ngạch
            MruEditTenNgach.EditValue = BHXH.HR.Business.HrThangBangLuong.GetTenNgach(MruEditMaNgach.Text).TenNgach;
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
            MruEditMaLoaiTB.EditValue = nv.MaLoaiTB;
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
            this.PictureEdit1.Image = BHXH.Util.Image.BinaryToImage(nv.AnhNV);


        }

        private void XtraTabPageQuaTrinhCongTac_Paint()
        {

        }

        private void NavBarControlDSNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void MruEditSoHieuNV_SelectedIndexChanged(object sender, EventArgs e)
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
