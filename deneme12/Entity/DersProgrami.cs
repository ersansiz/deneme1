using System.Collections.Generic;

namespace deneme12.Entity
{
    public class DersProgrami
    {
        public int DersProgramiId { get; set; }
    
        public int DersProgramiListId { get; set; }
        public DersProgramiList DersProgramiList { get; set; }

        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public int SaatId { get; set; }
        public Saat Saat { get; set; }

        public int GunId { get; set; }
        public Gun Gun { get; set; }

        public int DerslikId { get; set; }
        public Derslik Derslik { get; set; }

        public int DersId { get; set; }
        public Ders Ders { get; set; }

    }
}
