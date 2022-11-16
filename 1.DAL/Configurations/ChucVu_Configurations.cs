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
    internal class ChucVu_Configurations : IEntityTypeConfiguration<ChucVu>
    {
        void IEntityTypeConfiguration<ChucVu>.Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu");
            builder.HasKey(x => x.IdChucVu);

            builder.Property(b => b.MaChucVu).HasColumnName("MaChucVu")
                .HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(b => b.TenChucVu).HasColumnName("TenChucVu")
                .HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
