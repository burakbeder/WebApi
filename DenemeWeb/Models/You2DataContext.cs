using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DenemeWeb.Dto;

namespace DenemeWeb.Models
{
    public partial class You2DataContext : DbContext
    {
        public You2DataContext()
        {
        }

        public You2DataContext(DbContextOptions<You2DataContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Category> Kategoris { get; set; } = null!;
        public virtual DbSet<Courier> Kuryes { get; set; } = null!;
        public virtual DbSet<Customer> Musteris { get; set; } = null!;
        public virtual DbSet<OrderDetails> SiparisDetay { get; set; } = null!;
        public virtual DbSet<Order> Siparis { get; set; } = null!;
        public virtual DbSet<Product> Yemeks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-94IOJN0;Initial Catalog=You2Data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Kategori");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Kategori1)
                    .HasMaxLength(10)
                    .HasColumnName("kategori")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Courier>(entity =>
            {
                entity.ToTable("Kurye");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.KuryeAd)
                    .HasMaxLength(10)
                    .HasColumnName("kuryeAD")
                    .IsFixedLength();

                entity.Property(e => e.KuryeSoyad)
                    .HasMaxLength(10)
                    .HasColumnName("kuryeSOYAD")
                    .IsFixedLength();

                entity.Property(e => e.KuryeYas).HasColumnName("kuryeYAS");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Musteri");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsFixedLength();
              
                entity.Property(e => e.Soyad)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sifre)
                  .HasMaxLength(50)
                  .IsFixedLength();


            });


            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.ToTable("SiparisDetay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SiparisId).HasColumnName("SiparisId");

                entity.Property(e => e.YemekId).HasColumnName("YemekId");

                entity.Property(e => e.Adet).HasColumnName("Adet");
                entity.Property(e => e.Tutar).HasColumnName("Tutar");


                entity.HasOne(d => d.Siparis)
                    .WithMany(p => p.SiparisDetay)
                    .HasForeignKey(d => d.SiparisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiparisDetay_ToSiparis");

                entity.HasOne(d => d.Yemeks)
                    .WithMany(p => p.SiparisDetay)
                    .HasForeignKey(d => d.YemekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiparisDetay_ToYemek");

            });


            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.KuryeId).HasColumnName("kuryeID");

                entity.Property(e => e.MusteriId).HasColumnName("musteriID");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("tarih");

                entity.Property(e => e.Teslimatdurumu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("teslimatdurumu");

                entity.Property(e => e.Tutar).HasColumnName("tutar");

               

                entity.HasOne(d => d.Kurye)
                    .WithMany(p => p.Siparis)
                    .HasForeignKey(d => d.KuryeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Siparis_ToKurye");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.Siparis)
                    .HasForeignKey(d => d.MusteriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Siparis_ToMusteri");

 
            });

          

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Yemek");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ad)
                    .HasMaxLength(10)
                    .HasColumnName("ad")
                    .IsFixedLength();

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.KategoriId).HasColumnName("kategoriID");
           

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Yemeks)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yemek_ToKategori");

              
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<DenemeWeb.Dto.CategoryReadDto>? CategoryReadDto { get; set; }

        public DbSet<DenemeWeb.Dto.OrderReadDto>? OrderReadDto { get; set; }

        public DbSet<DenemeWeb.Dto.CustomerReadDto>? CustomerReadDto { get; set; }
       
      

    }
}
