using System.Collections.Generic;

namespace deneme12.Entity
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersName { get; set; }
        
        public List<OgrenciDers> OgrenciDers { get; set; }
        public List<DersProgrami> DersProgrami { get; set; }
        public Ogretmen Ogretmen { get; set; }
    }
}
