using deneme12.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace deneme12.Repostories
{
    public class GenericRepostrory<Tablo> where Tablo : class, new()
    {
        public void Ekle(Tablo tablo)
        {
            using var context = new AppDbContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }
        public void Güncelle(Tablo tablo)
        {
            using var context = new AppDbContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }
        public void Sil(Tablo tablo)
        {
            using var context = new AppDbContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
        public List<Tablo> GetirHepsi()
        {
            using var context = new AppDbContext();
            return context.Set<Tablo>().ToList();
        }
        public Tablo GetirIdile(int Id)
        {
            using var context = new AppDbContext();
            return context.Set<Tablo>().Find(Id);
        }
        public List<Tablo> List(Expression<Func<Tablo,bool>>filter)
        {
            using var context = new AppDbContext();
            return context.Set<Tablo>().Where(filter).ToList();
        }
    }
}

