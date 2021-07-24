using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportNachVertreter
    {
        public string OrderNumber { get; set; }
        public string Kunde { get; set; }
        public string ArticleDescription { get; set; }
        public double? Quantity { get; set; }
        public DateTime? DeliveryDateFrom { get; set; }
        public DateTime? DeliveryDateTo { get; set; }
        public string Fabrik { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public double? SellingPrice { get; set; }
        public double? Ek { get; set; }
        public double? Usdollar { get; set; }
        public double? ExchangeRatePurchasePrice { get; set; }
        public double? UmsatzinEur { get; set; }
        public double? Gst { get; set; }
        public double? Db { get; set; }
        public double? Dbpercent { get; set; }
        public int? Season { get; set; }
        public string Land { get; set; }
        public string Lieferant { get; set; }
        public string Produktgruppe { get; set; }
        public string Vertreter { get; set; }
        public string TermsOfDeliveryToGp { get; set; }
        public bool? Ekfixed { get; set; }
        public bool? FactoryFixed { get; set; }
        public string SeasonTitle { get; set; }
        public double? SeasonSort { get; set; }
        public string Lctyp { get; set; }
        public string Lcstate { get; set; }
        public double? Ekusd { get; set; }
        public int? DeliveryMonth { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? CreationDateOrig { get; set; }
    }
}
