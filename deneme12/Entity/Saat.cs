using System.Collections.Generic;

namespace deneme12.Entity
{
    public class Saat
    {
        public int SaatId { get; set; }
        public string SaatName { get; set; }
        public List<DersProgrami> DersProgrami { get; set; }
    }
}
