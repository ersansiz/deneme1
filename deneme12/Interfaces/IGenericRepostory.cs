using deneme12.Entity;
using System.Collections.Generic;

namespace deneme12.Interfaces
{
    public interface IGenericRepostory<Tablo> where Tablo : class,new ()
    {
         void Ekle(Tablo tablo);
         void Sil(Tablo tablo);
         void Güncelle(Tablo tablo);
        public List<Tablo> GetirHepsi();
     
        public Tablo GetirIdile(int Id);
        
    }
}
