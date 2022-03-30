namespace deneme12.Entity
{
    public class OgretmenSinif
    {
        public int Id { get; set; }
        public int OgretmenId { get; set; }
        public Ogretmen Ogretmen { get; set; }
        public int SinifID { get; set; }
        public Sinif Sinif { get; set; }
    }
}
