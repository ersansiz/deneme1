using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface IDerslikRepostory : IGenericRepostory<Derslik>
    {
        List<Sinif> GetirDerslik(int sinifId);
     
    }
}
