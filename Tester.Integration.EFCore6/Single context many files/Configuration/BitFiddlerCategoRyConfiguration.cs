// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // BitFiddlerCATEGORIES
    public class BitFiddlerCategoRyConfiguration : IEntityTypeConfiguration<BitFiddlerCategoRy>
    {
        public void Configure(EntityTypeBuilder<BitFiddlerCategoRy> builder)
        {
            builder.ToTable("BitFiddlerCATEGORIES", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__BitFiddl__3214EC07B251396A").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }

}
// </auto-generated>
