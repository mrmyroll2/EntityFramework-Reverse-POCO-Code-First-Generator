// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // workflow
    public class Alpha_WorkflowConfiguration : IEntityTypeConfiguration<Alpha_Workflow>
    {
        public void Configure(EntityTypeBuilder<Alpha_Workflow> builder)
        {
            builder.ToTable("workflow", "Alpha");
            builder.HasKey(x => x.Id).HasName("PK_alpha_workflow").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
