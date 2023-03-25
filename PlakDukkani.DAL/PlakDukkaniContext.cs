using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using PlakDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.DAL
{
    public class PlakDukkaniContext :DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Album> Albums { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=PlakDukkaniDB;uid=sa;pwd=123; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().Property(p => p.AlbumAdi).HasMaxLength(150);
            modelBuilder.Entity<Album>().Property(p => p.Sanatci).HasMaxLength(150);
            modelBuilder.Entity<Admin>().Property(p => p.KullaniciAdi).HasMaxLength(50);
            modelBuilder.Entity<Admin>().HasData(
               
                new Admin() {ID = Guid.NewGuid(), CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, KullaniciAdi = "Admin1234", Sifre = "123QWeasd!!" },
                new Admin()
                {
                    ID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    KullaniciAdi = "Admin123456",
                    Sifre = "123QWeasd!!"
                });
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    ID = Guid.NewGuid(),
                    CikisTarihi = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AlbumAdi = "abc",
                    Sanatci = "abc",
                    Fiyat = 100,
                    IndirimOrani = 10,
                    SatisDurumu = true
                },

                new Album()
                {
                    ID = Guid.NewGuid(),
                    CikisTarihi = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AlbumAdi = "Melek",
                    Sanatci = "Melek Melek",
                    Fiyat = 100,
                    IndirimOrani = 10,
                    SatisDurumu = true
                } );

            base.OnModelCreating(modelBuilder);
        }
    }

   
}
