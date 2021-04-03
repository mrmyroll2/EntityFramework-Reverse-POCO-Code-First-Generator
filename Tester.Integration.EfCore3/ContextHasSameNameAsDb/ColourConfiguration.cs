// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3.ContextHasSameNameAsDb
{
    // Colour
    public class ColourConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.ToTable("Colour", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__Colour__3214EC07379EAA64").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar(255)").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }

}
// </auto-generated>
