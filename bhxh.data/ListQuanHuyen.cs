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
    
    public partial class ListQuanHuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListQuanHuyen()
        {
            this.HrNhanVien = new HashSet<HrNhanVien>();
            this.HrNhanVien1 = new HashSet<HrNhanVien>();
            this.HrNhanVien2 = new HashSet<HrNhanVien>();
            this.HrNhanVien3 = new HashSet<HrNhanVien>();
            this.HrNhanVien4 = new HashSet<HrNhanVien>();
            this.HrNhanVien5 = new HashSet<HrNhanVien>();
            this.HrNhanVien6 = new HashSet<HrNhanVien>();
            this.HrNhanVien7 = new HashSet<HrNhanVien>();
            this.ListXaPhuong = new HashSet<ListXaPhuong>();
        }
    
        public decimal QuanHuyenID { get; set; }
        public string MaQuanHuyen { get; set; }
        public string TenQuanHuyen { get; set; }
        public string MaTinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrNhanVien> HrNhanVien7 { get; set; }
        public virtual ListTinh ListTinh { get; set; }
        public virtual ListQuanHuyen ListQuanHuyen1 { get; set; }
        public virtual ListQuanHuyen ListQuanHuyen2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListXaPhuong> ListXaPhuong { get; set; }
    }
}