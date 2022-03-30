using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface IGunRepostory : IGenericRepostory<Gun>
    {
        List<Sinif> GetirSinif(int GunId);
    }
}
