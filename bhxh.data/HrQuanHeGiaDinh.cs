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
    
    public partial class HrQuanHeGiaDinh
    {
        public System.Guid MaNhanVien { get; set; }
        public Nullable<decimal> STT { get; set; }
        public string MaQuanHeGD { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string ChiTiet { get; set; }
    
        public virtual HrNhanVien HrNhanVien { get; set; }
        public virtual ListQuanHeGD ListQuanHeGD { get; set; }
    }
}
