using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Repostories
{
    public class DersProgramiListRepostory : GenericRepostrory<DersProgramiList>, IDersProgramiListRepostory
    {
        IDersProgamiRepostory _dersProgamiRepostory;
        public DersProgramiListRepostory(IDersProgamiRepostory dersProgamiRepostory)
        {
            _dersProgamiRepostory= dersProgamiRepostory;
        }

        public void EkleSinif(DersProgrami dersProgrami)
        {
            throw new System.NotImplementedException();
        }

        public List<Ders> GetirDers(int dersPrgramiListId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami, dersProgramiList => dersProgramiList.DersProgramiListId,
                dersProgrami => dersProgrami.DersProgramiListId, (u, uc) => new
                {
                    DersProgramiList = u,
                    DersProgrami = uc
                }).Join(context.Ders, iki => iki.DersProgrami.DersId, ders => ders.DersId, (uc, k) => new
                {
                    dersProgramiList = uc.DersProgramiList,
                    ders = k,
                    dersProgrami = uc.DersProgrami
                }).Where(I => I.dersProgrami.DersProgramiListId == dersPrgramiListId).Select(I => new Ders
                {
                    DersName = I.ders.DersName,
                    DersId = I.ders.DersId,

                }).ToList();
        }

        public List<Derslik> GetirDerslik(int dersPrgramiListId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami, dersProgramiList => dersProgramiList.DersProgramiListId,
                dersProgrami => dersProgrami.DersProgramiListId, (u, uc) => new
                {
                    DersProgramiList = u,
                    DersProgrami = uc
                }).Join(context.Dersliks, iki => iki.DersProgrami.DerslikId, derslik => derslik.DerslikId, (uc, k) => new
                {
                    dersProgramiList = uc.DersProgramiList,
                    derslik = k,
                    dersProgrami = uc.DersProgrami
                }).Where(I => I.dersProgrami.DersProgramiListId == dersPrgramiListId).Select(I => new Derslik
                {
                    DerslikName = I.derslik.DerslikName,
                    DerslikId = I.derslik.DerslikId,

                }).ToList();
        }

        public List<DersProgrami> GetirDersProgrami(int dersPrgramiListId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami, dersProgramiList => dersProgramiList.DersProgramiListId,
                dersProgrami => dersProgrami.DersProgramiListId, (u, uc) => new
                {
                    DersProgramiList = u,
                    DersProgrami = uc
                }).Join(context.DersProgrami, iki => iki.DersProgrami.DersId, ders => ders.DersId, (uc, k) => new
                {
                    dersProgramiList = uc.DersProgramiList,
                    ders = k,
                    dersProgrami = uc.DersProgrami
                }).Where(I => I.dersProgrami.DersProgramiListId == dersPrgramiListId).Select(I => new DersProgrami
                {
                    DersProgramiId = I.ders.DersProgramiId
                   

                }).ToList();
        }

        public List<Gun> GetirGun(int dersPrgramiListId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami, dersProgramiList => dersProgramiList.DersProgramiListId,
                dersProgrami => dersProgrami.DersProgramiListId, (u, uc) => new
                {
                    DersProgramiList = u,
                    DersProgrami = uc
                }).Join(context.Gun, iki => iki.DersProgrami.GunId, gun => gun.GunId, (uc, k) => new
                {
                    dersProgramiList = uc.DersProgramiList,
                    gun = k,
                    dersProgrami = uc.DersProgrami
                }).Where(I => I.dersProgrami.DersProgramiListId == dersPrgramiListId).Select(I => new Gun
                {
                    GunName = I.gun.GunName,
                    GunId = I.gun.GunId,

                }).ToList();
        }

     

        public List<Saat> GetirSaat(int dersProgramiListId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami, dersProgramiList => dersProgramiList.DersProgramiListId,
                dersProgrami => dersProgrami.DersProgramiListId, (u, uc) => new
                {
                    DersProgramiList = u,
                    DersProgrami = uc
                }).Join(context.Saat, iki => iki.DersProgrami.SinifId, saat => saat.SaatId, (uc, k) => new
                {
                    dersProgramiList = uc.DersProgramiList,
                    saat = k,
                    dersProgrami = uc.DersProgrami
                }).Where(I => I.dersProgrami.DersProgramiListId == dersProgramiListId).Select(I => new Saat
                {
                    SaatName = I.saat.SaatName,
                    SaatId=I.saat.SaatId


                }).ToList();
        }

        public List<Sinif> GetirSinif(int dersProgramiListId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami, dersProgramiList => dersProgramiList.DersProgramiListId,
                dersProgrami => dersProgrami.DersProgramiListId, (u, uc) => new
                {
                    DersProgramiList = u,
                    DersProgrami = uc
                }).Join(context.Sinif, iki => iki.DersProgrami.SinifId, sinif => sinif.SinifId, (uc, k) => new
                {
                    dersProgramiList = uc.DersProgramiList,
                    sinif = k,
                    dersProgrami = uc.DersProgrami
                }).Where(I => I.dersProgrami.DersProgramiListId == dersProgramiListId).Select(I => new Sinif
                {
                    SinifName = I.sinif.SinifName,
                    SinifId = I.sinif.SinifId,
                    

                }).ToList();
        }

        public List<DersProgramiList> GetirSinifIdile(int sinifId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami,
                u => u.DersProgramiListId, uc => uc.DersProgramiListId, (dersProgramiList, dersProgrami) => new
                {
                    DersProgramiList = dersProgramiList,
                    DersProgrami = dersProgrami
                }).Where(I => I.DersProgrami.SinifId == sinifId).Select(I => new DersProgramiList
                {
                    DersProgramiListId = I.DersProgramiList.DersProgramiListId,
                    DersProgramiListName = I.DersProgramiList.DersProgramiListName

                }).ToList();
        }
        public List<DersProgramiList> GetirGunIdile(int GunId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami,
                u => u.DersProgramiListId, uc => uc.DersProgramiListId, (dersProgramiList, dersProgrami) => new
                {
                    DersProgramiList = dersProgramiList,
                    DersProgrami = dersProgrami
                }).Where(I => I.DersProgrami.GunId == GunId).Select(I => new DersProgramiList
                {
                    DersProgramiListId = I.DersProgramiList.DersProgramiListId,
                    DersProgramiListName = I.DersProgramiList.DersProgramiListName

                }).ToList();
        }

        public void SilSinif(DersProgrami dersProgrami)
        {
            throw new System.NotImplementedException();
        }

        public List<DersProgramiList> GetirDerslikIdile(int DerslikId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami,
                u => u.DersProgramiListId, uc => uc.DersProgramiListId, (dersProgramiList, dersProgrami) => new
                {
                    DersProgramiList = dersProgramiList,
                    DersProgrami = dersProgrami
                }).Where(I => I.DersProgrami.DerslikId == DerslikId).Select(I => new DersProgramiList
                {
                    DersProgramiListId = I.DersProgramiList.DersProgramiListId,
                    DersProgramiListName = I.DersProgramiList.DersProgramiListName

                }).ToList();
        }

        public List<DersProgramiList> GetirDersIdile(int DersId)
        {
            using var context = new AppDbContext();
            return context.DersProgramiList.Join(context.DersProgrami,
                u => u.DersProgramiListId, uc => uc.DersProgramiListId, (dersProgramiList, dersProgrami) => new
                {
                    DersProgramiList = dersProgramiList,
                    DersProgrami = dersProgrami
                }).Where(I => I.DersProgrami.DerslikId == DersId).Select(I => new DersProgramiList
                {
                    DersProgramiListId = I.DersProgramiList.DersProgramiListId,
                    DersProgramiListName = I.DersProgramiList.DersProgramiListName

                }).ToList();
        }
    }
}
