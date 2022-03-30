using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace deneme12.Repostories
{
   
        public class SinifDersRepostory : GenericRepostrory<SinifDers>, ISinifDersRepostory
        {
            public SinifDers GetirFiltreile(Expression<Func<SinifDers, bool>> filter)
            {
                using var context = new AppDbContext();
                return context.SinifDers.FirstOrDefault(filter);
            }
        }
    
}
