using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Models
{
    public class DersProgramiModel
    {
        public int DersProgramiId { get; set; }
        public string Saat { get; set; }
        
       
        public List<Ders> Ders { get; set; }
        public List<Gun> Gun { get; set; }
        public List<Derslik> Derslik { get; set; }
        public List<Sinif> Sinif { get; set; }
    }
}
