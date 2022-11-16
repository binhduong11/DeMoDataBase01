using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class Applied : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "TheLoai",
                newName: "MaTheLoai");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "TacGia",
                newName: "MaTacGia");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "Sach",
                newName: "MaSach");

            migrationBuilder.RenameColumn(
                name: "nvarchar(100)",
                table: "NXB",
                newName: "MaNXB");

            migrationBuilder.AlterColumn<string>(
                name: "MaTheLoai",
                table: "TheLoai",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaTacGia",
                table: "TacGia",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaSach",
                table: "Sach",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaNXB",
                table: "NXB",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaTheLoai",
                table: "TheLoai",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "MaTacGia",
                table: "TacGia",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "MaSach",
                table: "Sach",
                newName: "nvarchar(100)");

            migrationBuilder.RenameColumn(
                name: "MaNXB",
                table: "NXB",
                newName: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "TheLoai",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "TacGia",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "Sach",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(100)",
                table: "NXB",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
