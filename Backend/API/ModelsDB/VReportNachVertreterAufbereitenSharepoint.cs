using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportNachVertreterAufbereitenSharepoint
    {
        public string DepartmentNumber { get; set; }
        public string TitleDep { get; set; }
        public string Department { get; set; }
        public string OrderNumber { get; set; }
        public int OrderIdDwh { get; set; }
        public string Customer { get; set; }
        public string ArticleDescription { get; set; }
        public double? Quantity { get; set; }
        public DateTime? DeliveryDateFrom { get; set; }
        public DateTime? DeliveryDateTo { get; set; }
        public string Factory { get; set; }
        public int? FactoryId { get; set; }
        public string FactoryCity { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public double? SellingPrice { get; set; }
        public double? PurchasePriceEur { get; set; }
        public double? PurchasePriceUsd { get; set; }
        public double? FxrateePurchasePrice { get; set; }
        public double? RevEur { get; set; }
        public double? GrossProfit { get; set; }
        public double? ContEur { get; set; }
        public double? ContPercent { get; set; }
        public int? Season { get; set; }
        public string Country { get; set; }
        public string Supplier { get; set; }
        public string ProductGroup { get; set; }
        public string KeyAccount { get; set; }
        public string TermOfDeliveryToGp { get; set; }
        public bool? PurchasePriceFixed { get; set; }
        public bool? FactoryFixed { get; set; }
        public string SeasonTitle { get; set; }
        public long? SeasonSort { get; set; }
        public string Lctyp { get; set; }
        public string Lcstate { get; set; }
        public string DeliveryYearRelativeToSeason { get; set; }
        public int? DeliveryMonth { get; set; }
        public DateTime? CreationDateNorm { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? OrderstatusDeleted { get; set; }
        public string DatenBis { get; set; }
    }
}
