using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace deneme12.Entity
{
    public class Veli
    {
        public int VeliID { get; set; }
        public string VeliName { get; set; }

        [MaxLength(11)]
        public string VeliTcKimlik { get; set; }

        [MaxLength(11)]
       
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Odeme { get; set; }
        public string Resim { get; set; }

        public IEnumerable<OgrenciVeli> OgrenciVeli { get; set; }
        public List<VeliOdeme> VeliOdeme { get; set; }

    }
}
