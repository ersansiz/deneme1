using deneme12.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace deneme12.Interfaces
{
    public interface IDersProgamiRepostory : IGenericRepostory<DersProgrami>
    {
        DersProgrami GetirFiltreile(Expression<Func<DersProgrami, bool>> filter);
    }
}
