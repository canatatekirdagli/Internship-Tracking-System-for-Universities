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
    
    public partial class dosya
    {
        public int dosya_id { get; set; }
        public Nullable<int> ogr_no { get; set; }
        public Nullable<int> staj_no { get; set; }
        public string dosya_yolu { get; set; }
    
        public virtual uye uye { get; set; }
    }
}