using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Repostories
{
    public class SinifRepostory : GenericRepostrory<Sinif>, ISinifRepostory
    {
      
      

        public List<Derslik> GetirDerslik(int sinifid)
        {
            using var context = new AppDbContext();
            return context.Sinif.Join(context.DerslikSinif, sinif => sinif.SinifId,
                derslikSinif => derslikSinif.SinifId, (u, uc) => new
                {
                    Sinif = u,
                    DerslikSinif = uc
                }).Join(context.Dersliks, iki => iki.DerslikSinif.DerslikID, Derslik => Derslik.DerslikId, (uc, k) => new
                {
                    sinif = uc.Sinif,
                    derslik = k,
                    derslikSinif = uc.DerslikSinif
                }).Where(I => I.sinif.SinifId == sinifid).Select(I => new Derslik
                {
                    DerslikName = I.derslik.DerslikName,
                    DerslikId = I.derslik.DerslikId

                }).ToList();
        }

        public List<Ogrenci> GetirOgrenci(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Ogrenci> GetirSinifIdile(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void Silogrenci(OgrenciSinif ogrenciSinif)
        {
            throw new System.NotImplementedException();
        }

        List<Sinif> ISinifRepostory.GetirOgrenci(int Id)
        {
            throw new System.NotImplementedException();

        }

        List<DersProgrami> ISinifRepostory.GetirSinifIdile(int sinifId)
        {
            throw new System.NotImplementedException();
        }
    }
}
