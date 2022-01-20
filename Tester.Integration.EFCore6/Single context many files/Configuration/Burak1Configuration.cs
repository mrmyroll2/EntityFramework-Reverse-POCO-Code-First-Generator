// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // Burak1
    public class Burak1Configuration : IEntityTypeConfiguration<Burak1>
    {
        public void Configure(EntityTypeBuilder<Burak1> builder)
        {
            builder.ToTable("Burak1", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Burak1").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("bigint").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.IdT).HasColumnName(@"id_t").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.Num).HasColumnName(@"num").HasColumnType("bigint").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Burak2_Id).WithOne(b => b.Burak1_Id).HasForeignKey<Burak1>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Burak_Test2");
            builder.HasOne(a => a.Burak2_IdT).WithOne(b => b.Burak1_IdT).HasPrincipalKey<Burak2>(p => new { p.Id, p.Num }).HasForeignKey<Burak1>(c => new { c.IdT, c.Num }).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Burak_Test1");
        }
    }

}
// </auto-generated>
