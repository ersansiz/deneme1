using System.Collections.Generic;

namespace deneme12.Entity
{
    public class Sinav
    {
        public int SinavID { get; set; }
        public string Tarih { get; set; }
        public string DersName { get; set; }
        public string Derslik { get; set; }
        public string OgrenciName { get; set; }
        public string Dogru { get; set; }
        public string Yanlis { get; set; }
        public List<OgrenciSinav> OgrenciSinav { get; set; }
    }
}
