using System.Collections.Generic;

namespace deneme12.Entity
{
    public class Derslik
    {
        public int DerslikId { get; set; }
        public string DerslikName { get; set; }
        public IEnumerable<DerslikSinif> DerslikSinif { get; set; }
        public List<DersProgrami> DersProgrami { get; set; }
    }
}
