﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcYazGelProje.Models.Entity;

namespace MvcYazGelProje.Controllers
{
    public class OgretmenPanelController : Controller
    {
        // GET: OgretmenPanel
       DBYazgelProjeEntities db = new DBYazgelProjeEntities();
        public ActionResult AnaSayfa()
        {
            return View();
        }




        public ActionResult Goruntuleme()
        {
            var adsoyad = (string)Session["AdSoyad"];
            var goruntuleme = db.form.Where(z => z.sorumlu == adsoyad).ToList();
            return View(goruntuleme);
        }


        public ActionResult StajDetay(int id)
        {
            var bilgi = db.form.Find(id);
            return View("StajDetay", bilgi);
        }




        public ActionResult Degerlendirme()
        {
            var adsoyad = (string)Session["AdSoyad"];
            var stajdegerlendirme = db.form.Where(z => z.sorumlu == adsoyad).ToList();
            return View(stajdegerlendirme);
            
        }
        public ActionResult DegerlendirmeDetay(int id)
        {
            var bilgi = db.form.Find(id);
            return View("DegerlendirmeDetay", bilgi);
        }


        public ActionResult Guncelle(form p)
        {
            var belge = db.form.Find(p.staj_id);
            belge.staj_id = p.staj_id;
            belge.stajNotu = p.stajNotu;
            belge.basvuruDurumu = p.basvuruDurumu;
            belge.sorumlu = p.sorumlu;
            db.SaveChanges();
            return RedirectToAction("Degerlendirme"); 

        }



        public ActionResult SifreDegistir()
        {
            var no = (string)Session["no"];
            var kullanici = db.uye.Where(z => z.uye_no == no).ToList();
            return View(kullanici); ;
        }
        public ActionResult SıfreDegistirDetay(string id)
        {
            var bilgi = db.uye.Find(id);
            return View("SıfreDegistirDetay", bilgi);
        }
        public ActionResult SıfreDegistirme(uye p)
        {

            var bilgi = db.uye.Find(p.uye_no);
            bilgi.uye_no = p.uye_no;
            string sifre = Sifrele.MD5Olustur(p.uye_sifre);
            bilgi.uye_sifre = sifre;
            db.SaveChanges();
            return View("AnaSayfa", bilgi);
        }
    }
}