using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface IDersProgramiListRepostory : IGenericRepostory<DersProgramiList>
    {
        List<DersProgramiList> GetirSinifIdile(int SinifId);
        List<DersProgramiList> GetirGunIdile(int GunId);
        List<DersProgramiList> GetirDerslikIdile(int DerslikId);
        List<DersProgramiList> GetirDersIdile(int DersId);

        public List<Sinif> GetirSinif(int dersPrgramiListId);
        public List<Gun> GetirGun(int dersPrgramiListId);
        public List<Saat> GetirSaat(int dersProgramiListId);
        public List<Derslik> GetirDerslik(int dersPrgramiListId);
        public List<Ders> GetirDers(int dersPrgramiListId);
        public List<DersProgrami> GetirDersProgrami(int dersPrgramiListId);
        void EkleSinif(DersProgrami dersProgrami);
        void SilSinif(DersProgrami dersProgrami);   
    }
}
