using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class SachChiTiet_Configurations : IEntityTypeConfiguration<SachChiTiet>
    {
        void IEntityTypeConfiguration<SachChiTiet>.Configure(EntityTypeBuilder<SachChiTiet> builder)
        {
            builder.ToTable("SachChiTiet");
            builder.HasKey(x => x.IdSachCT);
            builder.Property(b => b.MoTa).HasColumnName("MoTa")
                .HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(b=>b.SoLuongTon).HasColumnName("SoLuongTon")
                .HasColumnType("int").IsRequired();
            builder.Property(b => b.GiaNhap).HasColumnName("GiaNhap")
                .HasColumnType("decimal").IsRequired();
            builder.Property(b => b.GiaBan).HasColumnName("GiaBan")
                .HasColumnType("decimal").IsRequired();
            builder.Property(b => b.SoTrang).HasColumnName("SoTrang")
               .HasColumnType("int").IsRequired();

            builder.HasOne(x => x.NXB)
                .WithMany().HasForeignKey(p => p.IdNXB);
            builder.HasOne(x => x.sach)
                .WithMany().HasForeignKey(p => p.IdSach);
            builder.HasOne(x => x.TheLoai)
                .WithMany().HasForeignKey(p => p.IdTheLoai);
            builder.HasOne(x => x.TacGia)
                .WithMany().HasForeignKey(p => p.IdTacGia);
        }
    }
}
