using deneme12.Entity;
using System;
using System.Linq.Expressions;

namespace deneme12.Interfaces
{
    public interface IGunSinifRepostory : IGenericRepostory<GunSinif>
    {
        GunSinif GetirFiltreile(Expression<Func<GunSinif, bool>> filter);
    }
}
