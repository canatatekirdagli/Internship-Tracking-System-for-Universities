﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcYazGelProje.Controllers
{
    public class OgrenciPanelController : Controller
    {
        // GET: OgrenciPanel
        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult BilgiGoruntule()
        {
            return View();
        }
        public ActionResult StajBilgileri()
        {
            return View();
        }
        public ActionResult ImeBilgileri()
        {
            return View();
        }
        public ActionResult Stajİsleri()
        {
            return View();
        }
        public ActionResult IMEIsleri()
        {
            return View();
        }
        public ActionResult SifreDegistir()
        {
            return View();
        }
    }
}