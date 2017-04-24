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
            string IDChon = "";
            IDChon = e.Link.Item.Tag.ToString();
            //MessageBox.Show(IDChon);
            MruEditSoHieuNV.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).SoHieuNV;
            MruEditTenNhanVien.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).TenNhanVien;
            cboEditGioiTinh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).GioiTinh;
            MruEditTenKhac.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).TenKhac ;
            ////////Chức vụ Đảng
            MruEditMaChucVuDang.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaCapUy;
            MruEditTenChucVuDang.EditValue = BHXH.HR.Business.HrNhanVien.GetChucVuDang(MruEditMaChucVuDang.Text).TenChucVu;

          //  MruEditTenChucVuDang.EditValue = BHXH.List.Business.ListChucVuDang..GetChucVuDang(MruEditMaChucVuDang.Text).TenChucVu;


            ///////////////Chức vu Đảng kiêm
            MruEditMaCVDangKiem.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaCapUyKiem;
            MruEditTenCVDangKiem.EditValue = BHXH.List.Business.ListChucVuDang.GetData(MruEditMaCVDangKiem.Text).TenChucVu;

            ////////////CHức vụ
            MruEditMaChucVu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaChucVu;
            MruEditTenChucVu.EditValue = BHXH.List.Business.ListChucVu.GetData(MruEditMaChucVu.Text).TenChucVu;
            ////////////CHức danh
            MruEditMaChucDanh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaChucDanh;
            MruEditTenChucDanh.EditValue  = BHXH.List.Business.ListChucDanh.GetData(MruEditMaChucDanh.Text).TenChucDanh;
            ////
            CalcEditPCChucVu.EditValue  = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).PCChucVu;
            DateEditNgayBoNhiem.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayBoNhiem;
            DateEditNgaySinh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgaySinh;
            MruEditNoiSinh.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NoiSinh;
            //Quê quán
            MruEditMaTinhQQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaTinhQQ;
            MruEditMaQuanQQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).QuanHuyenIDQQ;
            MruEditMaPhuongQQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).XaPhuongIDQQ;
            string mTenPhuongQQ = "";
            string mTenQuanQQ = "";
            string mTenTinhQQ = "";
            mTenPhuongQQ = BHXH.HR.Business.HrNhanVien.GetTenPhuong(MruEditMaPhuongQQ.Text).TenXaPhuong;
            mTenQuanQQ = BHXH.HR.Business.HrNhanVien.GetTenQuan(MruEditMaQuanQQ.Text).TenQuanHuyen;
            mTenTinhQQ = BHXH.List.Business.ListTinh.GetTinh(MruEditMaTinhQQ.Text).TenTinh;
            TenQueQuan(mTenPhuongQQ, mTenQuanQQ, mTenTinhQQ);
            MruEditQueQuan.EditValue = mTenPhuongQQ + ", " + mTenQuanQQ +", " + mTenTinhQQ;
            ///Trú quán (nơi ở hiện nay)
            MruEditMaTinhTQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MatinhTQ;
            MruEditMaQuanTQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).QuanHuyenIDTQ;
            MruEditMaPhuongTQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).XaPhuongIDTQ;
            string mTenPhuongTQ = "";
            string mTenQuanTQ = "";
            string mTenTinhTQ = "";
            mTenPhuongTQ = BHXH.HR.Business.HrNhanVien.GetTenPhuong(MruEditMaPhuongTQ.Text).TenXaPhuong;
            mTenQuanTQ = BHXH.HR.Business.HrNhanVien.GetTenQuan(MruEditMaQuanTQ.Text).TenQuanHuyen;
            mTenTinhTQ = BHXH.List.Business.ListTinh.GetTinh(MruEditMaTinhTQ.Text).TenTinh;
            MruEditTruQuan.EditValue = mTenPhuongTQ + ", " + mTenQuanTQ + ", " + mTenTinhTQ;
            /////////////////////
            MruEditSoNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).SoNha;
            MruEditTruQuan.EditValue = mTenPhuongTQ + ", " + mTenQuanTQ + ", " + mTenTinhTQ;
            ///////////
            MruEditDTNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).DTNha;
            MruEditDTCoQuan.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).DTCoQuan;
            MruEditDTDiDong.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).DTDiDong;
            MruEditEmail.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).Email;
            MruEditDTNguoiNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).DTNguoiNha;
            MruEditTenNguoiNha.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).DTNguoiNha;
            /////Dân tộc
            MruEditMaDanToc.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaDanToc;
            MruEditTenDanToc.EditValue = BHXH.List.Business.ListDanToc.GetData(MruEditMaDanToc.Text).TenDanToc;
            /////Tôn giáo
            MruEditMaTonGiao.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaTonGiao;
            MruEditTenTonGiao.EditValue = BHXH.List.Business.ListTonGiao.GetTonGiao(MruEditMaTonGiao.Text).TenTonGiao;
            /////////
            DateEditNgay_TD.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayTD;
            DateEditNgay_CQ.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayCQ;
            DateEditNgay_CM.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayCM;
            DateEditNgay_Dang.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayDang;
            DateEditNgay_DangCT.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayDangCT;
            MruEditMaChiBo.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaChiBo;
            MruEditTenChiBo.EditValue = BHXH.HR.Business.HrNhanVien.GetTenChiBo(MruEditMaChiBo.Text).TenChiBo;
            DateEditNgay_TCXH.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayTCXH;
            DateEditNgayNhapNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayNhapNgu;
            DateEditNgayXuatNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NgayXuatNgu;
            MruEditQuanHam.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).QuanHam;
            //Trình độ văn hóa
            MruEditMaTDVanHoa.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaTDVanHoa;
            MruEditTenTDVanHoa.EditValue = BHXH.List.Business.ListTDVanHoa.GetTDVanHoa(MruEditMaTDVanHoa.Text).TenTDVanHoa;
            ///Trình độ đào tạo
            MruEditMaTDDaoTao.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaTDDaoTao;
            MruEditTenTDDaoTao.EditValue = BHXH.HR.Business.HrNhanVien.GetTenTDDT(MruEditMaTDDaoTao.Text).TenTDDaoTao;
            //Trình độ lí luận chính trị
            MruEditMaTDLLCT.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaTDLLCT;
            MruEditTenTDLLCT.EditValue = BHXH.List.Business.ListTDLLCT.GetData(MruEditMaTDLLCT.Text).TenTDLLCT;
            //Ngoại ngữ
            MruEditMaNgoaiNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaNgoaiNgu;
            MruEditTenNgoaiNgu.EditValue = BHXH.List.Business.ListNgoaiNgu.GetData(MruEditMaNgoaiNgu.Text).TenNgoaiNgu;

            //Trình độ ngoại ngữ
            MruEditMaTDNgoaiNgu.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaTDNgoaiNgu;
            MruEditTenTDNgoaiNgu.EditValue = BHXH.List.Business.ListTDNgoaiNgu.GetData(MruEditMaTDNgoaiNgu.Text).TenTDNgoaiNgu;
            ////
            MruEditCVDangLam.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).CVDangLam;
            MruEditMaNgach.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaNgach;
            MruEditBac.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).Bac;
            MruEditHSL.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).HSL;
            //tên ngạch
            MruEditTenNgach.EditValue = BHXH.HR.Business.HrNhanVien.GetTenNgach(MruEditMaNgach.Text).TenNgach;
            MruEditDHDuocPhong.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).DHDuocPhong;
            MruEditSoTruongCT.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).SoTruongCT;
            MruEditCVLamLN.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).CVLamLN;
            MruEditKhenThuong.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).KhenThuong;
            MruEditKyLuat.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).KyLuat;
            MruEditSucKhoe.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).SucKhoe;
            MruEditChieuCao.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).ChieuCao;
            MruEditCanNang.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).CanNang;
            cboEditNhomMau.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).NhomMau;
            MruEditSoCMND.EditValue = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).SoCMND;
            CheckEditGDLietSy.EditValue  = BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).GDLietSy;
            //thương binh
            MruEditMaLoaiTB.EditValue= BHXH.HR.Business.HrNhanVien.GetNhanVien(IDChon).MaLoaiTB;
            if (!string.IsNullOrEmpty(MruEditMaLoaiTB.Text))
            {
                MruEditTenLoaiTB.EditValue = BHXH.List.Business.ListLoaiTB.GetData(MruEditMaLoaiTB.Text).TenLoaiTB;
            }
            ////Hình ảnh
            //BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            //var bytes = from p in ctx.HrNhanVien
            //            where p.MaNhanVien.ToString() == IDChon // Id of product that i want 
            //            select p.AnhNV;
            //byte[] trueBytes = bytes.ToArray();
            //if (trueBytes != null)
            //{
            //    using (var ms = new MemoryStream(trueBytes))
            //    {
            //        using (var image = Image.FromStream(ms))
            //        {
            //            PictureEdit1.Image = (Image)image.Clone();
            //        }
            //    }
            //}
            //try
            //{
            //    byte[] img = RetrieveImage(IDChon);
            //    MemoryStream str = new MemoryStream(img);

            //    this.PictureEdit1.Image = Image.FromStream(str);

            //}
            //catch (Exception ex)
            //{
            //    this.PictureEdit1.Image = null;
            //}


        }
        //public byte[] RetrieveImage(string IDChon)
        //{
        //    byte[] imageData = null;
        //    SqlCommand cmd = new SqlCommand(" select AnhNV from dsnhanvien where idnhanvien = " + mIDChon.ToString, SoLieu);
        //    imageData = BHXH.HR.Business.HrNhanVien.GetAnhNV(IDChon).AnhNV;
        //    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
        //    {
        //        reader.Read();
        //        long bytesize = imageData.GetBytes(0, 0, null, 0, 0);
        //        Allocate byte array to hold image data
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
