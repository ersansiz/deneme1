using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Entity
{
    public class Sinif
    {
       
        public int SinifId { get; set; }
        public string SinifName { get; set; }
    

        public IEnumerable<OgrenciSinif> OgrenciSinif { get; set; }
        public IEnumerable<DerslikSinif> DerslikSinif { get; set; }
        public List<DersProgrami> DersProgrami { get; set; }
    }
}
