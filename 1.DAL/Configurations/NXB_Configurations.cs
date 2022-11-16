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
    internal class NXB_Configurations : IEntityTypeConfiguration<NXB>
    {
        void IEntityTypeConfiguration<NXB>.Configure(EntityTypeBuilder<NXB> builder)
        {
            builder.ToTable("NXB");
            builder.HasKey(x => x.IdNXB);

            builder.Property(b => b.MaNXB).HasColumnName("MaNXB")
                .HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(b => b.TenNXB).HasColumnName("TenNXB")
                .HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
