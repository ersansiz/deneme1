using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface IDersRepostory : IGenericRepostory<Ders>
    {
        List<Sinif> GetirSinif(int DersId);
    }
}
