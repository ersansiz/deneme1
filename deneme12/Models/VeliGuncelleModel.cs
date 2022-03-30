using deneme12.Entity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace deneme12.Models
{
    public class VeliGuncelleModel
    {
        public int VeliId { get; set; }
        public string VeliName { get; set; }

        [MaxLength(11)]
        public string VeliTcKimlik { get; set; }

        [MaxLength(11)]
     
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Odeme { get; set; }
        public IFormFile Resim { get; set; }

        public List<Sinif> Sinifs { get; set; }

    }
}
