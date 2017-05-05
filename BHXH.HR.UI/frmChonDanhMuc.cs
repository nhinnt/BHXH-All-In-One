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
    
    
    public partial class frmChonDanhMuc : Form
    {
        DataView  ViewDanhMuc = new DataView();
        DataTable TableDanhMuc = new DataTable();
        private String MaTim, LocDau, FName_ID, FName_Ma, FName_Ten, HName_Ma, HName_Ten;

        private void ButtonChon_Click(object sender, EventArgs e)
        {

        }

        DataGridViewTextBoxColumn colID, colMa, colTen = new DataGridViewTextBoxColumn();
        public frmChonDanhMuc()
        {
            InitializeComponent();
        }

        private void frmChonDanhMuc_Load(object sender, EventArgs e)
        {
            
        }
         void InitGrid()
        {
            DataGridViewDanhMuc.Columns.Clear();
            DataGridViewDanhMuc.AllowUserToOrderColumns  = true ;
            DataGridViewDanhMuc.AllowUserToDeleteRows = false ;
            DataGridViewDanhMuc.AllowUserToAddRows = false ;
            DataGridViewDanhMuc.AutoGenerateColumns = false ;
            DataGridViewDanhMuc.MultiSelect = false ;
            DataGridViewDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colID.Name = "ID";
            colID.ReadOnly = true;
            colID.DataPropertyName = FName_ID;
            colID.Visible = false;
            colMa.Width = 100;
            colMa.Name = "Ma";
            colMa.ReadOnly = true;
            colMa.DataPropertyName = FName_Ma;
            colTen.Width = 300;
            colTen.Name = "Ten";
            colTen.ReadOnly = true;
            colTen.DataPropertyName = FName_Ten;
            DataGridViewDanhMuc.Columns.Add(colID);
            DataGridViewDanhMuc.Columns.Add(colMa);
            DataGridViewDanhMuc.Columns.Add(colTen);
            colMa.HeaderText = HName_Ma;
            colTen.HeaderText = HName_Ten;
        }
        
        void LocSoLieu()
        {
            MaTim = TextBoxMa.Text.Trim() ;
            int DoRong  = MaTim.Length;

            string DieuKien = LocDau;

            if (DieuKien != "")
            {
                if (DoRong != 0)
                 DieuKien = DieuKien + " And (SubString(" + FName_Ma + ",1," + DoRong + ")='" + MaTim + "')"; 

                if (TextBoxTen.Text.Trim() != "")
                    DieuKien = DieuKien + " And " + FName_Ten  + " Like '%" + TextBoxTen.Text.Trim() + "%'";
    

            }
            else
            {
                if (DoRong != 0) 
                    DieuKien = DieuKien + "(SubString(" + FName_Ma + ",1," + DoRong + ")='" + MaTim + "')";


                if (TextBoxTen.Text.Trim() != "")
                {
                    if (DieuKien == "")
                       DieuKien = FName_Ten + " Like '%" + TextBoxTen.Text.Trim() + "%'";
                    else
                        DieuKien = " AND " + FName_Ten + " Like '%" + TextBoxTen.Text.Trim()+ "%'";
                }
            
           }


            ViewDanhMuc.RowFilter = DieuKien;
            ViewDanhMuc.Sort = FName_Ma + " ASC";
        
        DataGridViewDanhMuc.DataSource = ViewDanhMuc;
        ButtonChon.Enabled = (ViewDanhMuc.Count != 0);
        }
    
    }
}
