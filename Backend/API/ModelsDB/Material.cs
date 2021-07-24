using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Material
    {
        public Material()
        {
            EnquiriesMaterials = new HashSet<EnquiriesMaterial>();
            EnquiryItemsMaterials = new HashSet<EnquiryItemsMaterial>();
        }

        public int Id { get; set; }
        public bool? Deleted { get; set; }
        public string EffectiveWidth { get; set; }
        public double? FiberMassDensity { get; set; }
        public int? FilamentsPerFiber { get; set; }
        public string FurtherCommentsRegardingThreadDensity { get; set; }
        public int? GeneralTypeOfMaterialId { get; set; }
        public string MaterialDescription { get; set; }
        public int? PurposeOfMaterialId { get; set; }
        public double? RelativeWeightOfMaterial { get; set; }
        public DateTime? SampleReceived { get; set; }
        public string ShrinkingFactorWarpFrom { get; set; }
        public string ShrinkingFactorWarpTo { get; set; }
        public string ShrinkingFactorWeftFrom { get; set; }
        public string ShrinkingFactorWeftTo { get; set; }
        public int? StapleLengthInMm { get; set; }
        public double? ThreadDensityWarp { get; set; }
        public double? ThreadDensityWeft { get; set; }
        public string UnitOfFiberMassDensity { get; set; }
        public string UnitOfRelativeWeightOfMaterial { get; set; }
        public string UnitOfThreadDensities { get; set; }
        public string UnitOfYarnMassDensity { get; set; }
        public double? YarnMassDensity { get; set; }
        public int ItemId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual MaterialBaseType GeneralTypeOfMaterial { get; set; }
        public virtual MaterialPurpose PurposeOfMaterial { get; set; }
        public virtual ICollection<EnquiriesMaterial> EnquiriesMaterials { get; set; }
        public virtual ICollection<EnquiryItemsMaterial> EnquiryItemsMaterials { get; set; }
    }
}
