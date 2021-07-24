using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class MaterialFeature
    {
        public int Id { get; set; }
        public string AssociatedMaterialId { get; set; }
        public int ItemId { get; set; }
        public string ContentTypeName { get; set; }
        public int? MaterialAbbreveationId { get; set; }
        public double? MaterialPercentage { get; set; }
        public string NameOfTreatmentSymbol { get; set; }
        public string TreatmentSymbol { get; set; }
        public int? KeywordForMaterialFeatureId { get; set; }
        public int? AgentId { get; set; }
        public string BaseOfFabricPurchasingPrice { get; set; }
        public int? CurrencyOfFabricPurchasingPriceId { get; set; }
        public DateTime? DateOfFabricPurchasingPriceEnquiry { get; set; }
        public int? FactoryId { get; set; }
        public int? IncotermForFabricPurchasingPriceId { get; set; }
        public double? MaterialPurchasingPrice { get; set; }
        public string PaymentTermsForFabricPurchasingPrice { get; set; }
        public double? PurchasingQuantityOfFabricForPurchasingPrice { get; set; }
        public string QuickInfoIfNewAgent { get; set; }
        public string QuickInfoIfNewFactory { get; set; }
        public string UnitOfFabricPurchasingQuantity { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Currency CurrencyOfFabricPurchasingPrice { get; set; }
        public virtual Factory Factory { get; set; }
        public virtual IncomingTermsOfDelivery IncotermForFabricPurchasingPrice { get; set; }
        public virtual KeywordsForMaterialFeature KeywordForMaterialFeature { get; set; }
        public virtual MaterialAbbreveation MaterialAbbreveation { get; set; }
    }
}
