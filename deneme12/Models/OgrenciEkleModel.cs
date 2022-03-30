using deneme12.Entity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace deneme12.Models
{
    public class OgrenciEkleModel
    {
        public string OgrenciName { get; set; }

        [MaxLength(11)]
        public string OgrenciTcKimlik { get; set; }

        [MaxLength(11)]
        public string VeliTcKimlik { get; set; }
        public string VeliName { get; set; }
        public string Sinif { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Tarih { get; set; }
        public string OKulName { get; set; }
        public IFormFile Resim { get; set; }
        public List<Sinif> sinifs { get; set; }
    }
}
