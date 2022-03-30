using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace deneme12.Repostories
{
    public class DersProgamiRepostory : GenericRepostrory<DersProgrami>, IDersProgamiRepostory
    {
        public DersProgrami GetirFiltreile(Expression<Func<DersProgrami, bool>> filter)
        {
            using var context = new AppDbContext();
            return context.DersProgrami.FirstOrDefault(filter);
        }
    }
}
