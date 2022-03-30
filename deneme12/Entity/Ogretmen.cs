using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme12.Entity
{
    public class Ogretmen
    {
        public int OgretmenID { get; set; }
        public string OgretmenName { get; set; }

        [MaxLength(11)]
        public string OgretmenTcKimlik { get; set; }
        public string Ders { get; set; }
        public string Sinif { get; set; }
        public string Birebir { get; set; }
        public List<OgretmenSinif> OgretmenSinif { get; set; }
        [ForeignKey("Ders")]
        public int DersID { get; set; }
        public Ders Derss { get; set; }

    }
}
