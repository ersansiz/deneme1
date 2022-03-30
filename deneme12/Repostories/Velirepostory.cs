using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Repostories
{
    public class VeliRepostory : GenericRepostrory<Veli>, IVeliRepostory
    {
        public List<Ogrenci> GetirOgrenci(int veliId)
        {
            using var context = new AppDbContext();
            return context.Veli.Join(context.OgrenciVeli, veli => veli.VeliID,
                ogrenciVeli => ogrenciVeli.VeliID, (u, uc) => new
                {
                    Veli = u,
                    OgrenciVeli = uc
                }).Join(context.Ogrenci, iki => iki.OgrenciVeli.OgrenciId, Ogrenci => Ogrenci.OgrenciID, (uc, k) => new
                {
                    veli = uc.Veli,
                    ogrenci = k,
                    ogrenciVeli = uc.OgrenciVeli
                }).Where(I => I.veli.VeliID == veliId).Select(I => new Ogrenci
                {
                    OgrenciName = I.ogrenci.OgrenciName,
                    OgrenciID = I.ogrenci.OgrenciID

                }).ToList();
        }
    }
}
