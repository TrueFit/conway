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

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class InventoryItem_EntityConfig : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InventoryItem>
    {
        public InventoryItem_EntityConfig()
            : this("dbo")
        {
        }

        public InventoryItem_EntityConfig(string schema)
        {
            ToTable("InventoryItem", schema);
            HasKey(x => x.InventoryItemId);

            Property(x => x.InventoryItemId).HasColumnName(@"InventoryItemId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InventoryItemTypeId).HasColumnName(@"InventoryItemTypeId").HasColumnType("smallint").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.InitialQuality).HasColumnName(@"InitialQuality").HasColumnType("float").IsRequired();
            Property(x => x.CurrentQuality).HasColumnName(@"CurrentQuality").HasColumnType("float").IsRequired();
            Property(x => x.InventoryDate).HasColumnName(@"InventoryDate").HasColumnType("datetime").IsRequired();
            Property(x => x.SellByDate).HasColumnName(@"SellByDate").HasColumnType("datetime").IsOptional();
            Property(x => x.SaleDate).HasColumnName(@"SaleDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DiscardDate).HasColumnName(@"DiscardDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsOptional();

            HasRequired(a => a.InventoryItemType).WithMany(b => b.InventoryItems).HasForeignKey(c => c.InventoryItemTypeId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
