// <auto-generated />
using System;
using DenemeWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DenemeWeb.Migrations
{
    [DbContext(typeof(You2DataContext))]
    partial class You2DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DenemeWeb.Dto.KategoriReadDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Kategori1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KategoriReadDto");
                });

            modelBuilder.Entity("DenemeWeb.Dto.KategoritoYemekReadDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("RestoranAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestoranId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KategoritoYemekReadDto");
                });

            modelBuilder.Entity("DenemeWeb.Models.Degerlendirme", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int")
                        .HasColumnName("musteriID");

                    b.Property<short?>("Puan")
                        .HasColumnType("smallint")
                        .HasColumnName("puan");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int")
                        .HasColumnName("siparisID");

                    b.Property<string>("Yorum")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("yorum");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.HasIndex("SiparisId");

                    b.ToTable("Degerlendirme", (string)null);
                });

            modelBuilder.Entity("DenemeWeb.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Kategori1")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("kategori")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Kategori", (string)null);
                });

            modelBuilder.Entity("DenemeWeb.Models.Kurye", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("KuryeAd")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("kuryeAD")
                        .IsFixedLength();

                    b.Property<string>("KuryeSoyad")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("kuryeSOYAD")
                        .IsFixedLength();

                    b.Property<int?>("KuryeYas")
                        .HasColumnType("int")
                        .HasColumnName("kuryeYAS");

                    b.HasKey("Id");

                    b.ToTable("Kurye", (string)null);
                });

            modelBuilder.Entity("DenemeWeb.Models.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)")
                        .IsFixedLength();

                    b.Property<int?>("SehirId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("SehirID");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Musteri", (string)null);
                });

            modelBuilder.Entity("DenemeWeb.Models.Restoran", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Ad")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("ad")
                        .IsFixedLength();

                    b.Property<string>("Adres")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("adres")
                        .IsFixedLength();

                    b.Property<int?>("Restoranpuan")
                        .HasColumnType("int")
                        .HasColumnName("restoranpuan");

                    b.Property<int>("SehirId")
                        .HasColumnType("int")
                        .HasColumnName("sehirID");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Restoran", (string)null);
                });

            modelBuilder.Entity("DenemeWeb.Models.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("SehirAd")
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)")
                        .HasColumnName("sehirAD")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Sehir", (string)null);
                });

            modelBuilder.Entity("DenemeWeb.Models.Sipari", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int?>("Adet")
                        .HasColumnType("int")
                        .HasColumnName("adet");

                    b.Property<int>("KuryeId")
                        .HasColumnType("int")
                        .HasColumnName("kuryeID");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int")
                        .HasColumnName("musteriID");

                    b.Property<DateTime?>("Tarih")
                        .HasColumnType("date")
                        .HasColumnName("tarih");

                    b.Property<string>("Teslimatdurumu")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("teslimatdurumu");

                    b.Property<int?>("Tutar")
                        .HasColumnType("int")
                        .HasColumnName("tutar");

                    b.Property<int>("YemekId")
                        .HasColumnType("int")
                        .HasColumnName("yemekID");

                    b.HasKey("Id");

                    b.HasIndex("KuryeId");

                    b.HasIndex("MusteriId");

                    b.HasIndex("YemekId");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("DenemeWeb.Models.Yemek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("ad")
                        .IsFixedLength();

                    b.Property<double?>("Fiyat")
                        .HasColumnType("float")
                        .HasColumnName("fiyat");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int")
                        .HasColumnName("kategoriID");

                    b.Property<int>("RestoranId")
                        .HasColumnType("int")
                        .HasColumnName("restoranID");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("RestoranId");

                    b.ToTable("Yemek", (string)null);
                });

            modelBuilder.Entity("DenemeWeb.Models.Degerlendirme", b =>
                {
                    b.HasOne("DenemeWeb.Models.Musteri", "Musteri")
                        .WithMany("Degerlendirmes")
                        .HasForeignKey("MusteriId")
                        .IsRequired()
                        .HasConstraintName("FK_Degerlendirme_ToMusteri");

                    b.HasOne("DenemeWeb.Models.Sipari", "Siparis")
                        .WithMany("Degerlendirmes")
                        .HasForeignKey("SiparisId")
                        .IsRequired()
                        .HasConstraintName("FK_Degerlendirme_ToSiparis");

                    b.Navigation("Musteri");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("DenemeWeb.Models.Musteri", b =>
                {
                    b.HasOne("DenemeWeb.Models.Sehir", "Sehir")
                        .WithMany("Musteris")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Musteri_ToSehir");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("DenemeWeb.Models.Restoran", b =>
                {
                    b.HasOne("DenemeWeb.Models.Sehir", "Sehir")
                        .WithMany("Restorans")
                        .HasForeignKey("SehirId")
                        .IsRequired()
                        .HasConstraintName("FK_Restoran_ToSehir");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("DenemeWeb.Models.Sipari", b =>
                {
                    b.HasOne("DenemeWeb.Models.Kurye", "Kurye")
                        .WithMany("Siparis")
                        .HasForeignKey("KuryeId")
                        .IsRequired()
                        .HasConstraintName("FK_Siparis_ToKurye");

                    b.HasOne("DenemeWeb.Models.Musteri", "Musteri")
                        .WithMany("Siparis")
                        .HasForeignKey("MusteriId")
                        .IsRequired()
                        .HasConstraintName("FK_Siparis_ToMusteri");

                    b.HasOne("DenemeWeb.Models.Yemek", "Yemek")
                        .WithMany("Siparis")
                        .HasForeignKey("YemekId")
                        .IsRequired()
                        .HasConstraintName("FK_Siparis_ToYemek");

                    b.Navigation("Kurye");

                    b.Navigation("Musteri");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("DenemeWeb.Models.Yemek", b =>
                {
                    b.HasOne("DenemeWeb.Models.Kategori", "Kategori")
                        .WithMany("Yemeks")
                        .HasForeignKey("KategoriId")
                        .IsRequired()
                        .HasConstraintName("FK_Yemek_ToKategori");

                    b.HasOne("DenemeWeb.Models.Restoran", "Restoran")
                        .WithMany("Yemeks")
                        .HasForeignKey("RestoranId")
                        .IsRequired()
                        .HasConstraintName("FK_Yemek_ToRestoran");

                    b.Navigation("Kategori");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("DenemeWeb.Models.Kategori", b =>
                {
                    b.Navigation("Yemeks");
                });

            modelBuilder.Entity("DenemeWeb.Models.Kurye", b =>
                {
                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("DenemeWeb.Models.Musteri", b =>
                {
                    b.Navigation("Degerlendirmes");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("DenemeWeb.Models.Restoran", b =>
                {
                    b.Navigation("Yemeks");
                });

            modelBuilder.Entity("DenemeWeb.Models.Sehir", b =>
                {
                    b.Navigation("Musteris");

                    b.Navigation("Restorans");
                });

            modelBuilder.Entity("DenemeWeb.Models.Sipari", b =>
                {
                    b.Navigation("Degerlendirmes");
                });

            modelBuilder.Entity("DenemeWeb.Models.Yemek", b =>
                {
                    b.Navigation("Siparis");
                });
#pragma warning restore 612, 618
        }
    }
}
