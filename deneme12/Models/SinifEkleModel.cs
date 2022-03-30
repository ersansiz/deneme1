using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Models
{
    public class DersEkleModel
    {
        public string DersName { get; set; }
        public List<Sinif> sinifs { get; set; }
    }
}
