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
    
    public partial class IME_bilgileri
    {
        public int IME_id { get; set; }
        public Nullable<int> ogr_no { get; set; }
        public Nullable<int> stajYeri_id { get; set; }
        public Nullable<int> unvan_id { get; set; }
        public Nullable<bool> soru1 { get; set; }
        public Nullable<bool> soru2 { get; set; }
        public Nullable<bool> soru3 { get; set; }
        public Nullable<int> is_gunu { get; set; }
        public Nullable<System.DateTime> IME_baslangic { get; set; }
        public Nullable<System.DateTime> IME_bitis { get; set; }
        public string iban { get; set; }
        public string ogr_adres { get; set; }
        public Nullable<int> il_id { get; set; }
        public Nullable<int> posta_kodu { get; set; }
        public Nullable<int> stajNotu { get; set; }
        public string stajDonemiYıl { get; set; }
        public string stajDonemiDonem { get; set; }
        public Nullable<int> basvuruDurumuId { get; set; }
    
        public virtual basvuruDurumu basvuruDurumu { get; set; }
        public virtual il il { get; set; }
        public virtual uye uye { get; set; }
        public virtual ilce ilce { get; set; }
        public virtual staj_yeri staj_yeri { get; set; }
        public virtual unvan unvan { get; set; }
    }
}