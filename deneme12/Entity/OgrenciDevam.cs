namespace deneme12.Entity
{
    public class OgrenciDevam
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int DevamID { get; set; }
        public Devamsizliz Devamsizliz { get; set; }
    }
}
