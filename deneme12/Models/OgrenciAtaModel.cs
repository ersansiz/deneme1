using deneme12.Entity;
using System.Collections;
using System.Collections.Generic;

namespace deneme12.Models
{
    public class OgrenciAtaModel
    {
        public int SinifId { get; set; }
        public string SinifName { get; set; }
        public IEnumerable<Ogrenci> Ogrenci { get; set; }
        public IEnumerable<Sinif> Sinif { get; set; }
        public IEnumerable<Veli> Veli { get; set; }
        public IEnumerable<OgrenciVeli> OgrenciVeli { get; set; }
        public bool Varmi { get; set; }

    }
}
