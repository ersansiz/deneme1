using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Repostories
{
    public class DersRepostory : GenericRepostrory<Ders>, IDersRepostory
    {
        private readonly ISinifDersRepostory _sinifDersRepostory;
        public DersRepostory(ISinifDersRepostory sinifDersRepostory)
        {
            _sinifDersRepostory = sinifDersRepostory;
        }

        public List<Sinif> GetirSinif(int DersId)
        {
            using var context = new AppDbContext();
            return context.Ders.Join(context.SinifDers, ders => ders.DersId,
                SinifDers => SinifDers.DersId, (u, uc) => new
                {
                    Ders = u,
                    SinifDers = uc
                }).Join(context.Sinif, iki => iki.SinifDers.SinifId, Sinif => Sinif.SinifId, (uc, k) => new
                {
                    ders = uc.Ders,
                    sinif = k,
                    sinifDers = uc.SinifDers
                }).Where(I => I.ders.DersId == DersId).Select(I => new Sinif
                {
                    SinifName = I.sinif.SinifName,
                    SinifId = I.sinif.SinifId

                }).ToList();
        }
    }
}
