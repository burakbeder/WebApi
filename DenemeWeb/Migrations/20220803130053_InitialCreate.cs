using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenemeWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    kategori = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KategoriReadDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategori1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriReadDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KategoritoYemekReadDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestoranId = table.Column<int>(type: "int", nullable: false),
                    RestoranAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoritoYemekReadDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kurye",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    kuryeAD = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    kuryeSOYAD = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    kuryeYAS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurye", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sehir",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    sehirAD = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehir", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Soyad = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: false),
                    SehirID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Musteri_ToSehir",
                        column: x => x.SehirID,
                        principalTable: "Sehir",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restoran",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    adres = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    restoranpuan = table.Column<int>(type: "int", nullable: true),
                    sehirID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restoran", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Restoran_ToSehir",
                        column: x => x.sehirID,
                        principalTable: "Sehir",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Yemek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    fiyat = table.Column<double>(type: "float", nullable: true),
                    kategoriID = table.Column<int>(type: "int", nullable: false),
                    restoranID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yemek_ToKategori",
                        column: x => x.kategoriID,
                        principalTable: "Kategori",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Yemek_ToRestoran",
                        column: x => x.restoranID,
                        principalTable: "Restoran",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Siparis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    tarih = table.Column<DateTime>(type: "date", nullable: true),
                    adet = table.Column<int>(type: "int", nullable: true),
                    tutar = table.Column<int>(type: "int", nullable: true),
                    yemekID = table.Column<int>(type: "int", nullable: false),
                    teslimatdurumu = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    musteriID = table.Column<int>(type: "int", nullable: false),
                    kuryeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Siparis_ToKurye",
                        column: x => x.kuryeID,
                        principalTable: "Kurye",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Siparis_ToMusteri",
                        column: x => x.musteriID,
                        principalTable: "Musteri",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Siparis_ToYemek",
                        column: x => x.yemekID,
                        principalTable: "Yemek",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Degerlendirme",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    yorum = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    puan = table.Column<short>(type: "smallint", nullable: true),
                    siparisID = table.Column<int>(type: "int", nullable: false),
                    musteriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degerlendirme", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Degerlendirme_ToMusteri",
                        column: x => x.musteriID,
                        principalTable: "Musteri",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Degerlendirme_ToSiparis",
                        column: x => x.siparisID,
                        principalTable: "Siparis",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirme_musteriID",
                table: "Degerlendirme",
                column: "musteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirme_siparisID",
                table: "Degerlendirme",
                column: "siparisID");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_SehirID",
                table: "Musteri",
                column: "SehirID");

            migrationBuilder.CreateIndex(
                name: "IX_Restoran_sehirID",
                table: "Restoran",
                column: "sehirID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_kuryeID",
                table: "Siparis",
                column: "kuryeID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_musteriID",
                table: "Siparis",
                column: "musteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparis_yemekID",
                table: "Siparis",
                column: "yemekID");

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_kategoriID",
                table: "Yemek",
                column: "kategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_restoranID",
                table: "Yemek",
                column: "restoranID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Degerlendirme");

            migrationBuilder.DropTable(
                name: "KategoriReadDto");

            migrationBuilder.DropTable(
                name: "KategoritoYemekReadDto");

            migrationBuilder.DropTable(
                name: "Siparis");

            migrationBuilder.DropTable(
                name: "Kurye");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Yemek");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Restoran");

            migrationBuilder.DropTable(
                name: "Sehir");
        }
    }
}
