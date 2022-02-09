// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // tblOrderErrorsAB_
    public class TblOrderErrorsAbConfiguration : IEntityTypeConfiguration<TblOrderErrorsAb>
    {
        public void Configure(EntityTypeBuilder<TblOrderErrorsAb> builder)
        {
            builder.ToTable("tblOrderErrorsAB_", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_tblOrderErrorsAB").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Error).HasColumnName(@"error").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>
