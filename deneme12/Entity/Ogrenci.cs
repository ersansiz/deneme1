using deneme12.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme12.Entity
{
    [Dapper.Contrib.Extensions.Table("Ogrenci")]
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string OgrenciName { get; set; }

        [MaxLength(11)]
        public string OgrenciTcKimlik{ get; set; }

        [MaxLength (11)]
      
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Resim { get; set; }
        public string Tarih { get; set; }
        public string OKulName{ get; set; }
        public IEnumerable<OgrenciVeli> OgrenciVeli { get; set; }
        public List<OgrenciDers> OgrenciDers { get; set; }
        public List<OgrenciSinav> OgrenciSinav { get; set; }
        public List<OgrenciDevam> OgrenciDevam { get; set; }

        public IEnumerable<OgrenciSinif> OgrenciSinif { get; set; }
    }
}
