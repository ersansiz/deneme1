using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface ISinifRepostory : IGenericRepostory<Sinif>
    {
        List<Sinif> GetirOgrenci(int id);
        List<Derslik> GetirDerslik(int SinifId);
        List<DersProgrami> GetirSinifIdile(int sinifId);


    }
}
