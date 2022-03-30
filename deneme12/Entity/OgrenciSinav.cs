namespace deneme12.Entity
{
    public class OgrenciSinav
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int SinavID { get; set; }
        public Sinav Sinav { get; set; }
    }
}
