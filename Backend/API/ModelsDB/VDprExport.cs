using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VDprExport
    {
        public int DatabaseId { get; set; }
        public int? OrderStylesId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDescription { get; set; }
        public string Season { get; set; }
        public double? SeasonSort { get; set; }
        public double? QuantityPlaced { get; set; }
        public string Productgroup { get; set; }
        public string MainFactory { get; set; }
        public string Customer { get; set; }
        public string StyleName { get; set; }
        public int? StyleQuantity { get; set; }
        public double? CartonCount { get; set; }
        public double? Lot { get; set; }
        public DateTime? ShipmentOrig { get; set; }
        public DateTime? ShipmentDateRevised { get; set; }
        public DateTime? RevisedDeliveryDate { get; set; }
        public string FactoryGroup { get; set; }
        public string Sort { get; set; }
        public string Country { get; set; }
        public string Responsible { get; set; }
        public int? Accessories { get; set; }
        public DateTime? FabricEx { get; set; }
        public int? FabricInhouseStatus { get; set; }
        public int? Zipper { get; set; }
        public DateTime? ProductionStart { get; set; }
        public int? LinesRunning { get; set; }
        public string PcsSet { get; set; }
        public int? Knitting { get; set; }
        public int? Cutting { get; set; }
        public int? Sewing { get; set; }
        public int? Ironing { get; set; }
        public int? DailyOutput { get; set; }
        public int? WashSent { get; set; }
        public int? WashReceived { get; set; }
        public int? ItemsPacked { get; set; }
        public int? CartonsCompleted { get; set; }
        public int? CartonsShipped { get; set; }
        public string MotherVessel { get; set; }
        public int? Cutting2 { get; set; }
        public int? Cutting3 { get; set; }
        public int? Sewing2 { get; set; }
        public int? Sewing3 { get; set; }
        public int? Output2 { get; set; }
        public int? Output3 { get; set; }
        public DateTime? CustomerDeliveryDateTill { get; set; }
    }
}
