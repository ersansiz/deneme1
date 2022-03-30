namespace deneme12.Entity
{
    public class GunSinif
    {
        public int Id { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public int GunID { get; set; }
        public Gun Gun { get; set; }
    }
}
