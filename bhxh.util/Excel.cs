using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace BHXH.Util
{
    class Excel
    {

        /// <summary>
        /// Using OleDB to select data from Excel file
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="Header"></param>
        /// <returns></returns>
        public static  DataTable OpenFile(string FilePath, bool Header)
        {
            DataTable dt = new DataTable();
            if (FilePath != "")
            {

                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties='Excel 8.0;";
                if (Header)
                    strConn += "HDR=YES'";
                OleDbConnection conn = new OleDbConnection(strConn);

                OleDbCommand OleCmd = new OleDbCommand();
                OleCmd.Connection = conn;
                OleCmd.CommandText = "SELECT * FROM [Sheet1$] ";
                OleDbDataAdapter da = new OleDbDataAdapter(OleCmd);

                da.Fill(dt);

            }
            return dt;
        }

        /// <summary>
        /// Using OleDB to select data from Excel file
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="Header"></param>
        /// <param name="SheetName"></param>
        /// <returns></returns>
        public static DataTable OpenFile(string FilePath, bool Header, string SheetName)
        {
            DataTable dt = new DataTable();
            if (FilePath != "")
            {

                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";Extended Properties='Excel 8.0;";
                if (Header)
                    strConn += "HDR=YES'";
                OleDbConnection conn = new OleDbConnection(strConn);

                OleDbCommand OleCmd = new OleDbCommand();
                OleCmd.Connection = conn;
                OleCmd.CommandText = "SELECT * FROM [" + SheetName + "$] ";
                OleDbDataAdapter da = new OleDbDataAdapter(OleCmd);

                da.Fill(dt);

            }
            return dt;
        }

        public static string GetFilePath()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel File|*.xls";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;

            }
            return "";

        }
    }
}

