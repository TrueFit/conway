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
    public partial class QualityDeltaStrategy
    {
        public byte QualityDeltaStrategyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public System.Collections.Generic.ICollection<InventoryItemType> InventoryItemTypes { get; set; } = new System.Collections.Generic.List<InventoryItemType>();
    }

}
// </auto-generated>
