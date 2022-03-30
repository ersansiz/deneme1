using System.Collections.Generic;

namespace deneme12.Entity
{
    public class DersProgramiList
    {
        public int DersProgramiListId { get; set; }
        
        public string DersProgramiListName { get; set; }
        public List<DersProgrami> DersProgrami { get; set; }
    }
}
