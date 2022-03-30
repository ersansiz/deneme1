using deneme12.Entity;
using System;
using System.Linq.Expressions;

namespace deneme12.Interfaces
{
    public interface IDerslikSinifRepostory : IGenericRepostory<DerslikSinif>
    {
        DerslikSinif GetirFiltreile(Expression<Func<DerslikSinif, bool>> filter);
    }
}
