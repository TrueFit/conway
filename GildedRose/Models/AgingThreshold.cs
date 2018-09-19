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

    // AgingThreshold
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class AgingThreshold
    {
        public System.Guid AgingThresholdId { get; set; } // AgingThresholdId (Primary key)
        public System.Guid AgingSchemeId { get; set; } // AgingSchemeId
        public string ThresholdName { get; set; } // ThresholdName (length: 256)
        public int DaysPrior { get; set; } // DaysPrior
        public decimal IncrementRate { get; set; } // IncrementRate
        public System.DateTime LastUpdated { get; set; } // LastUpdated

        // Foreign keys

        /// <summary>
        /// Parent AgingScheme pointed by [AgingThreshold].([AgingSchemeId]) (FK_AgingThreshold_AgingScheme)
        /// </summary>
        public virtual AgingScheme AgingScheme { get; set; } // FK_AgingThreshold_AgingScheme

        public AgingThreshold()
        {
            AgingThresholdId = System.Guid.NewGuid();
            LastUpdated = System.DateTime.UtcNow;
        }
    }

}
// </auto-generated>
