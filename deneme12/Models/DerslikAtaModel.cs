using deneme12.Entity;
using System.Collections;
using System.Collections.Generic;

namespace deneme12.Models
{
    public class DerslikAtaModel
    {
        public int DerslikId { get; set; }
        public string DerslikName { get; set; }
        
        public IEnumerable<Sinif> Sinif { get; set; }
        
        public IEnumerable<Derslik> Derslik { get; set; }
        public bool Varmi { get; set; }

    }
}
