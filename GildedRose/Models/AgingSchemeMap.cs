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
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace GildedRose.Models
{

    // AgingScheme
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class AgingSchemeMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AgingScheme>
    {
        public AgingSchemeMap()
            : this("dbo")
        {
        }

        public AgingSchemeMap(string schema)
        {
            ToTable("AgingScheme", schema);
            HasKey(x => x.AgingSchemeId);

            Property(x => x.AgingSchemeId).HasColumnName(@"AgingSchemeId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SchemeName).HasColumnName(@"SchemeName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(256);
            Property(x => x.DefaultIncrement).HasColumnName(@"DefaultIncrement").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.MaxQuality).HasColumnName(@"MaxQuality").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.ScrapOnExpiration).HasColumnName(@"ScrapOnExpiration").HasColumnType("bit").IsOptional();
            Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasOptional(a => a.Product).WithMany(b => b.AgingSchemes).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); // FK_AgingScheme_Product
        }
    }

}
// </auto-generated>
