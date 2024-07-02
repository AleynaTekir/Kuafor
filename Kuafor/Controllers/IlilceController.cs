using Kuafor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kuafor.Controllers
{
    public class IlilceController : Controller
    {
        KuaförEntities25 db = new KuaförEntities25();
        // GET: Ililce
        public ActionResult liste()
        {
            
            Class1 model = new Class1();
            List<İl> sehirList = db.İl.OrderBy(f => f.İlAdı).ToList();
            model.SehirList = (from s in sehirList
                               select new SelectListItem
                               {
                                   Text = s.İlAdı,
                                   Value = s.ID.ToString()

                               }).ToList();
            islemmodel by = new islemmodel();
          

           //List <Kuaför> KuaförList = db.Kuaför.ToList();
           
            //var SiraliOgrenciListesi = KuaförList.OrderBy(Ogrenci => Ogrenci.puan) descending;
            //model.KuaförList = (List<Kuaför>)(from kf in KuaförList
            //                  orderby kf.puan descending
            //                  select kf);
            //var sorguiladi = db.İl.Where(i => i.ID ==sorgukuaför.).FirstOrDefault();
            //model.İl = sorguiladi.İlAdı;
            //var sorguilçeadi = db.İlçe.Where(i => i.ID == (int)ilçe).FirstOrDefault();
            //model.ilçe = sorguilçeadi.İlçeAdı;
            model.KuaförList = db.Kuaför.ToList();

            return View(model);

        }
        [HttpPost]
        public JsonResult IlceList(int id)
        {
            
            List<İlçe> ilceList = db.İlçe.Where(k => k.İlID == id).OrderBy(f => f.ID).ToList();
            List<SelectListItem> itemList = (from i in ilceList
                                             select new SelectListItem
                                             {
                                                 Value = i.ID.ToString(),
                                                 Text = i.İlçeAdı
                                             }).ToList();
            var Il = db.İl.Where(x => x.ID == id).FirstOrDefault();
            TempData["il"] = Il.İlAdı;
            return Json(itemList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult list(int id)
        {
            //Class1 model = new Class1();
            //List<Kategori> sehirList = db.Kategori.OrderBy(f => f.KategoriAdi).ToList();
            //model.SehirList = (from s in sehirList
            //                   select new SelectListItem
            //                   {
            //                       Text = s.KategoriAdi,
            //                       Value = s.ID.ToString()

            //                   }).ToList();
            //ViewBag.mesaj = id;
            //TempData["veri"] = id;

            var ilceList = db.İlçe.Where(k => k.ID == id).FirstOrDefault();
            ////List<SelectListItem> itemList = (from i in ilceList
            //                                 select new SelectListItem
            //                                 {
            //                                     Value = i.ID.ToString(),
            //                                     Text = i.KategoriAdi
            //                                 }).ToList();
            TempData["ilçe"] = ilceList.İlçeAdı;
            var p = ilceList;
            var values = from x in db.Kuaför select x;
            //List<Kuaför> liste = db.Kuaför.ToList();
            //if (p != null)
            //{
            //    model.KuaförList = db.Kuaför.Where(i => i.Adres == p.KategoriAdi).ToList();

            //}

            //return View(model);
            return RedirectToAction("list");
        }
        [HttpPost]
        public ActionResult liste(FormCollection dtn)
        {
            Class1 model = new Class1();
            var ilçe = TempData["ilçe"];
            var il = TempData["il"];
           // var ilceList = db.AltKategori.Where(k => k.KategoriAdi == ilçe).FirstOrDefault();
            ////List<SelectListItem> itemList = (from i in ilceList
            ////                                 select new SelectListItem
            ////                                 {
            ////                                     Value = i.ID.ToString(),
            ////                                     Text = i.KategoriAdi
            ////                                 }).ToList();
            //model.SehirList = (from i in ilceList
            //                                 select new SelectListItem
            //                                 {
            //                                     Value = i.ID.ToString(),
            //                                     Text = i.KategoriAdi
            //                                 }).ToList();

            //var p = ilceList;
            //var values = from x in db.Kuaför select x;
            //List<Kuaför> liste = db.Kuaför.ToList();
            //if (p != null)
            //{
            //    model.KuaförList = db.Kuaför.Where(i => i.Adres == p.KategoriAdi).ToList();

            //}
            //}
            List<İl> sehirList = db.İl.OrderBy(f => f.İlAdı).ToList();
            model.SehirList = (from s in sehirList
                               select new SelectListItem
                               {
                                   Text = s.İlAdı,
                                   Value = s.ID.ToString()

                               }).ToList();

            //List<Kuaför> KuaförList = db.Kuaför.ToList();
            //var SiraliOgrenciListesi = KuaförList.OrderBy(Ogrenci => Ogrenci.puan) descending;
            //model.KuaförList = (List<Kuaför>)(from kf in KuaförList
            //                  orderby kf.puan descending
            //                  select kf);
            model.KuaförList = db.Kuaför.Where(k => k.il ==il && k.ilçe==ilçe ).ToList();

            return View(model);
        }
    }

}