using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Models
{
    public class VeliAtaModel
    {
        public int VeliId { get; set; }
        public string VeliName { get; set; }
        public IEnumerable<Ogrenci> Ogrenci { get; set; }
        public IEnumerable<Veli> Veli { get; set; }
    }
}
