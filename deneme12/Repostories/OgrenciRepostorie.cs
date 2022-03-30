using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Repostories
{
    public class OgrenciRepostorie : GenericRepostrory<Ogrenci>, IOgrenciRepostory
    {
        private readonly IOgrenciSinifRepostory _ogrenciSinifRepostory;
       
        public OgrenciRepostorie(IOgrenciSinifRepostory ogrenciSinifRepostory)
        {
            _ogrenciSinifRepostory = ogrenciSinifRepostory;
           
        }
     
        public void SilSinif(OgrenciSinif ogrenciSinif)
        {
            var kontrolKayit = _ogrenciSinifRepostory.GetirFiltreile(I => I.OgrenciId == ogrenciSinif.OgrenciId && I.SinifID == ogrenciSinif.SinifID);
            if (kontrolKayit != null)
            {
                _ogrenciSinifRepostory.Sil(ogrenciSinif);
            };
        }
        public void GuncelleSinif(OgrenciSinif ogrenciSinif)
        {
            var kontrolKayit = _ogrenciSinifRepostory.GetirFiltreile(I => I.SinifID == ogrenciSinif.SinifID && I.OgrenciId == ogrenciSinif.OgrenciId);
            if (kontrolKayit != null)
            {
                _ogrenciSinifRepostory.Güncelle(ogrenciSinif);
            };
        }
        public void EkleSinif(OgrenciSinif ogrenciSinif)
        {
            var kontrolKayit = _ogrenciSinifRepostory.GetirFiltreile(I => I.OgrenciId == ogrenciSinif.OgrenciId && I.SinifID == ogrenciSinif.SinifID);
            if (kontrolKayit == null)
            {
                _ogrenciSinifRepostory.Ekle(ogrenciSinif);
            };
        }
        public List<Ogrenci> GetirSinifIdile(int sinifId)
        {
            using var context = new AppDbContext();
            return context.Ogrenci.Join(context.OgrenciSinif,
                u => u.OgrenciID, uc => uc.OgrenciId, (ogrenci, ogrenciSinif) => new
                {
                    Ogrenci = ogrenci,
                    OgrenciSinif = ogrenciSinif
                }).Where(I => I.OgrenciSinif.SinifID == sinifId).Select(I => new Ogrenci
                {
                    OgrenciID = I.Ogrenci.OgrenciID,
                    OgrenciName = I.Ogrenci.OgrenciName

                }).ToList();
        }

        public List<Sinif> GetirSinif(int ogrenciId)
        {
            using var context = new AppDbContext();
            return context.Ogrenci.Join(context.OgrenciSinif, ogrenci => ogrenci.OgrenciID, 
                ogrenciSinif => ogrenciSinif.OgrenciId, (u, uc) => new
            {
                Ogrenci = u,
                OgrenciSinif = uc
            }).Join(context.Sinif,iki=>iki.OgrenciSinif.SinifID, sinif=>sinif.SinifId,(uc,k)=> new
            {
                ogreci=uc.Ogrenci,
                sinif=k,
                ogrenciSinif=uc.OgrenciSinif
            }).Where(I=>I.ogreci.OgrenciID==ogrenciId).Select(I=>new Sinif { 
                SinifName=I.sinif.SinifName,
                SinifId=I.sinif.SinifId,

            }).ToList();
        }
        public List<Veli> GetirVeli(int ogrenciId)
        {
            using var context = new AppDbContext();
            return context.Ogrenci.Join(context.OgrenciVeli, ogrenci => ogrenci.OgrenciID,
                ogrenciVeli => ogrenciVeli.OgrenciId, (u, uc) => new
                {
                    Ogrenci = u,
                    OgrenciVeli = uc
                }).Join(context.Veli, iki => iki.OgrenciVeli.VeliID, Veli => Veli.VeliID, (uc, k) => new
                {
                    ogrenci = uc.Ogrenci,
                    veli = k,
                    ogrenciVeli = uc.OgrenciVeli
                }).Where(I => I.ogrenci.OgrenciID == ogrenciId).Select(I => new Veli
                {
                    VeliName = I.veli.VeliName,
                    VeliID = I.veli.VeliID

                }).ToList();
        }



        public List<Sinif> GetirOgrenci(int OgrenciId)
        {
            throw new System.NotImplementedException();
        }

        public void Ekle(OgrenciSinif OgrenciSinif)
        {
            throw new System.NotImplementedException();
        }
    }
}
