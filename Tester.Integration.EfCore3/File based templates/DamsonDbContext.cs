// <auto-generated>

using Generator.Tests.Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tester;

namespace Tester.Integration.EfCore3.File_based_templatesPlum
{
    #region Database context interface

    public interface IDamsonDbContext : IDisposable
    {
        DbSet<NoPrimaryKey> NoPrimaryKeys { get; set; } // NoPrimaryKeys
        DbSet<Synonyms_Parent> Synonyms_Parents { get; set; } // Parent

        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        DatabaseFacade Database { get; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        EntityEntry Add(object entity);
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        Task AddRangeAsync(params object[] entities);
        Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default);
        ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class;
        ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default);
        void AddRange(IEnumerable<object> entities);
        void AddRange(params object[] entities);

        EntityEntry Attach(object entity);
        EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;
        void AttachRange(IEnumerable<object> entities);
        void AttachRange(params object[] entities);

        EntityEntry Entry(object entity);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;
        ValueTask<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : class;
        ValueTask<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class;
        ValueTask<object> FindAsync(Type entityType, object[] keyValues, CancellationToken cancellationToken);
        ValueTask<object> FindAsync(Type entityType, params object[] keyValues);
        object Find(Type entityType, params object[] keyValues);

        EntityEntry Remove(object entity);
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
        void RemoveRange(IEnumerable<object> entities);
        void RemoveRange(params object[] entities);

        EntityEntry Update(object entity);
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
        void UpdateRange(IEnumerable<object> entities);
        void UpdateRange(params object[] entities);

    }

    #endregion

    #region Database context

    public class DamsonDbContext : DbContext, IDamsonDbContext
    {
        private readonly IConfiguration _configuration;

        public DamsonDbContext()
        {
        }

        public DamsonDbContext(DbContextOptions<DamsonDbContext> options)
            : base(options)
        {
        }

        public DamsonDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<NoPrimaryKey> NoPrimaryKeys { get; set; } // NoPrimaryKeys
        public DbSet<Synonyms_Parent> Synonyms_Parents { get; set; } // Parent

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured && _configuration != null)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString(@"McsfMultiDatabase"));
                optionsBuilder.UseLazyLoadingProxies();
            }
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new NoPrimaryKeyConfiguration());
            modelBuilder.ApplyConfiguration(new Synonyms_ParentConfiguration());
        }

    }

    #endregion

    #region Database context factory

    public class DamsonDbContextFactory : IDesignTimeDbContextFactory<DamsonDbContext>
    {
        public DamsonDbContext CreateDbContext(string[] args)
        {
            return new DamsonDbContext();
        }
    }

    #endregion

    #region POCO classes

    // NoPrimaryKeys
    public class NoPrimaryKey
    {
        public string Description { get; set; } // Description (Primary key) (length: 10)

        // Reverse navigation

        /// <summary>
        /// Child Synonyms_Parents where [Parent].[ParentName] point to this entity (CustomNameForForeignKey)
        /// </summary>
        public virtual ICollection<Synonyms_Parent> ChildFkName { get; set; } // Parent.CustomNameForForeignKey

        public NoPrimaryKey()
        {
            ChildFkName = new List<Synonyms_Parent>();
        }
    }

    // Parent
    public class Synonyms_Parent
    {
        public int ParentId { get; set; } // ParentId (Primary key)
        public string ParentName { get; set; } // ParentName (length: 100)

        // Foreign keys

        /// <summary>
        /// Parent NoPrimaryKey pointed by [Parent].([ParentName]) (CustomNameForForeignKey)
        /// </summary>
        public virtual NoPrimaryKey ParentFkName { get; set; } // CustomNameForForeignKey
    }


    #endregion

    #region POCO Configuration

    // NoPrimaryKeys
    public class NoPrimaryKeyConfiguration : IEntityTypeConfiguration<NoPrimaryKey>
    {
        public void Configure(EntityTypeBuilder<NoPrimaryKey> builder)
        {
            builder.ToTable("NoPrimaryKeys", "dbo");
            builder.HasKey(x => x.Description);

            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
        }
    }

    // Parent
    public class Synonyms_ParentConfiguration : IEntityTypeConfiguration<Synonyms_Parent>
    {
        public void Configure(EntityTypeBuilder<Synonyms_Parent> builder)
        {
            builder.ToTable("Parent", "Synonyms");
            builder.HasKey(x => x.ParentId).HasName("PK_Parent").IsClustered();

            builder.Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ParentName).HasColumnName(@"ParentName").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);

            // Foreign keys
            builder.HasOne(a => a.ParentFkName).WithMany(b => b.ChildFkName).HasForeignKey(c => c.ParentName).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CustomNameForForeignKey");
        }
    }


    #endregion

}
// </auto-generated>
