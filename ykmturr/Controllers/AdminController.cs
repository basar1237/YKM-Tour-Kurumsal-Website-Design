using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;
namespace ykmturr.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        //HAKKIMIZDA ADMİN KONTORL SAYFASI 
        public ActionResult Index()
        {
            var degerler = c.Hakkımızdas.ToList();
            return View(degerler);
        }
        public ActionResult HakkımdaGetir(int Id)
        {
            var hk=c.Hakkımızdas.Find(Id);
            return View("HakkımdaGetir",hk);
        }
        public ActionResult HakkımızdaGuncelle(Hakkımızda b)
        {
            var hkk = c.Hakkımızdas.Find(b.Id);

            if (hkk != null)
            {
                hkk.Baslik1 = b.Baslik1;
                hkk.Aciklama1 = b.Aciklama1;
                hkk.Baslik2 = b.Baslik2;
                hkk.Aciklama2 = b.Aciklama2;
                hkk.Baslik3 = b.Baslik3;
                hkk.Aciklama3 = b.Aciklama3;
                hkk.Baslik4 = b.Baslik4;
                hkk.Aciklama4 = b.Aciklama4;
                hkk.Baslik5 = b.Baslik5;
                hkk.Aciklama5 = b.Aciklama5;
                hkk.FotoUrl = b.FotoUrl;

                c.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //CORPORATE ADMİN KONTROL SAYFASI 
        public ActionResult Corporatee()
        {
            var degerler = c.Corporates.ToList();
            return View(degerler);
        }
        public ActionResult CorporateGetir(int ID)
        {
            var cr = c.Corporates.Find(ID);
            return View("CorporateGetir", cr);
        }
        public ActionResult CorporateGuncelle(Corporate b)
        {
            var cr = c.Corporates.Find(b.ID);
            if (cr != null)
            {
                cr.Baslik1 = b.Baslik1;
                cr.Aciklama1 = b.Aciklama1;
                cr.Baslik2 = b.Baslik2;
                cr.Aciklama2 = b.Aciklama2;
                cr.Baslik3 = b.Baslik3;
                cr.Aciklama3 = b.Aciklama3;
                cr.FotoUrl = b.FotoUrl;

                c.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    
        public ActionResult İletisim()
        {
            var degerler = c.İletisims.ToList();
            return View(degerler);
        }


        //PRİVATE ADMİN KONTROL SAYFASI 
        public ActionResult Private()
        {
            var degerler = c.Privates.ToList();
            return View(degerler);
        }
        public ActionResult PrivateGetir(int Id)
        {
            var cr = c.Privates.Find(Id);
            return View("PrivateGetir", cr);

        }
        public ActionResult PrivateGuncelle(Private b)
        {
            var pr = c.Privates.Find(b.Id);
           
                pr.Baslik1 = b.Baslik1;
                pr.Baslik2 =b.Baslik2 ;
                pr.Baslik3 =b.Baslik3 ;
                pr.Baslik4 =b.Baslik4 ;
                pr.Baslik5  =b.Baslik5 ;
                pr.TurBaslik1 =b.TurBaslik1 ;
                pr.TurBaslik2=b.TurBaslik2 ;
                pr.TurBaslik3=b.TurBaslik3 ;
                pr.turFotoUrl1=b.turFotoUrl1 ;
                pr.TurBaslik2=b.TurBaslik2 ;
                pr.turFotoUrl2 =b.turFotoUrl2 ;
                pr.TurBaslik3 = b.TurBaslik3 ;
                pr.turFotoUrl3 =b.turFotoUrl3 ;

                c.SaveChanges();


            return RedirectToAction("Private");


        }
        //POPULER SAYFASI ADMİN SAYFASI
        public ActionResult Populer()
        {
            var degerler=c.Populers.ToList();
            return View(degerler);

        }
        public ActionResult PopulerGetir(int ID)
        {
            var pr = c.Populers.Find(ID);   
            return View("PopulerGetir",pr);
        }
        public ActionResult PopulerGuncelle(Populer b )
        {
            var pp=c.Populers.Find( b.ID);

            pp.Baslik1=b.Baslik1 ;
            pp.Baslik2  =b.Baslik2 ;
            pp.Baslik3=b.Baslik3  ;
            pp.Baslik4=b.Baslik4  ;
            pp.Baslik5=b.Baslik5  ;
            pp.Baslik6=b.Baslik6  ;
            pp.Aciklama1 =b.Aciklama1 ;
            pp.Aciklama2 =b.Aciklama2 ;
            pp.Aciklama3 = b.Aciklama3;
            pp.Aciklama4=b.Aciklama4;
            pp.Aciklama5=b.Aciklama5;
            pp.Aciklama6=b.Aciklama6;
            pp.FotoUrl1 =b.FotoUrl1 ;
            pp.FotoUrl2 =b.FotoUrl2 ;
            pp.FotoUrl3 =b.FotoUrl3;
            pp.FotoUrl4 =b.FotoUrl4;
            pp.FotoUrl5 =b.FotoUrl5;
            pp.FotoUrl6 =b.FotoUrl6;

            c.SaveChanges();

           return  RedirectToAction("Populer");
        }
        //Trip SAYFASI ADMİN SAYFASI
        public ActionResult hotel()
        {
            var degerler=c.Hotels.ToList();
            return View(degerler);
        }
        public ActionResult HotelGetir(int ID)
        {
            var tp = c.Hotels.Find(ID);
                return View("HotelGetir",tp);

        }

        public ActionResult HotelGuncelle(Hotel b){

            var tr= c.Hotels.Find(b.ID);

            tr.Baslik1 = b.Baslik1;
            tr.Aciklama1=b.Aciklama1;
            tr.FotoUrl1=b.FotoUrl1;
            tr.Baslik2 = b.Baslik2;
            tr.Aciklama2 =b.Aciklama2;
            tr.FotoUrl2 =b.FotoUrl2;
            tr.Baslik3 = b.Baslik3;
            tr.Aciklama3=b.Aciklama3;
            tr.FotoUrl3 =b.FotoUrl3;
            tr.Baslik4 = b.Baslik4;
            tr.Aciklama4 =b.Aciklama4;
            tr.FotoUrl4 =b.FotoUrl4;
            tr.Baslik5 = b.Baslik5;
            tr.Aciklama5 =b.Aciklama5;
            tr.FotoUrl5 =b.FotoUrl5;
            tr.Baslik6 = b.Baslik6;
            tr.Aciklama6 =b.Aciklama6;
            tr.FotoUrl6 =b.FotoUrl6;

            c.SaveChanges();
            return RedirectToAction("Index");

        }
        
        [HttpGet]
        public ActionResult Hakkımda()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Hakkımda(Hakkımızda p)
        {
            return View();
        }

    }
}