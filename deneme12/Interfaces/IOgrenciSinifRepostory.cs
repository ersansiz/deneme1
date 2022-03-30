using deneme12.Entity;
using System;
using System.Linq.Expressions;

namespace deneme12.Interfaces
{
    public interface IOgrenciSinifRepostory :IGenericRepostory<OgrenciSinif>
    {
        OgrenciSinif GetirFiltreile(Expression<Func<OgrenciSinif, bool>> filter);
    }
}
