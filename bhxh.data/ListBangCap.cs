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
    
    public partial class ListBangCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListBangCap()
        {
            this.HrChiTietDaoTao = new HashSet<HrChiTietDaoTao>();
        }
    
        public string MaBangCap { get; set; }
        public string TenBangCap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HrChiTietDaoTao> HrChiTietDaoTao { get; set; }
    }
}
