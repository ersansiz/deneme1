using deneme12.Entity;

namespace deneme12.Models
{
    public class DersprogramiAtaModel
    {
        public int DersProgramiListId { get; set; }
        public string Saat { get; set; }
        public DersProgramiList DersProgramiList { get; set; }
        public int SinifId { get; set; }
        public string SinifName { get; set; }
        public Sinif Sinif { get; set; }
        public int GunId { get; set; }
        public string GunName { get; set; }
        public Gun Gun { get; set; }
        public int DerslikId { get; set; }
        public string DerslikName { get; set; }
        public Derslik Derslik { get; set; }
        public int DersId { get; set; }
        public string DersName { get; set; }
        public Ders Ders { get; set; }

    }
}
