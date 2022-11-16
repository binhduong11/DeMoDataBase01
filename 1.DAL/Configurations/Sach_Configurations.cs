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
    public class Sach_Configurations : IEntityTypeConfiguration<Sach>
    {
        void IEntityTypeConfiguration<Sach>.Configure(EntityTypeBuilder<Sach> builder)
        {
            builder.ToTable("Sach");
            builder.HasKey(x => x.IdSach);

            builder.Property(b=>b.MaSach).HasColumnName("MaSach")
                .HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(b => b.TenSach).HasColumnName("TenSach")
                .HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
