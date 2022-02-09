// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // workflow
    public class Beta_WorkflowConfiguration : IEntityTypeConfiguration<Beta_Workflow>
    {
        public void Configure(EntityTypeBuilder<Beta_Workflow> builder)
        {
            builder.ToTable("workflow", "Beta");
            builder.HasKey(x => x.Id).HasName("PK_beta_workflow").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
