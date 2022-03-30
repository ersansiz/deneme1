using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Repostories
{
    public class GunRepostory : GenericRepostrory<Gun>, IGunRepostory
    {
        private readonly IGunSinifRepostory _gunSinifRepostory;
        public GunRepostory(IGunSinifRepostory gunSinifRepostory)
        {
            _gunSinifRepostory = gunSinifRepostory;
        }

        public List<Sinif> GetirSinif(int GunId)
        {
            using var context = new AppDbContext();
            return context.Gun.Join(context.GunSinif, gun => gun.GunId,
                GunSinif => GunSinif.GunID, (u, uc) => new
                {
                    Gun = u,
                   GunSinif = uc
                }).Join(context.Sinif, iki => iki.GunSinif.SinifId, Sinif => Sinif.SinifId, (uc, k) => new
                {
                    gun = uc.Gun,
                    sinif = k,
                    GunSinif = uc.GunSinif
                }).Where(I => I.gun.GunId == GunId).Select(I => new Sinif
                {
                    SinifName = I.sinif.SinifName,
                    SinifId = I.sinif.SinifId

                }).ToList();
        }
    }
}
