using deneme12.Interfaces;
using deneme12.Entity;
using System.Linq.Expressions;
using System;
using deneme12.Context;
using System.Linq;

namespace deneme12.Repostories
{
    public class OgrenciSinifRepostory : GenericRepostrory<OgrenciSinif>, IOgrenciSinifRepostory
    {
        public OgrenciSinif GetirFiltreile(Expression<Func<OgrenciSinif, bool>> filter)
        {
            using var context = new AppDbContext();
           return context.OgrenciSinif.FirstOrDefault(filter);
        }
    }
}
