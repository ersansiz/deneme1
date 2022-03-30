using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.ViewModels
{
    public class DersProgramiListVm
    {
        public List<DersProgramiList> DersProgramiList { get; set; }
        public List<DersProgrami> DersProgrami { get; set; }
        public List<Ders> Ders { get; set; }


        public List<Gun> Gun { get; set; }

        public List<Derslik> Derslik { get; set; }

        public List<Sinif> Sinif { get; set; }

    }
}
