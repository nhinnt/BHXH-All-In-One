using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BHXH.HR.UI
{
    public partial class frmInLyLich2C : Form
    {
        public frmInLyLich2C()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable MyDataTableNhanVien = ds.Tables.Add("HrNhanVien");
            DataTable MyDataTableCTDaoTao= ds.Tables.Add("HrChiTietDaoTao");
            DataTable MyDataTableQTCongTac = ds.Tables.Add("HrQuaTrinhCongTac");
            DataTable MyDataTableQHGD = ds.Tables.Add("HrQuanHeGiaDinh");
            // DataTable MyDataTable = new DataTable();
            //DataTable MyDataTableNhanVien = new DataTable();
            //////////////////////////////////////////////////
            MyDataTableNhanVien.Columns.Add("TenNhanVien", typeof(string));
            MyDataTableNhanVien.Columns.Add("SoHieu", typeof(string));
            MyDataTableNhanVien.Columns.Add("GioiTinh", typeof(string));
            MyDataTableNhanVien.Columns.Add("TenKhac", typeof(string));
            MyDataTableNhanVien.Columns.Add("TenChucVuDang", typeof(string));
            MyDataTableNhanVien.Columns.Add("TenChucVuDangKiem", typeof(string));
            MyDataTableNhanVien.Columns.Add("TenChucVu", typeof(string));
            MyDataTableNhanVien.Columns.Add("PCCV", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgaySinh", typeof(string));
            MyDataTableNhanVien.Columns.Add("NoiSinh", typeof(string));
            MyDataTableNhanVien.Columns.Add("QueQuan", typeof(string));
            MyDataTableNhanVien.Columns.Add("TruQuan", typeof(string));
            MyDataTableNhanVien.Columns.Add("DTNha", typeof(string));
            MyDataTableNhanVien.Columns.Add("DTDiDong", typeof(string));
            MyDataTableNhanVien.Columns.Add("DanToc", typeof(string));
            MyDataTableNhanVien.Columns.Add("TonGiao", typeof(string));
            MyDataTableNhanVien.Columns.Add("ThanhPhanGD", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgheTruocTD", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayTD", typeof(string));
            MyDataTableNhanVien.Columns.Add("CoQuanTD", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayCQ", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayCM", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayDang", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayDangCT", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayTCXH", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayNhapNgu", typeof(string));
            MyDataTableNhanVien.Columns.Add("NgayXuatNgu", typeof(string));
            MyDataTableNhanVien.Columns.Add("QuanHam", typeof(string));
            MyDataTableNhanVien.Columns.Add("TrinhDoVanHoa", typeof(string));
            MyDataTableNhanVien.Columns.Add("TrinhDoDaoTao", typeof(string));
            MyDataTableNhanVien.Columns.Add("TrinhDoLLCT", typeof(string));
            MyDataTableNhanVien.Columns.Add("TrinhDoNgoaiNgu", typeof(string));
            MyDataTableNhanVien.Columns.Add("CVDangLam", typeof(string));
            MyDataTableNhanVien.Columns.Add("Ngach", typeof(string));
            MyDataTableNhanVien.Columns.Add("BacLuong", typeof(string));
            MyDataTableNhanVien.Columns.Add("HSL", typeof(double));
            MyDataTableNhanVien.Columns.Add("DHDuocPhong", typeof(string));
            MyDataTableNhanVien.Columns.Add("SoTruongCT", typeof(string));
            MyDataTableNhanVien.Columns.Add("CVLamLN", typeof(string));
            MyDataTableNhanVien.Columns.Add("KhenThuong", typeof(string));
            MyDataTableNhanVien.Columns.Add("KyLuat", typeof(string));
            MyDataTableNhanVien.Columns.Add("SucKhoe", typeof(string));
            MyDataTableNhanVien.Columns.Add("ChieuCao", typeof(string));
            MyDataTableNhanVien.Columns.Add("CanNang", typeof(string));
            MyDataTableNhanVien.Columns.Add("NhomMau", typeof(string));
            MyDataTableNhanVien.Columns.Add("SoCMND", typeof(string));
            MyDataTableNhanVien.Columns.Add("TenLoaiTB", typeof(string));
            MyDataTableNhanVien.Columns.Add("GDLietSy", typeof(string));
            MyDataTableNhanVien.Columns.Add("TuDay", typeof(string));
            MyDataTableNhanVien.Columns.Add("CheDoCu", typeof(string));
            MyDataTableNhanVien.Columns.Add("TCNuocNgoai", typeof(string));
            MyDataTableNhanVien.Columns.Add("TNNuocNgoai", typeof(string));
            /////quá trình đào tạo
            MyDataTableCTDaoTao.Columns.Add("TenTruong", typeof(string));
            MyDataTableCTDaoTao.Columns.Add("NganhHoc", typeof(string));
            MyDataTableCTDaoTao.Columns.Add("ThoiGian", typeof(string));
            MyDataTableCTDaoTao.Columns.Add("TenLHDaoTao", typeof(string));
            MyDataTableCTDaoTao.Columns.Add("TenBangCap", typeof(string));
            /////quá trình công tác
            MyDataTableQTCongTac.Columns.Add("ThoiGianCongTac", typeof(string));
            MyDataTableQTCongTac.Columns.Add("CongViec", typeof(string));
            /////quan hệ gia đình
            MyDataTableQHGD.Columns.Add("TenQuanHeGD", typeof(string));
            MyDataTableQHGD.Columns.Add("HoTen", typeof(string));
            MyDataTableQHGD.Columns.Add("NamSinh", typeof(string));
            MyDataTableQHGD.Columns.Add("ChiTiet", typeof(string));
            ////////////////Nguồn
            BHXH.HR.UI.Report.CrystalReportLyLich2C cr1 = new BHXH.HR.UI.Report.CrystalReportLyLich2C();
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var resultHrNhanVien= (from a in ctx.HrNhanVien
                          join cvdang in ctx.ListChucVuDang on a.MaCapUy equals cvdang.MaChucVu
                          join cvdangkiem in ctx.ListChucVuDang on a.MaCapUyKiem equals cvdangkiem.MaChucVu
                          join cv in ctx.ListChucVu on a.MaChucVu equals cv.MaChucVu
                          join PhuongQQ in ctx.ListXaPhuong on a.XaPhuongIDQQ equals PhuongQQ.XaPhuongID
                          join HuyenQQ in ctx.ListQuanHuyen on a.QuanHuyenIDQQ equals HuyenQQ.QuanHuyenID
                          join TinhQQ in ctx.ListTinh on a.MaTinhQQ equals TinhQQ.MaTinh
                          join PhuongTQ in ctx.ListXaPhuong on a.XaPhuongIDTQ equals PhuongTQ.XaPhuongID
                          join HuyenTQ in ctx.ListQuanHuyen on a.QuanHuyenIDTQ equals HuyenTQ.QuanHuyenID
                          join TinhTQ in ctx.ListTinh on a.MatinhTQ equals TinhTQ.MaTinh
                          join dt in ctx.ListDanToc on a.MaDanToc equals dt.MaDanToc
                          join tg in ctx.ListTonGiao on a.MaTonGiao equals tg.MaTonGiao
                          join tpgd in ctx.ListThanhPhanGD on a.MaThanhPhanGD equals tpgd.MaThanhPhanGD
                          join tdvh in ctx.ListTDVanHoa on a.MaTDVanHoa equals tdvh.MaTDVanHoa
                          join tddt in ctx.ListTDDaoTao on a.MaTDDaoTao equals tddt.MaTDDaoTao
                          join tdllct in ctx.ListTDLLCT on a.MaTDLLCT equals tdllct.MaTDLLCT
                          join tdnn in ctx.ListTDNgoaiNgu on a.MaTDNgoaiNgu equals tdnn.MaTDNgoaiNgu
                          join ngach in ctx.HrThangBangLuong on a.MaNgach equals ngach.MaNgach
                          join tb in ctx.ListLoaiTB on a.MaLoaiTB equals tb.MaLoaiTB 
                          where a.MaNhanVien.ToString() == BHXH.HR.UI.frmHrNhanVien.bientoancuc.MaNhanVien.ToString()
                          select new
                          {
                              a.TenNhanVien, a.SoHieuNV, a.GioiTinh, a.TenKhac, TenChucVuDang = cvdang.TenChucVu, TenChucVuDangKiem = cvdangkiem.TenChucVu,
                              TenChucVu = cv.TenChucVu, a.PCChucVu,
                              NgaySinh = a.NgaySinh,
                              //NgaySinh = a.NgaySinh,//.Substring(0,2) + " tháng " + a.NgaySinh.ToString().Substring(3, 2) +" năm " + a.NgaySinh.ToString().Substring(6,4),
                              NoiSinh = a.NoiSinh, Quequan = PhuongQQ.TenXaPhuong + ", " + HuyenQQ.TenQuanHuyen + ", " + TinhQQ.TenTinh,
                              TruQuan = PhuongTQ.TenXaPhuong + ", " + HuyenTQ.TenQuanHuyen + ", " + TinhTQ.TenTinh,
                              a.DTNha, a.DTDiDong, dt.TenDanToc, tg.TenTonGiao, tpgd.TenThanhPhanGD, a.NgheTruocTD, a.NgayTD, a.CoQuanTD, a.NgayCQ,
                              a.NgayCM, a.NgayDang, a.NgayDangCT, a.NgayTCXH, a.NgayNhapNgu, a.NgayXuatNgu, a.QuanHam, a.MaTDVanHoa,
                              tdvh.TenTDVanHoa, tddt.TenTDDaoTao, tdllct.TenTDLLCT, tdnn.TenTDNgoaiNgu, a.CVDangLam, NgachCC = a.MaNgach + "-" + ngach.TenNgach,
                              a.Bac, a.HSL, a.DHDuocPhong , a.SoTruongCT ,a.CVLamLN , a.KhenThuong, a.KyLuat,
                              a.SucKhoe, a.ChieuCao, a.CanNang, a.NhomMau, a.SoCMND,  tb.TenLoaiTB, a.GDLietSy, a.TuDay ,a.CheDoCu ,a.TCNuocNgoai ,a.TNNuocNgoai,
                          }
                        ).ToList();
           ///////////////////////////truyền dữ liệu ///////////////////////////
            foreach (var item_loopVariable in resultHrNhanVien)
            {

                dynamic row = MyDataTableNhanVien.NewRow();
                row["TenNhanVien"] = item_loopVariable.TenNhanVien.ToUpper();
                row["SoHieu"] = item_loopVariable.SoHieuNV ;
                row["GioiTinh"] = item_loopVariable.GioiTinh;
                row["TenKhac"] = item_loopVariable.TenKhac;
                row["TenChucVuDang"] = item_loopVariable.TenChucVuDang;
                row["TenChucVuDangKiem"] = item_loopVariable.TenChucVuDangKiem;
                row["TenChucVu"] = item_loopVariable.TenChucVu;
                if (item_loopVariable.PCChucVu != null)
                    row["PCCV"] = Convert.ToDecimal(item_loopVariable.PCChucVu);
                row["NgaySinh"] = Convert.ToDateTime(item_loopVariable.NgaySinh).Day + " tháng " + Convert.ToDateTime(item_loopVariable.NgaySinh).Month + " năm " + Convert.ToDateTime(item_loopVariable.NgaySinh).Year;
                row["NoiSinh"] = item_loopVariable.NoiSinh;
                row["QueQuan"] = item_loopVariable.Quequan;
                row["TruQuan"] = item_loopVariable.TruQuan;
                row["DTNha"] = item_loopVariable.DTNha;
                row["DTDiDong"] = item_loopVariable.DTDiDong;
                row["DanToc"] = item_loopVariable.TenDanToc;
                row["TonGiao"] = item_loopVariable.TenTonGiao;
                row["ThanhPhanGD"] = item_loopVariable.TenThanhPhanGD;
                row["NgheTruocTD"] = item_loopVariable.NgheTruocTD;
                row["NgayTD"] = Convert.ToDateTime(item_loopVariable.NgayTD).ToShortDateString();
                row["CoQuanTD"] = item_loopVariable.CoQuanTD;
                row["NgayCQ"] = Convert.ToDateTime(item_loopVariable.NgayCQ).ToShortDateString();

                if (item_loopVariable.NgayCM != null)
                    row["NgayCM"] = Convert.ToDateTime(item_loopVariable.NgayCM).ToShortDateString();
                if (item_loopVariable.NgayDang != null)
                    row["NgayDang"] = Convert.ToDateTime(item_loopVariable.NgayDang).ToShortDateString();
                if (item_loopVariable.NgayDangCT != null)
                    row["NgayDangCT"] = Convert.ToDateTime(item_loopVariable.NgayDangCT).ToShortDateString();
                if (item_loopVariable.NgayTCXH != null)
                    row["NgayTCXH"] = Convert.ToDateTime(item_loopVariable.NgayTCXH).ToShortDateString();
                if (item_loopVariable.NgayNhapNgu != null)
                    row["NgayNhapNgu"] = Convert.ToDateTime(item_loopVariable.NgayNhapNgu).ToShortDateString();
                if (item_loopVariable.NgayXuatNgu != null)
                    row["NgayXuatNgu"] = Convert.ToDateTime(item_loopVariable.NgayXuatNgu).ToShortDateString();
                row["QuanHam"] = item_loopVariable.QuanHam;
                row["TrinhDoVanHoa"] = item_loopVariable.TenTDVanHoa;
                row["TrinhDoDaoTao"] = item_loopVariable.TenTDDaoTao;
                row["TrinhDoLLCT"] = item_loopVariable.TenTDLLCT;
                row["TrinhDoNgoaiNgu"] = item_loopVariable.TenTDNgoaiNgu;
                row["CVDangLam"] = item_loopVariable.CVDangLam;
                row["Ngach"] = item_loopVariable.NgachCC;
                row["BacLuong"] = item_loopVariable.Bac;
                row["HSL"] = Convert.ToDecimal(item_loopVariable.HSL);
                row["DHDuocPhong"] = item_loopVariable.DHDuocPhong;
                row["SoTruongCT"] = item_loopVariable.SoTruongCT ;
                row["CVLamLN"] = item_loopVariable.CVLamLN ;
                row["KhenThuong"] = item_loopVariable.KhenThuong ;
                row["KyLuat"] = item_loopVariable.KyLuat;
                row["SucKhoe"] = item_loopVariable.SucKhoe ;
                row["ChieuCao"] = item_loopVariable.ChieuCao ;
                row["CanNang"] = item_loopVariable.CanNang ;
                row["NhomMau"] = item_loopVariable.NhomMau ;
                row["SoCMND"] = item_loopVariable.SoCMND ;
                row["TenLoaiTB"] = item_loopVariable.TenLoaiTB;
                row["GDLietSy"] = Convert.ToBoolean(item_loopVariable.GDLietSy);
                row["TuDay"] = item_loopVariable.TuDay ;
                row["CheDoCu"] = item_loopVariable.CheDoCu;
                row["TCNuocNgoai"] = item_loopVariable.TCNuocNgoai;
                row["TNNuocNgoai"] = item_loopVariable.TNNuocNgoai ;
                MyDataTableNhanVien.Rows.Add(row);
            }
            ////////////////////Nguồn chi tiết đào tạo////////////////////////////////////////////////////
            var resultChiTietDaoTao = (from a in ctx.HrNhanVien
                                       join b in ctx.HrChiTietDaoTao on a.MaNhanVien equals b.MaNhanVien
                                       join lh in ctx.ListLHDaoTao on b.MaLHDaoTao equals lh.MaLHDaoTao
                                       join bc in ctx.ListBangCap on b.MaBangCap equals bc.MaBangCap
                                       where a.MaNhanVien.ToString() == BHXH.HR.UI.frmHrNhanVien.bientoancuc.MaNhanVien.ToString()
                                       orderby b.STT 
                                    select new
                                    {
                                        b.TenTruong,
                                        b.NganhHoc,
                                        b.ThoiGian,
                                        TenLHDaoTao = lh.TenLHDaoTao,
                                        TenBangCap = bc.TenBangCap,
                                    }
                        ).ToList();
            //////////////////////////////////////////////////////
            foreach (var item_loopVariable in resultChiTietDaoTao)
            {
                dynamic row = MyDataTableCTDaoTao.NewRow();
                row["TenTruong"] = item_loopVariable.TenTruong;
                row["NganhHoc"] = item_loopVariable.NganhHoc;
                row["ThoiGian"] = item_loopVariable.ThoiGian;
                row["TenLHDaoTao"] = item_loopVariable.TenLHDaoTao;
                row["TenBangCap"] = item_loopVariable.TenBangCap;
                MyDataTableCTDaoTao.Rows.Add(row);
            }
            ///////////////////////////nguồn quá trình công tác/////////////////////////////////////
            var resultQTCT = (from a in ctx.HrNhanVien
                              join b in ctx.HrQuaTrinhCongTac on a.MaNhanVien equals b.MaNhanVien
                              where b.MaNhanVien.ToString() == BHXH.HR.UI.frmHrNhanVien.bientoancuc.MaNhanVien.ToString()
                              orderby b.STT 
                              select new
                              {
                                  ThoiGianCongTac = b.ThoiGian,
                                  b.CongViec
                              }
                            ).ToList();

            foreach (var item_loopVariable in resultQTCT)
            {

                dynamic row = MyDataTableQTCongTac.NewRow();
                row["ThoiGianCongTac"] = item_loopVariable.ThoiGianCongTac;
                row["CongViec"] = item_loopVariable.CongViec;

                MyDataTableQTCongTac.Rows.Add(row);
            }
            ///////////////////////////nguồn quan hệ gia đình/////////////////////////////////////
            var resultQHGD = (from a in ctx.HrNhanVien
                              join b in ctx.HrQuanHeGiaDinh  on a.MaNhanVien equals b.MaNhanVien
                              join c in ctx.ListQuanHeGD on b.MaQuanHeGD equals c.MaQuanHeGD 
                              where b.MaNhanVien.ToString() == BHXH.HR.UI.frmHrNhanVien.bientoancuc.MaNhanVien.ToString()
                              orderby b.STT 
                              select new
                              {
                                  c.TenQuanHeGD , b.HoTen, b.NamSinh , b.ChiTiet ,
                                   
                              }
                            ).ToList();

            foreach (var item_loopVariable in resultQHGD)
            {

                dynamic row = MyDataTableQHGD.NewRow();
                row["TenQuanHeGD"] = item_loopVariable.TenQuanHeGD;
                row["HoTen"] = item_loopVariable.HoTen;
                row["NamSinh"] = item_loopVariable.NamSinh;
                row["ChiTiet"] = item_loopVariable.ChiTiet;

                MyDataTableQHGD.Rows.Add(row);
            }
            //////////////////////////////////////////////////////////////////////////////
            CrystalDecisions.CrystalReports.Engine.ReportDocument rptDoc = default(CrystalDecisions.CrystalReports.Engine.ReportDocument);
            rptDoc = new BHXH.HR.UI.Report.CrystalReportLyLich2C();
            rptDoc.DataSourceConnections.Clear();
            rptDoc.SetDataSource(MyDataTableNhanVien);
            ///////////////////////
            CrystalDecisions.CrystalReports.Engine.ReportDocument rptDocSubCTDT = default(CrystalDecisions.CrystalReports.Engine.ReportDocument);
            rptDocSubCTDT = new BHXH.HR.UI.Report.SubReportLyLich2CCTDT();
            rptDoc.Subreports[0].DataSourceConnections.Clear();
            rptDoc.Subreports[0].SetDataSource(MyDataTableCTDaoTao);
            //////////////////////////
            CrystalDecisions.CrystalReports.Engine.ReportDocument rptDocSubQTCT = default(CrystalDecisions.CrystalReports.Engine.ReportDocument);
            rptDocSubQTCT = new BHXH.HR.UI.Report.SubReportLyLich2CQTCT();
            rptDoc.Subreports[1].DataSourceConnections.Clear();
            rptDoc.Subreports[1].SetDataSource(MyDataTableQTCongTac);
            //////////////////////////
            CrystalDecisions.CrystalReports.Engine.ReportDocument rptDocSubQHGD = default(CrystalDecisions.CrystalReports.Engine.ReportDocument);
            rptDocSubQHGD = new BHXH.HR.UI.Report.SubReportLyLich2CQHGD();
            rptDoc.Subreports[2].DataSourceConnections.Clear();
            rptDoc.Subreports[2].SetDataSource(MyDataTableQHGD);
            //////////////////////////////
            this.crystalReportViewer1.ReportSource = rptDoc;
  
        }
        }
    }
//}
