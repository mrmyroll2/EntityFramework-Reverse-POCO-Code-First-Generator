// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // BatchTest
    public class BatchTestConfiguration : IEntityTypeConfiguration<BatchTest>
    {
        public void Configure(EntityTypeBuilder<BatchTest> builder)
        {
            builder.ToTable("BatchTest", "dbo");
            builder.HasKey(x => x.Code).HasName("PK_BatchTest").IsClustered();

            builder.Property(x => x.Code).HasColumnName(@"code").HasColumnType("nvarchar(8)").IsRequired().HasMaxLength(8).ValueGeneratedNever();
        }
    }

}
// </auto-generated>
