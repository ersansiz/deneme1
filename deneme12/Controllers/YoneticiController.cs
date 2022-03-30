using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using deneme12.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace deneme12.Controllers
{
    
    public class YoneticiController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IOgrenciRepostory _ogrenciRepostory;
        
        private readonly IVeliRepostory _veliRepostory;
        private readonly IDerslikRepostory _derslikRepostory;
        public YoneticiController(AppDbContext db,IOgrenciRepostory ogrenciRepostory, IVeliRepostory veliRepostory, IDerslikRepostory derslikRepostory)
        {
            _db = db;
            _ogrenciRepostory = ogrenciRepostory;
           
            _veliRepostory = veliRepostory;
            _derslikRepostory = derslikRepostory;
        }
        public IActionResult Index()
        {
            return View(_ogrenciRepostory.GetirHepsi());
        }
        public IActionResult OgrenciBilgi(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var appDbContext = _db.Ogrenci
                   .Where(I => I.OgrenciName.ToLower().Contains(search.ToLower()))
                   .ToList();
                return View(appDbContext);
            }
                return View(_ogrenciRepostory.GetirHepsi());
        }
        public IActionResult Ekle()
        {
           
            return View(new OgrenciEkleModel());
        }
        [HttpPost]
        public IActionResult Ekle(OgrenciEkleModel model)
        {
            if (ModelState.IsValid)
            {
                Ogrenci ogrenci = new Ogrenci();
                if (model.Resim!=null)
                {
                    var uzanti =Path.GetExtension(model.Resim.FileName);
                    var yeniResimAd = Guid.NewGuid() + uzanti;
                    var yuklnecekYer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Ogrenci/"+yeniResimAd);

                    var stream = new FileStream(yuklnecekYer, FileMode.Create);
                    model.Resim.CopyTo(stream);

                    ogrenci.Resim = yeniResimAd;
                }
                
                ogrenci.OgrenciName = model.OgrenciName;
                ogrenci.OgrenciTcKimlik = model.OgrenciTcKimlik;
               
                ogrenci.Telefon = model.Telefon;
                ogrenci.Adres = model.Adres;
                ogrenci.Tarih = model.Tarih;              
                ogrenci.OKulName = model.OKulName;
                _ogrenciRepostory.Ekle(ogrenci);
                return RedirectToAction("Index");
               
            }
            return View(model);
        }
        public IActionResult Güncelle(int id)
        {
            var gelenOgrenci = _ogrenciRepostory.GetirIdile(id);
           
         
            
            OgrenciEditModel model = new OgrenciEditModel
           
            {
                OgrenciName = gelenOgrenci.OgrenciName,
                OgrenciTcKimlik = gelenOgrenci.OgrenciTcKimlik,
                
                Telefon = gelenOgrenci.Telefon,
                Adres = gelenOgrenci.Adres,
                Tarih = gelenOgrenci.Tarih,
                OKulName = gelenOgrenci.OKulName,
                
                OgrenciId = gelenOgrenci.OgrenciID,

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Güncelle(OgrenciEditModel model)
        {

            if (ModelState.IsValid)
            {
                var guncelleOgrenci = _ogrenciRepostory.GetirIdile(model.OgrenciId);
                if (model.Resim != null)
                {
                    var uzanti = Path.GetExtension(model.Resim.FileName);
                    var yeniResimAd = Guid.NewGuid() + uzanti;
                    var yuklnecekYer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Ogrenci/" + yeniResimAd);

                    var stream = new FileStream(yuklnecekYer, FileMode.Create);
                    model.Resim.CopyTo(stream);

                    guncelleOgrenci.Resim = yeniResimAd;
                }
                guncelleOgrenci.OgrenciName = model.OgrenciName;
                guncelleOgrenci.OgrenciTcKimlik = model.OgrenciTcKimlik;
             
                guncelleOgrenci.Telefon = model.Telefon;
                guncelleOgrenci.Adres = model.Adres;
                guncelleOgrenci.Tarih = model.Tarih;
                guncelleOgrenci.OKulName = model.OKulName;

                _ogrenciRepostory.Güncelle(guncelleOgrenci);
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult VeliGuncelle(int id)
        {
            var gelenVeli = _veliRepostory.GetirIdile(id);



            VeliGuncelleModel model = new VeliGuncelleModel

            {
                VeliName = gelenVeli.VeliName,
                VeliTcKimlik = gelenVeli.VeliTcKimlik,

                Telefon = gelenVeli.Telefon,
                Adres = gelenVeli.Adres,
                Odeme = gelenVeli.Odeme,


                VeliId = gelenVeli.VeliID,

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult VeliGuncelle(VeliGuncelleModel model)
        {

            if (ModelState.IsValid)
            {
                var guncelleVeli = _veliRepostory.GetirIdile(model.VeliId);
                if (model.Resim != null)
                {
                    var uzanti = Path.GetExtension(model.Resim.FileName);
                    var yeniResimAd = Guid.NewGuid() + uzanti;
                    var yuklnecekYer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Veli/" + yeniResimAd);

                    var stream = new FileStream(yuklnecekYer, FileMode.Create);
                    model.Resim.CopyTo(stream);

                    guncelleVeli.Resim = yeniResimAd;
                }
                guncelleVeli.VeliName = model.VeliName;
                guncelleVeli.VeliTcKimlik = model.VeliTcKimlik;

                guncelleVeli.Telefon = model.Telefon;
                guncelleVeli.Adres = model.Adres;
                guncelleVeli.Odeme = model.Odeme;
               

                _veliRepostory.Güncelle(guncelleVeli);
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult Sil(int id)
        {
            _ogrenciRepostory.Sil(new Ogrenci { OgrenciID=id});
           
            return RedirectToAction("Index");
        }
        public IActionResult VeliEkle()
        {

            return View(new VeliEkleModel());
        }
        [HttpPost]
        public IActionResult VeliEkle(VeliEkleModel model)
        {
            if (ModelState.IsValid)
            {
                Veli veli = new Veli();
                
                veli.VeliTcKimlik = model.VeliTcKimlik;
                veli.VeliName = model.VeliName;
                veli.Telefon = model.Telefon;
                veli.Adres = model.Adres;
                veli.Odeme = model.Odeme;
                
                _veliRepostory.Ekle(veli);
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult OgrenciDetay(int id)
        {
            return View(_ogrenciRepostory.GetirIdile(id));
        }
        public IActionResult VeliList(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var appDbContext = _db.Veli
                   .Where(I => I.VeliName.ToLower().Contains(search.ToLower()))
                   .ToList();
                return View(appDbContext);
            }
            return View(_veliRepostory.GetirHepsi());
        }
        public IActionResult DersProgrami()
        {
            return View(_veliRepostory.GetirHepsi());
        }
        public IActionResult DerslikEkle()
        {

            return View(new DerslikEkleModel());
        }
        [HttpPost]
        public IActionResult DerslikEkle(DerslikEkleModel model)
        {
            if (ModelState.IsValid)
            {
                Derslik derslik = new Derslik();

                derslik.DerslikName = model.DerslikName;


                _derslikRepostory.Ekle(derslik);
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public void SetSession(string key, string value)
        {
            
            HttpContext.Session.SetString(key, value);
        }
        public string GetSession(string key)
        {
            return HttpContext.Session.GetString(key);
        }


    }
}
