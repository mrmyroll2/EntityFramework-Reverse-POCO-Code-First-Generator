// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // SequenceTestPartTwo
    public class SequenceTestPartTwoConfiguration : IEntityTypeConfiguration<SequenceTestPartTwo>
    {
        public void Configure(EntityTypeBuilder<SequenceTestPartTwo> builder)
        {
            builder.ToTable("SequenceTestPartTwo", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_SequenceTestPartTwo").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.CntByBigInt).HasColumnName(@"CntByBigInt").HasColumnType("bigint").IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountByBigInt]");
            builder.Property(x => x.CntByTinyInt).HasColumnName(@"CntByTinyInt").HasColumnType("tinyint").IsRequired().HasDefaultValueSql(@"NEXT VALUE FOR [dbo].[CountByTinyInt]");
        }
    }

}
// </auto-generated>
