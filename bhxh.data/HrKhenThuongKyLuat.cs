//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BHXH.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HrKhenThuongKyLuat
    {
        public System.Guid MaNhanVien { get; set; }
        public Nullable<decimal> STT { get; set; }
        public string MaKTKL { get; set; }
        public string Nam { get; set; }
        public string GhiChu { get; set; }
        public string MaPhongBan { get; set; }
    
        public virtual HrNhanVien HrNhanVien { get; set; }
        public virtual ListKTKL ListKTKL { get; set; }
    }
}
