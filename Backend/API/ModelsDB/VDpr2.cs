using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VDpr2
    {
        public int DatabaseId { get; set; }
        public string Sort2 { get; set; }
        public string Sort { get; set; }
        public string SeasonTitle { get; set; }
        public string OrderNumber { get; set; }
        public string Customer { get; set; }
        public string ProductGroup { get; set; }
        public string ArticleDescription { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string Supplier { get; set; }
        public string Factory { get; set; }
        public DateTime? FactoryDeliveryDate { get; set; }
        public double? QuantityOrderedByClient { get; set; }
        public double? QuantityPlacedAtFactory { get; set; }
        public double? OrderQuantityCartons { get; set; }
        public double? Lot { get; set; }
        public string Crd { get; set; }
        public DateTime? DeliveryDateFrom { get; set; }
        public DateTime? DeliveryDateTo { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfPayment { get; set; }
        public int? DaysToDelivery { get; set; }
        public string Merchandiser { get; set; }
        public string Responsible { get; set; }
        public DateTime? ShipmentDateOriginal { get; set; }
        public DateTime? FabricEx { get; set; }
        public int? FabricInhouseStatus { get; set; }
        public int? Accessories { get; set; }
        public int? Zipper { get; set; }
        public DateTime? ProductionStart { get; set; }
        public int? LinesRunning { get; set; }
        public string PcsSet { get; set; }
        public int? Knitting01 { get; set; }
        public int? Knitting02 { get; set; }
        public int? Knitting03 { get; set; }
        public int? Cutting01 { get; set; }
        public int? Cutting02 { get; set; }
        public int? Cutting03 { get; set; }
        public int? Sewing01 { get; set; }
        public int? Sewing02 { get; set; }
        public int? Sewing03 { get; set; }
        public int? DailyOutput1 { get; set; }
        public int? DailyOutput2 { get; set; }
        public int? DailyOutput3 { get; set; }
        public int? WashSent1 { get; set; }
        public int? WashReceived1 { get; set; }
        public int? WashReceived2 { get; set; }
        public int? WashReceived3 { get; set; }
        public int? Ironing { get; set; }
        public int? ItemsPacked01 { get; set; }
        public int? ItemsPacked02 { get; set; }
        public int? ItemsPacked03 { get; set; }
        public int? CartonsCompleted { get; set; }
        public int? CartonsShipped { get; set; }
        public string MotherVessel { get; set; }
        public string ProcurementQb { get; set; }
        public string LastThree { get; set; }
        public double? SeasonSort { get; set; }
    }
}
