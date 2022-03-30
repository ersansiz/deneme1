using System.Collections.Generic;

namespace deneme12.Entity
{
    public class Devamsizliz
    {
        public int ID { get; set; }
        public string Tarih { get; set; }
        public string DersName { get; set; }
        public string SinifName { get; set; }
        public string OgretmenName { get; set; }
        public string OgrenciName { get; set; }
        public List<OgretmenSinif> OgretmenSinif { get; set; }
        public List<OgrenciDevam> OgrenciDevam { get; set; }
    }
}
