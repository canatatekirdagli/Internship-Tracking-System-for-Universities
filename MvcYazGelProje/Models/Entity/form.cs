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
    
    public partial class form
    {
        public int staj_id { get; set; }
        public string ogr_no { get; set; }
        public string stajYeri_ad { get; set; }
        public Nullable<System.DateTime> staj_baslangic { get; set; }
        public Nullable<System.DateTime> staj_bitis { get; set; }
        public Nullable<int> stajNotu { get; set; }
        public string stajDonemiYıl { get; set; }
        public string stajDonemiDonem { get; set; }
        public string basvuruDurumu { get; set; }
        public string stajIME { get; set; }
        public string sorumlu { get; set; }
    
        public virtual uye uye { get; set; }
    }
}
