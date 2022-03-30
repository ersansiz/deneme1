using deneme12.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace deneme12.Models
{
    public class DersProgramiEkleModel
    {
        public int DersProgramiId { get; set; }
        public string Saat { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
        public int GunId { get; set; }
        public Gun Gun { get; set; }
        public int DerslikId { get; set; }
        public Derslik Derslik { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public IEnumerable<SelectListItem> Derslist { get; set; }
        public IEnumerable<SelectListItem> GunList { get; set; }
        public IEnumerable<SelectListItem> DerslikList { get; set; }
        public IEnumerable<SelectListItem> SinifList { get; set; }
    }
}
