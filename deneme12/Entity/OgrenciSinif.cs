namespace deneme12.Entity
{
    public class OgrenciSinif
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int SinifID { get; set; }
        public Sinif Sinif { get; set; }
    }
}
