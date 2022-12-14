// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Model;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Model.ChucVu", b =>
                {
                    b.Property<Guid>("IdChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaChucVu");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenChucVu");

                    b.HasKey("IdChucVu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.Model.GioHang", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaGioHang")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GioHang");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TrangThai");

                    b.HasKey("IdGioHang");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("_1.DAL.Model.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IdGioHangCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<Guid>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSachChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Soluong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.HasKey("IdGioHangCT");

                    b.HasIndex("IdGioHang");

                    b.HasIndex("IdSachChiTiet");

                    b.ToTable("GioHangChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Model.HoaDon", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHoaDon")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("MaHoaDon");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayTao");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nvarchar (100)");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Model.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHoaDonChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSachChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.HasKey("IdHoaDonChiTiet");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdSachChiTiet");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Model.KhachHang", b =>
                {
                    b.Property<Guid>("IdKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("DiaChi");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("GioiTinh");

                    b.Property<string>("MaKHachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("MaKhachHang");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("DateTime")
                        .HasColumnName("NgaySinh");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("TenKhachHang");

                    b.HasKey("IdKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.Model.NXB", b =>
                {
                    b.Property<Guid>("IdNXB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaNXB");

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenNXB");

                    b.HasKey("IdNXB");

                    b.ToTable("NXB");
                });

            modelBuilder.Entity("_1.DAL.Model.NhanVien", b =>
                {
                    b.Property<Guid>("IdNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("DiaChi");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar (10)")
                        .HasColumnName("GioiTinh");

                    b.Property<Guid>("IdBc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("MaNhanVien");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime")
                        .HasColumnName("NgaySinh");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar (10)")
                        .HasColumnName("SDT");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar (100)")
                        .HasColumnName("TenNhanVien");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar (10)")
                        .HasColumnName("TrangThai");

                    b.Property<Guid?>("nhanvienIdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdNhanVien");

                    b.HasIndex("IdChucVu");

                    b.HasIndex("nhanvienIdNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Model.Sach", b =>
                {
                    b.Property<Guid>("IdSach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSach")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaSach");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenSach");

                    b.HasKey("IdSach");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("_1.DAL.Model.SachChiTiet", b =>
                {
                    b.Property<Guid>("IdSachCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal")
                        .HasColumnName("GiaBan");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal")
                        .HasColumnName("GiaNhap");

                    b.Property<Guid>("IdNXB")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTacGia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTheLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MoTa");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int")
                        .HasColumnName("SoLuongTon");

                    b.Property<int>("SoTrang")
                        .HasColumnType("int")
                        .HasColumnName("SoTrang");

                    b.HasKey("IdSachCT");

                    b.HasIndex("IdNXB");

                    b.HasIndex("IdSach");

                    b.HasIndex("IdTacGia");

                    b.HasIndex("IdTheLoai");

                    b.ToTable("SachChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Model.TacGia", b =>
                {
                    b.Property<Guid>("IdTacGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaTacGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaTacGia");

                    b.Property<string>("TenTacGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenTacGia");

                    b.HasKey("IdTacGia");

                    b.ToTable("TacGia");
                });

            modelBuilder.Entity("_1.DAL.Model.TheLoai", b =>
                {
                    b.Property<Guid>("IdTheLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaTheLoai");

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenTheLoai");

                    b.HasKey("IdTheLoai");

                    b.ToTable("TheLoai");
                });

            modelBuilder.Entity("_1.DAL.Model.GioHang", b =>
                {
                    b.HasOne("_1.DAL.Model.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Model.GioHangChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Model.GioHang", "GioHang")
                        .WithMany()
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.SachChiTiet", "SachChiTiet")
                        .WithMany()
                        .HasForeignKey("IdSachChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SachChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Model.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Model.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Model.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Model.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.SachChiTiet", "SachChiTiet")
                        .WithMany()
                        .HasForeignKey("IdSachChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SachChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Model.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Model.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("IdChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.NhanVien", "nhanvien")
                        .WithMany()
                        .HasForeignKey("nhanvienIdNhanVien");

                    b.Navigation("ChucVu");

                    b.Navigation("nhanvien");
                });

            modelBuilder.Entity("_1.DAL.Model.SachChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Model.NXB", "NXB")
                        .WithMany()
                        .HasForeignKey("IdNXB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.Sach", "sach")
                        .WithMany()
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.TacGia", "TacGia")
                        .WithMany()
                        .HasForeignKey("IdTacGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Model.TheLoai", "TheLoai")
                        .WithMany()
                        .HasForeignKey("IdTheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NXB");

                    b.Navigation("sach");

                    b.Navigation("TacGia");

                    b.Navigation("TheLoai");
                });
#pragma warning restore 612, 618
        }
    }
}
