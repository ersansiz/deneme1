using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface IVeliRepostory : IGenericRepostory<Veli>
    {
        List<Ogrenci> GetirOgrenci(int veliId);


    }
}
