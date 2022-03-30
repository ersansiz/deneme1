namespace deneme12.Entity
{
    public class DerslikSinif
    {
        public int Id { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public int DerslikID { get; set; }
        public Derslik Derslik { get; set; }
    }
}
