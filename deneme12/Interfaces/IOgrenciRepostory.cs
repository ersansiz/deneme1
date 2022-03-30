using deneme12.Entity;
using deneme12.Repostories;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface IOgrenciRepostory: IGenericRepostory<Ogrenci>
    {
        List<Sinif> GetirSinif(int ogrenciId);
        List<Veli> GetirVeli(int ogrenciId);
        void Ekle(OgrenciSinif OgrenciSinif);
        void SilSinif(OgrenciSinif OgrenciSinif);
        void GuncelleSinif(OgrenciSinif OgrenciSinif);
        List<Ogrenci> GetirSinifIdile(int SinifId);
       


    }
}
