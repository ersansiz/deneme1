using deneme12.Interfaces;
using deneme12.Entity;
using System.Linq.Expressions;
using System;
using deneme12.Context;
using System.Linq;

namespace deneme12.Repostories
{
    public class DerslikSinifRepostory : GenericRepostrory<DerslikSinif>, IDerslikSinifRepostory
    {
        public DerslikSinif GetirFiltreile(Expression<Func<DerslikSinif, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
