namespace BHXH.HR.UI
{
    partial class frmChonDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonChon = new System.Windows.Forms.Button();
            this.DataGridViewDanhMuc = new System.Windows.Forms.DataGridView();
            this.TextBoxTen = new System.Windows.Forms.TextBox();
            this.TextBoxMa = new System.Windows.Forms.TextBox();
            this.labTen = new System.Windows.Forms.Label();
            this.labMa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Maroon;
            this.Label1.Location = new System.Drawing.Point(32, 361);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(230, 13);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Nhấn Enter hoặc Kích đúp chuột để chọn";
            // 
            // ButtonChon
            // 
            this.ButtonChon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonChon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChon.Location = new System.Drawing.Point(490, 356);
            this.ButtonChon.Name = "ButtonChon";
            this.ButtonChon.Size = new System.Drawing.Size(75, 23);
            this.ButtonChon.TabIndex = 27;
            this.ButtonChon.Text = "&Chọn";
            this.ButtonChon.UseVisualStyleBackColor = true;
            this.ButtonChon.Click += new System.EventHandler(this.ButtonChon_Click);
            // 
            // DataGridViewDanhMuc
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDanhMuc.Location = new System.Drawing.Point(35, 41);
            this.DataGridViewDanhMuc.Name = "DataGridViewDanhMuc";
            this.DataGridViewDanhMuc.Size = new System.Drawing.Size(532, 302);
            this.DataGridViewDanhMuc.TabIndex = 25;
            // 
            // TextBoxTen
            // 
            this.TextBoxTen.Location = new System.Drawing.Point(275, 14);
            this.TextBoxTen.MaxLength = 100;
            this.TextBoxTen.Name = "TextBoxTen";
            this.TextBoxTen.Size = new System.Drawing.Size(291, 20);
            this.TextBoxTen.TabIndex = 24;
            // 
            // TextBoxMa
            // 
            this.TextBoxMa.Location = new System.Drawing.Point(113, 14);
            this.TextBoxMa.MaxLength = 10;
            this.TextBoxMa.Name = "TextBoxMa";
            this.TextBoxMa.Size = new System.Drawing.Size(74, 20);
            this.TextBoxMa.TabIndex = 23;
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(191, 17);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(50, 13);
            this.labTen.TabIndex = 21;
            this.labTen.Text = "Nội dung";
            // 
            // labMa
            // 
            this.labMa.AutoSize = true;
            this.labMa.Location = new System.Drawing.Point(47, 17);
            this.labMa.Name = "labMa";
            this.labMa.Size = new System.Drawing.Size(22, 13);
            this.labMa.TabIndex = 22;
            this.labMa.Text = "Mã";
            // 
            // frmChonDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 393);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonChon);
            this.Controls.Add(this.DataGridViewDanhMuc);
            this.Controls.Add(this.TextBoxTen);
            this.Controls.Add(this.TextBoxMa);
            this.Controls.Add(this.labTen);
            this.Controls.Add(this.labMa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChonDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.frmChonDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ButtonChon;
        internal System.Windows.Forms.DataGridView DataGridViewDanhMuc;
        internal System.Windows.Forms.TextBox TextBoxTen;
        internal System.Windows.Forms.TextBox TextBoxMa;
        internal System.Windows.Forms.Label labTen;
        internal System.Windows.Forms.Label labMa;
    }
}