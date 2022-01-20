// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // Articles
    public class WVN_ArticleConfiguration : IEntityTypeConfiguration<WVN_Article>
    {
        public void Configure(EntityTypeBuilder<WVN_Article> builder)
        {
            builder.ToTable("Articles", "WVN");
            builder.HasKey(x => x.PkArticle).HasName("PK_Articles").IsClustered();

            builder.Property(x => x.PkArticle).HasColumnName(@"PK_Article").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.FkFactory).HasColumnName(@"FK_Factory").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.FkArticleLevel).HasColumnName(@"FK_ArticleLevel").HasColumnType("int").IsRequired();
            builder.Property(x => x.FkParentArticle).HasColumnName(@"FK_ParentArticle").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar(20)").IsRequired().HasMaxLength(20);

            builder.HasIndex(x => new { x.FkFactory, x.FkArticleLevel, x.Code }).HasDatabaseName("UK_Articles").IsUnique();
        }
    }

}
// </auto-generated>
