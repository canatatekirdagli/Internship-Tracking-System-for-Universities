﻿using MvcYazGelProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcYazGelProje.Controllers
{
    public class OgretmenLoginController : Controller
    {
        // GET: OgretmenLogin
        Models.Entity.DBYazgelProjeEntities2 db = new Models.Entity.DBYazgelProjeEntities2();
        [HttpGet]
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(uye p)
        {
            var bilgiler = db.uye.FirstOrDefault(x => x.uye_no == p.uye_no && x.uye_sifre == p.uye_sifre);
            if (bilgiler != null)
            {
                if (bilgiler.uye_gorevi=="Ogretmen")
                {
                    return RedirectToAction("Anasayfa", "OgretmenPanel");
                }
                else
                {

                }

               
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Sicil No ya da Şifre";
                return View();
            }
        }
        public ActionResult SifremiUnuttum()
        {
            return View();
        }
    }
}