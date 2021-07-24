using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VDpr
    {
        public int DatabaseId { get; set; }
        public string Sort2 { get; set; }
        public string Sort { get; set; }
        public string OrdernumberParent { get; set; }
        public string ArticleDescription { get; set; }
        public string SeasonTitle { get; set; }
        public string ProductGroup { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string Customer { get; set; }
        public string Merchandiser { get; set; }
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
        public int? DaysToDelivery { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfPayment { get; set; }
        public DateTime? OrderModified { get; set; }
        public DateTime? Eimodified { get; set; }
        public DateTime? OrderCreationDate { get; set; }
        public DateTime? ShipmentDateOriginal { get; set; }
        public string LastThree { get; set; }
        public double? SeasonSort { get; set; }
        public string ProcurementQb { get; set; }
        public DateTime? StatusDateOverall { get; set; }
        public DateTime? ProductionStart { get; set; }
        public DateTime? StatusPackeddate01 { get; set; }
        public DateTime? StatusPackeddate02 { get; set; }
        public DateTime? StatusPackeddate03 { get; set; }
        public int? ItemsPacked01 { get; set; }
        public int? ItemsPacked02 { get; set; }
        public int? ItemsPacked03 { get; set; }
        public DateTime? StatusKnittingdate01 { get; set; }
        public DateTime? StatusKnittingdate02 { get; set; }
        public DateTime? StatusKnittingdate03 { get; set; }
        public int? Knitting01 { get; set; }
        public int? Knitting02 { get; set; }
        public int? Knitting03 { get; set; }
        public DateTime? StatusCuttingdate01 { get; set; }
        public DateTime? StatusCuttingdate02 { get; set; }
        public DateTime? StatusCuttingdate03 { get; set; }
        public int? Cutting01 { get; set; }
        public int? Cutting02 { get; set; }
        public int? Cutting03 { get; set; }
        public DateTime? StatusSewingdate01 { get; set; }
        public DateTime? StatusSewingdate02 { get; set; }
        public DateTime? StatusSewingdate03 { get; set; }
        public int? Sewing01 { get; set; }
        public int? Sewing02 { get; set; }
        public int? Sewing03 { get; set; }
        public DateTime? StatusWashReceiveddate01 { get; set; }
        public DateTime? StatusWashReceiveddate02 { get; set; }
        public DateTime? StatusWashReceiveddate03 { get; set; }
        public int? WashReceived01 { get; set; }
        public int? WashReceived02 { get; set; }
        public int? WashReceived03 { get; set; }
        public DateTime? StatusAccessoriesDate { get; set; }
        public int? Accessories { get; set; }
        public DateTime? StatusCartonsCompletedDate { get; set; }
        public int? CartonsCompleted { get; set; }
        public DateTime? StatusCartonsShippedDate { get; set; }
        public int? CartonsShipped { get; set; }
        public DateTime? StatusIroningDate { get; set; }
        public int? Ironing { get; set; }
        public DateTime? StatusDailyOutputDate { get; set; }
        public int? DailyOutput { get; set; }
        public DateTime? StatusLinesRunningDate { get; set; }
        public int? LinesRunning { get; set; }
        public DateTime? StatusWashSentDate { get; set; }
        public int? WashSent { get; set; }
        public DateTime? StatusZipperDate { get; set; }
        public int? Zipper { get; set; }
        public DateTime? StatusMotherVesselDate { get; set; }
        public string MotherVessel { get; set; }
        public DateTime? StatusPcsSetDate { get; set; }
        public string PcsSet { get; set; }
    }
}
