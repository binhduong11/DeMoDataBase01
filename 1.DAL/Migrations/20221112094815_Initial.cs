using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NXB",
                columns: table => new
                {
                    IdNXB = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", type: "nvarchar(max)", nullable: false),
                    TenNXB = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXB", x => x.IdNXB);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    IdSach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", type: "nvarchar(max)", nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.IdSach);
                });

            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    IdTacGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", type: "nvarchar(max)", nullable: false),
                    TenTacGia = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.IdTacGia);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    IdTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", type: "nvarchar(max)", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.IdTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "SachChiTiet",
                columns: table => new
                {
                    IdSachCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNXB = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTacGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    SoTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SachChiTiet", x => x.IdSachCT);
                    table.ForeignKey(
                        name: "FK_SachChiTiet_NXB_IdNXB",
                        column: x => x.IdNXB,
                        principalTable: "NXB",
                        principalColumn: "IdNXB",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SachChiTiet_Sach_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sach",
                        principalColumn: "IdSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SachChiTiet_TacGia_IdTacGia",
                        column: x => x.IdTacGia,
                        principalTable: "TacGia",
                        principalColumn: "IdTacGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SachChiTiet_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "IdTheLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SachChiTiet_IdNXB",
                table: "SachChiTiet",
                column: "IdNXB");

            migrationBuilder.CreateIndex(
                name: "IX_SachChiTiet_IdSach",
                table: "SachChiTiet",
                column: "IdSach");

            migrationBuilder.CreateIndex(
                name: "IX_SachChiTiet_IdTacGia",
                table: "SachChiTiet",
                column: "IdTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_SachChiTiet_IdTheLoai",
                table: "SachChiTiet",
                column: "IdTheLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SachChiTiet");

            migrationBuilder.DropTable(
                name: "NXB");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "TacGia");

            migrationBuilder.DropTable(
                name: "TheLoai");
        }
    }
}
