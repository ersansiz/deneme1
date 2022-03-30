namespace deneme12.Entity
{
    public class SinifDers
    {
        public int Id { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
