using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BHXH.App
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtnTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListTinh f = new BHXH.List.UI.frmListTinh();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void bbtnQuocTich_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListQuocGia f = new BHXH.List.UI.frmListQuocGia();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtDienCS_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListDienCS f = new BHXH.List.UI.frmListDienCS();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtQHGD_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListQuanHeGD f = new BHXH.List.UI.frmListQuanHeGD();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtnQuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListQuanHuyen f = new BHXH.List.UI.frmListQuanHuyen();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtnXa_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListXaPhuong f = new BHXH.List.UI.frmListXaPhuong();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }


        private void bbtnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListDanToc f = new BHXH.List.UI.frmListDanToc();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListTonGiao f = new BHXH.List.UI.frmListTonGiao();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtNghiepVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListNghiepVu f = new BHXH.List.UI.frmListNghiepVu();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtLoaiHinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListLHDaoTao f = new BHXH.List.UI.frmListLHDaoTao();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtBangCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListBangCap f = new BHXH.List.UI.frmListBangCap();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void bbtNgoaiNgu_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListNgoaiNgu f = new List.UI.frmListNgoaiNgu();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtChuyenMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListCMDaoTao f = new List.UI.frmListCMDaoTao();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void bbtTDVanHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListTDVanHoa f = new List.UI.frmListTDVanHoa();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtTDDaoTao_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListTDDaoTao f = new List.UI.frmListTDDaoTao();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtTDNgoaiNgu_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListTDNgoaiNgu f = new List.UI.frmListTDNgoaiNgu();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtLLCT_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListTDLLCT f = new List.UI.frmListTDLLCT();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtQLNN_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListTDQLNN f = new List.UI.frmListTDQLNN();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtDonVi_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListPhongBan f = new List.UI.frmListPhongBan();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void bbtChiBo_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListChiBo f = new List.UI.frmListChiBo();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtLoaiTB_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListLoaiTB f = new List.UI.frmListLoaiTB();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtTPGD_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListThanhPhanGD f = new List.UI.frmListThanhPhanGD();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtTTHN_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListHonNhan f = new List.UI.frmListHonNhan();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void bbtnTBLuong_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bbtNangNhoc_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bbtNoiKCB_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListNoiKCB f = new BHXH.List.UI.frmListNoiKCB();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtKTKL_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtCapKTKL_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListCapKTKL f = new BHXH.List.UI.frmListCapKTKL();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void bbtHTKTKL_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbtHDLDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListHopDong f = new BHXH.List.UI.frmListHopDong();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void bbtNganHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListNganHang f = new BHXH.List.UI.frmListNganHang();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void btnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListChucVu f = new BHXH.List.UI.frmListChucVu();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void bbtChucvuDang_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListChucVuDang f = new BHXH.List.UI.frmListChucVuDang();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();
        }

        private void bbtChucDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            List.UI.frmListChucDanh f = new BHXH.List.UI.frmListChucDanh();
            //f.StartPosition =  FormStartPosition.CenterParent;
            f.MdiParent = this;
            f.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
            //Login();
            //DoSecurity();
        }
        void Login()
        {
            BHXH.Sys.UI.frmLogin f = new BHXH.Sys.UI.frmLogin();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            if (BHXH.Sys.Business.Sys.LoginedUser != null)
                DoSecurity();
            else Application.Exit();
        }
        /// <summary>
        /// Load menu theo phân quyền
        /// </summary>
        void DoSecurity()
        {


        }

        private void ListNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            HR.UI.frmDanhSachNhanVien  f = new HR.UI.frmDanhSachNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void HoSoCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            HR.UI.frmHrNhanVien f = new HR.UI.frmHrNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void TrinhDoChuyenMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            HR.UI.frmSearchOnRequest  f = new HR.UI.frmSearchOnRequest();
            f.MdiParent = this;
            f.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}