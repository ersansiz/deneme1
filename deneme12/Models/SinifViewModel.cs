using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Models
{
    public class SinifViewModel
    {
      
        public int SinifId { get; set; }
        public string SinifName { get; set; }
        public bool Varmi { get; set; }


        public IEnumerable<OgrenciSinif> OgrenciSinif { get; set; }
        public IEnumerable<DerslikSinif> DerslikSinif { get; set; }
    }
}
