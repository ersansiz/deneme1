using deneme12.Interfaces;
using deneme12.Entity;
using System.Linq.Expressions;
using System;
using deneme12.Context;
using System.Linq;

namespace deneme12.Repostories
{
    public class GunSinifRepostory : GenericRepostrory<GunSinif>, IGunSinifRepostory
    {
        public GunSinif GetirFiltreile(Expression<Func<GunSinif, bool>> filter)
        {
            using var context = new AppDbContext();
           return context.GunSinif.FirstOrDefault(filter);
        }
    }
}
