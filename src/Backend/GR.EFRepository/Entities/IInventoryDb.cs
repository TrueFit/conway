// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace GR.Repositories.EF.Entities
{

    public interface IInventoryDb : System.IDisposable
    {
        System.Data.Entity.DbSet<Config> Configs { get; set; }
        System.Data.Entity.DbSet<InventoryItem> InventoryItems { get; set; }
        System.Data.Entity.DbSet<InventoryItemType> InventoryItemTypes { get; set; }
        System.Data.Entity.DbSet<QualityDeltaStrategy> QualityDeltaStrategies { get; set; }

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<InventoryItem> InventoryItemSearch(bool? includeAvailable, bool? includeExpired, bool? includeSold, bool? includeDiscarded, string orderByClause, int? skip, int? take, System.DateTime? now, out int? totalRows);
        System.Collections.Generic.List<InventoryItem> InventoryItemSearch(bool? includeAvailable, bool? includeExpired, bool? includeSold, bool? includeDiscarded, string orderByClause, int? skip, int? take, System.DateTime? now, out int? totalRows, out int procResult);
        // InventoryItemSearchAsync cannot be created due to having out parameters, or is relying on the procedure result (System.Collections.Generic.List<InventoryItem>)

    }

}
// </auto-generated>
