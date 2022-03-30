namespace deneme12.Entity
{
    public class VeliOdeme
    {
        public int Id { get; set; }
        public int VeliId { get; set; }
        public Veli Veli { get; set; }
        public int OdemeID { get; set; }
        public Odeme Odeme { get; set; }
    }
}
