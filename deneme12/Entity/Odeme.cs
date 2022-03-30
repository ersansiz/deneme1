using System.Collections.Generic;

namespace deneme12.Entity
{
    public class Odeme
    {
        public int OdemeID { get; set; }
        public string OdemeMiktar { get; set; }
        public string Tarih { get; set; }
        public string ÖdeyenTc { get; set; }
        public List<VeliOdeme> VeliOdeme { get; set; }
       

    }
}
