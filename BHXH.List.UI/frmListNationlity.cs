using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BHXH.List.UI
{
    public partial class frmListNationlity : DevExpress.XtraEditors.XtraForm
    {
        public frmListNationlity()
        {
            InitializeComponent();
        }

        private void frmListNationlity_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tsst");
           
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = BHXH.List.Business.ListNationality.GetAll().ToList();
            
            MessageBox.Show("Tsst2");

        }
    }
}