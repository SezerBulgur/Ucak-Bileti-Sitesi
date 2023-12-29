using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcakBiletiSitesi.Migrations
{
    /// <inheritdoc />
    public partial class yeniden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Havaalanlari",
                columns: table => new
                {
                    HavaalaniId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HavaalaniAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Havaalanlari", x => x.HavaalaniId);
                });

            migrationBuilder.CreateTable(
                name: "Ucaklar",
                columns: table => new
                {
                    UcakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucaklar", x => x.UcakId);
                });

            migrationBuilder.CreateTable(
                name: "Yolcular",
                columns: table => new
                {
                    YolcuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yolcular", x => x.YolcuId);
                });

            migrationBuilder.CreateTable(
                name: "Ucuslar",
                columns: table => new
                {
                    UcusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UcusNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UcakId = table.Column<int>(type: "int", nullable: false),
                    NeredenHavaalaniId = table.Column<int>(type: "int", nullable: false),
                    NereyeHavaalaniId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucuslar", x => x.UcusId);
                    table.ForeignKey(
                        name: "FK_Ucuslar_Havaalanlari_NeredenHavaalaniId",
                        column: x => x.NeredenHavaalaniId,
                        principalTable: "Havaalanlari",
                        principalColumn: "HavaalaniId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ucuslar_Havaalanlari_NereyeHavaalaniId",
                        column: x => x.NereyeHavaalaniId,
                        principalTable: "Havaalanlari",
                        principalColumn: "HavaalaniId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ucuslar_Ucaklar_UcakId",
                        column: x => x.UcakId,
                        principalTable: "Ucaklar",
                        principalColumn: "UcakId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Biletler",
                columns: table => new
                {
                    BiletId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YolcuId = table.Column<int>(type: "int", nullable: false),
                    UcusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biletler", x => x.BiletId);
                    table.ForeignKey(
                        name: "FK_Biletler_Ucuslar_UcusId",
                        column: x => x.UcusId,
                        principalTable: "Ucuslar",
                        principalColumn: "UcusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Biletler_Yolcular_YolcuId",
                        column: x => x.YolcuId,
                        principalTable: "Yolcular",
                        principalColumn: "YolcuId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_UcusId",
                table: "Biletler",
                column: "UcusId");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_YolcuId",
                table: "Biletler",
                column: "YolcuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ucuslar_NeredenHavaalaniId",
                table: "Ucuslar",
                column: "NeredenHavaalaniId");

            migrationBuilder.CreateIndex(
                name: "IX_Ucuslar_NereyeHavaalaniId",
                table: "Ucuslar",
                column: "NereyeHavaalaniId");

            migrationBuilder.CreateIndex(
                name: "IX_Ucuslar_UcakId",
                table: "Ucuslar",
                column: "UcakId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biletler");

            migrationBuilder.DropTable(
                name: "Ucuslar");

            migrationBuilder.DropTable(
                name: "Yolcular");

            migrationBuilder.DropTable(
                name: "Havaalanlari");

            migrationBuilder.DropTable(
                name: "Ucaklar");
        }
    }
}
