using deneme12.Entity;
using System;
using System.Linq.Expressions;

namespace deneme12.Interfaces
{
    public interface ISinifDersRepostory : IGenericRepostory<SinifDers>
    {
        SinifDers GetirFiltreile(Expression<Func<SinifDers, bool>> filter);
    }
}
