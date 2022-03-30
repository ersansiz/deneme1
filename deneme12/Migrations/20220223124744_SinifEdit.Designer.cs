﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using deneme12.Context;

namespace deneme12.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220223124744_SinifEdit")]
    partial class SinifEdit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("deneme12.Entity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("deneme12.Entity.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Derslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DersID");

                    b.ToTable("Ders");
                });

            modelBuilder.Entity("deneme12.Entity.Devamsizliz", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SinifName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarih")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Devamsizliz");
                });

            modelBuilder.Entity("deneme12.Entity.Odeme", b =>
                {
                    b.Property<int>("OdemeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OdemeMiktar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ÖdeyenTc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OdemeID");

                    b.ToTable("Odeme");
                });

            modelBuilder.Entity("deneme12.Entity.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OKulName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciTcKimlik")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Sinif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SinifID")
                        .HasColumnType("int");

                    b.Property<string>("Tarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeliName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeliTcKimlik")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("OgrenciID");

                    b.HasIndex("SinifID")
                        .IsUnique();

                    b.ToTable("Ogrenci");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciDers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DersID");

                    b.HasIndex("OgrenciId", "DersID")
                        .IsUnique();

                    b.ToTable("OgrenciDers");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciDevam", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("DevamID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId", "Id")
                        .IsUnique();

                    b.ToTable("OgrenciDevam");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciSinav", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<int>("SinavID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SinavID");

                    b.HasIndex("OgrenciId", "SinavID")
                        .IsUnique();

                    b.ToTable("OgrenciSinav");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciVeli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<int>("VeliID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeliID");

                    b.HasIndex("OgrenciId", "VeliID")
                        .IsUnique();

                    b.ToTable("OgrenciVeli");
                });

            modelBuilder.Entity("deneme12.Entity.Ogretmen", b =>
                {
                    b.Property<int>("OgretmenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birebir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ders")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<string>("OgretmenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenTcKimlik")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Sinif")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgretmenID");

                    b.HasIndex("DersID")
                        .IsUnique();

                    b.ToTable("Ogretmen");
                });

            modelBuilder.Entity("deneme12.Entity.OgretmenSinif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DevamsizlizID")
                        .HasColumnType("int");

                    b.Property<int>("OgretmenId")
                        .HasColumnType("int");

                    b.Property<int>("SinifID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DevamsizlizID");

                    b.HasIndex("SinifID");

                    b.HasIndex("OgretmenId", "SinifID")
                        .IsUnique();

                    b.ToTable("OgretmenSinif");
                });

            modelBuilder.Entity("deneme12.Entity.Sinav", b =>
                {
                    b.Property<int>("SinavID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Derslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dogru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yanlis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SinavID");

                    b.ToTable("Sinav");
                });

            modelBuilder.Entity("deneme12.Entity.Sinif", b =>
                {
                    b.Property<int>("SinifID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Derslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SinifName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SinifID");

                    b.ToTable("Sinif");
                });

            modelBuilder.Entity("deneme12.Entity.Veli", b =>
                {
                    b.Property<int>("VeliID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Odeme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciTcKimlik")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeliName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeliTcKimlik")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("VeliID");

                    b.ToTable("Veli");
                });

            modelBuilder.Entity("deneme12.Entity.VeliOdeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OdemeID")
                        .HasColumnType("int");

                    b.Property<int>("VeliId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OdemeID");

                    b.HasIndex("VeliId", "OdemeID")
                        .IsUnique();

                    b.ToTable("VeliOdeme");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("deneme12.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("deneme12.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme12.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("deneme12.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("deneme12.Entity.Ogrenci", b =>
                {
                    b.HasOne("deneme12.Entity.Sinif", "Sinifs")
                        .WithOne("Ogrenci")
                        .HasForeignKey("deneme12.Entity.Ogrenci", "SinifID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinifs");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciDers", b =>
                {
                    b.HasOne("deneme12.Entity.Ders", "Ders")
                        .WithMany("OgrenciDers")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme12.Entity.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDers")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciDevam", b =>
                {
                    b.HasOne("deneme12.Entity.Devamsizliz", "Devamsizliz")
                        .WithMany("OgrenciDevam")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme12.Entity.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDevam")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Devamsizliz");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciSinav", b =>
                {
                    b.HasOne("deneme12.Entity.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciSinav")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme12.Entity.Sinav", "Sinav")
                        .WithMany("OgrenciSinav")
                        .HasForeignKey("SinavID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");

                    b.Navigation("Sinav");
                });

            modelBuilder.Entity("deneme12.Entity.OgrenciVeli", b =>
                {
                    b.HasOne("deneme12.Entity.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciVelis")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme12.Entity.Veli", "Veli")
                        .WithMany("OgrenciVelis")
                        .HasForeignKey("VeliID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");

                    b.Navigation("Veli");
                });

            modelBuilder.Entity("deneme12.Entity.Ogretmen", b =>
                {
                    b.HasOne("deneme12.Entity.Ders", "Derss")
                        .WithOne("Ogretmen")
                        .HasForeignKey("deneme12.Entity.Ogretmen", "DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Derss");
                });

            modelBuilder.Entity("deneme12.Entity.OgretmenSinif", b =>
                {
                    b.HasOne("deneme12.Entity.Devamsizliz", null)
                        .WithMany("OgretmenSinif")
                        .HasForeignKey("DevamsizlizID");

                    b.HasOne("deneme12.Entity.Ogretmen", "Ogretmen")
                        .WithMany("OgretmenSinif")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme12.Entity.Sinif", "Sinif")
                        .WithMany("OgretmenSinif")
                        .HasForeignKey("SinifID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogretmen");

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("deneme12.Entity.VeliOdeme", b =>
                {
                    b.HasOne("deneme12.Entity.Odeme", "Odeme")
                        .WithMany("VeliOdeme")
                        .HasForeignKey("OdemeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deneme12.Entity.Veli", "Veli")
                        .WithMany("VeliOdeme")
                        .HasForeignKey("VeliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Odeme");

                    b.Navigation("Veli");
                });

            modelBuilder.Entity("deneme12.Entity.Ders", b =>
                {
                    b.Navigation("OgrenciDers");

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("deneme12.Entity.Devamsizliz", b =>
                {
                    b.Navigation("OgrenciDevam");

                    b.Navigation("OgretmenSinif");
                });

            modelBuilder.Entity("deneme12.Entity.Odeme", b =>
                {
                    b.Navigation("VeliOdeme");
                });

            modelBuilder.Entity("deneme12.Entity.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDers");

                    b.Navigation("OgrenciDevam");

                    b.Navigation("OgrenciSinav");

                    b.Navigation("OgrenciVelis");
                });

            modelBuilder.Entity("deneme12.Entity.Ogretmen", b =>
                {
                    b.Navigation("OgretmenSinif");
                });

            modelBuilder.Entity("deneme12.Entity.Sinav", b =>
                {
                    b.Navigation("OgrenciSinav");
                });

            modelBuilder.Entity("deneme12.Entity.Sinif", b =>
                {
                    b.Navigation("Ogrenci");

                    b.Navigation("OgretmenSinif");
                });

            modelBuilder.Entity("deneme12.Entity.Veli", b =>
                {
                    b.Navigation("OgrenciVelis");

                    b.Navigation("VeliOdeme");
                });
#pragma warning restore 612, 618
        }
    }
}
