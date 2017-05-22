using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHXH.HR.UI
{
    public partial class frmSearchOnRequest : Form
    {
     
        public frmSearchOnRequest()
        {
            InitializeComponent();
        }

        private void frmSearchOnRequest_Load(object sender, EventArgs e)
        {
            
            this.lookUpEditPhongBan.Properties.DataSource = BHXH.List.Business.ListPhongBan.GetAll();
            this.lookUpEditPhongBan.Properties.DisplayMember = "TenPhongBan";
            this.lookUpEditPhongBan.Properties.ValueMember = "MaPhongBan";

            this.lookUpEditBangCap.Properties.DataSource = BHXH.List.Business.ListBangCap.GetAll();
            this.lookUpEditBangCap.Properties.DisplayMember = "TenBangCap";
            this.lookUpEditBangCap.Properties.ValueMember = "MaBangCap";

            this.lookUpEditCMDaoTao.Properties.DataSource = BHXH.List.Business.ListCMDaoTao.GetAll();
            this.lookUpEditCMDaoTao.Properties.DisplayMember = "TenCMDaoTao";
            this.lookUpEditCMDaoTao.Properties.ValueMember = "MaCMDaoTao";

            this.lookUpEditLoaiHinhDaoTao.Properties.DataSource = BHXH.List.Business.ListLHDaoTao.GetAll();
            this.lookUpEditLoaiHinhDaoTao.Properties.DisplayMember = "TenLHDaoTao";
            this.lookUpEditLoaiHinhDaoTao.Properties.ValueMember = "MaLHDaoTao";
        }

        private void lookUpEditBangCap_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lookUpEditPhongBan_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lookUpEditCMDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SimpleButtonSua_Click(object sender, EventArgs e)
        {
            string DieuKien = "";
            string DKMaPhongBan = "";
            string DKCMDaoTao = "";
            string DKMaBangCap = "";
            string DKLHDaoTao = "";
            this.GridControlDanhSach.DataSource = BHXH.HR.Business.HrNhanVien.GetNhanVienSearchOnRequest ();
            if (lookUpEditPhongBan.EditValue.ToString() != "")
                DKMaPhongBan = "(MaPhongBan='" + lookUpEditPhongBan.EditValue.ToString() + "')";
            else
                DKMaPhongBan = "(MaPhongBan like'%')";
            
            if (lookUpEditCMDaoTao.EditValue.ToString() != "")
                DKCMDaoTao = "(MaCMDaoTao='" + lookUpEditCMDaoTao.EditValue.ToString() + "')";
            else
                DKCMDaoTao = "(MaCMDaoTao like '%')";
            if(lookUpEditBangCap.EditValue.ToString()!="")
                DKMaBangCap = "(MaBangCap='" + lookUpEditBangCap.EditValue.ToString() + "')";
            else
                DKMaBangCap = "(MaBangCap like '%')";
            if (lookUpEditLoaiHinhDaoTao.EditValue.ToString()!="")
                DKLHDaoTao = "MaLHDaoTao='" + lookUpEditLoaiHinhDaoTao.EditValue.ToString() + "'";
            else
                DKLHDaoTao = "MaLHDaoTao like '%'";
            DieuKien = DKMaPhongBan + " and " + DKCMDaoTao + " and " + DKMaBangCap + " And " + DKLHDaoTao ;
            GridViewDanhSach.ActiveFilterString = DieuKien  ;
        }

        private void lookUpEditLoaiHinhDaoTao_EditValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
