using deneme12.Entity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace deneme12.Models
{
    public class VeliEkleModel
    {
        public int VeliID { get; set; }
        public string VeliName { get; set; }

        [MaxLength(11)]
        public string VeliTcKimlik { get; set; }

       
     
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Odeme { get; set; }

        public IFormFile Resim { get; set; }

        public List<OgrenciVeli> OgrenciVelis { get; set; }
        public List<VeliOdeme> VeliOdeme { get; set; }
    }
}
