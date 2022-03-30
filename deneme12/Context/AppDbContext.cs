using deneme12.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace deneme12.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O85AGKQ\\SQLEXPRESS; Database=Deneme12; Trusted_Connection=True; MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
       
        modelBuilder.Entity<Ders>().HasMany(I => I.OgrenciDers).WithOne(I => I.Ders).HasForeignKey(I => I.DersID);
            modelBuilder.Entity<Ogrenci>().HasMany(I => I.OgrenciDers).WithOne(I => I.Ogrenci).HasForeignKey(I => I.OgrenciId);
            modelBuilder.Entity<OgrenciDers>().HasIndex(I => new
            {
                I.OgrenciId,
                I.DersID
            }).IsUnique();
           modelBuilder.Entity<Veli>().HasMany(I => I.OgrenciVeli).WithOne(I => I.Veli).HasForeignKey(I => I.VeliID);
            modelBuilder.Entity<Ogrenci>().HasMany(I => I.OgrenciVeli).WithOne(I => I.Ogrenci).HasForeignKey(I => I.OgrenciId);
            modelBuilder.Entity<OgrenciVeli>().HasIndex(I => new
            {
                I.OgrenciId,
                I.VeliID
            }).IsUnique();

            modelBuilder.Entity<Sinav>().HasMany(I => I.OgrenciSinav).WithOne(I => I.Sinav).HasForeignKey(I => I.SinavID);
            modelBuilder.Entity<Ogrenci>().HasMany(I => I.OgrenciSinav).WithOne(I => I.Ogrenci).HasForeignKey(I => I.OgrenciId);
            modelBuilder.Entity<OgrenciSinav>().HasIndex(I => new
            {
                I.OgrenciId,
                I.SinavID
            }).IsUnique();

            modelBuilder.Entity<Devamsizliz>().HasMany(I => I.OgrenciDevam).WithOne(I => I.Devamsizliz).HasForeignKey(I => I.Id);
            modelBuilder.Entity<Ogrenci>().HasMany(I => I.OgrenciDevam).WithOne(I => I.Ogrenci).HasForeignKey(I => I.OgrenciId);
            modelBuilder.Entity<OgrenciDevam>().HasIndex(I => new
            {
                I.OgrenciId,
                I.Id
            }).IsUnique();


            modelBuilder.Entity<Ogretmen>().HasMany(I => I.OgretmenSinif).WithOne(I => I.Ogretmen).HasForeignKey(I => I.OgretmenId);
            modelBuilder.Entity<Sinif>().HasMany(I => I.OgrenciSinif).WithOne(I => I.Sinif).HasForeignKey(I => I.SinifID);
            modelBuilder.Entity<OgretmenSinif>().HasIndex(I => new
            {
                I.OgretmenId,
                I.SinifID
            }).IsUnique();

            modelBuilder.Entity<Veli>().HasMany(I => I.VeliOdeme).WithOne(I => I.Veli).HasForeignKey(I => I.VeliId);
            modelBuilder.Entity<Odeme>().HasMany(I => I.VeliOdeme).WithOne(I => I.Odeme).HasForeignKey(I => I.OdemeID);
            modelBuilder.Entity<VeliOdeme>().HasIndex(I => new
            {
                I.VeliId,
                I.OdemeID
            }).IsUnique();

        


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Devamsizliz> Devamsizliz { get; set; }
        public DbSet<Odeme> Odeme { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
        public DbSet<OgrenciDevam> OgrenciDevam { get; set; }
        public DbSet<OgrenciSinav> OgrenciSinav { get; set; }
        public DbSet<OgrenciSinif> OgrenciSinif { get; set; }
        public DbSet<OgrenciVeli> OgrenciVeli { get; set; }
        public DbSet<Ogretmen> Ogretmen { get; set; }
        public DbSet<OgretmenSinif> OgretmenSinif { get; set; }
        public DbSet<Sinav> Sinav { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<Veli> Veli { get; set; }
        public DbSet<Gun> Gun { get; set; }
        public DbSet<Saat> Saat { get; set; }
        public DbSet<GunSinif> GunSinif { get; set; }
        public DbSet<Derslik> Dersliks { get; set; }
        public DbSet<DerslikSinif> DerslikSinif { get; set; }
        public DbSet<VeliOdeme> VeliOdeme { get; set; }
        public DbSet<SinifDers> SinifDers { get; set; }
        public DbSet<DersProgrami> DersProgrami { get; set; }
        
        public DbSet<DersProgramiList> DersProgramiList{ get; set; }

    }
}
