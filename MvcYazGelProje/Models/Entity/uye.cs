//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcYazGelProje.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uye()
        {
            this.dosya = new HashSet<dosya>();
            this.form = new HashSet<form>();
        }
    
        public string uye_no { get; set; }
        public string uyeAd { get; set; }
        public string uyeSoyad { get; set; }
        public string uyeEposta { get; set; }
        public string uye_gsm { get; set; }
        public string uye_tc { get; set; }
        public string uye_sifre { get; set; }
        public string uye_gorevi { get; set; }
        public string uye_bolumAd { get; set; }
        public Nullable<bool> IME_durumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dosya> dosya { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<form> form { get; set; }
    }
}
