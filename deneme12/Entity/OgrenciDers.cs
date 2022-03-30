namespace deneme12.Entity
{
    public class OgrenciDers
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int DersID { get; set; }
        public Ders Ders { get; set; }
    }
}
