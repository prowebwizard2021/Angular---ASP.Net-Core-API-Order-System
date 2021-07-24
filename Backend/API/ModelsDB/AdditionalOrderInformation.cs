using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class AdditionalOrderInformation
    {
        public int AdditionalOrderInformationId { get; set; }
        public int? OrdersId { get; set; }
        public string ProcurementQb { get; set; }
        public string MerchandiserSupplier { get; set; }
        public string Qc { get; set; }
        public string KnitWoven { get; set; }
        public DateTime? FmreceivedDate { get; set; }
        public DateTime? CdexDate { get; set; }
        public string TestingLaboratory { get; set; }
        public DateTime? OriginalSamplePickDate { get; set; }
        public DateTime? NewSamplePickDate { get; set; }
        public string SamplePickShortResult { get; set; }
        public DateTime? RevisedEtd { get; set; }
        public DateTime? LatestEta { get; set; }
        public string FabricsFromCountry { get; set; }
        public string Frilaboratory { get; set; }
        public DateTime? Fri1date { get; set; }
        public int? Fri1quantity { get; set; }
        public string Fri1result { get; set; }
        public DateTime? Fri2date { get; set; }
        public int? Fri2quantity { get; set; }
        public string Fri2result { get; set; }
        public DateTime? Fri3date { get; set; }
        public int? Fri3quantity { get; set; }
        public string Fri3result { get; set; }
        public DateTime? ReportAldiDate { get; set; }
        public string ForwarderFreight { get; set; }
        public string ForwarderDelivery { get; set; }
        public DateTime? BlreceivedDate { get; set; }
        public string Vessel { get; set; }
        public int? KeyAccounter { get; set; }
        public decimal? InspectionCosts { get; set; }
        public decimal? AirFreightCosts { get; set; }
        public string SpfinalResult { get; set; }
        public DateTime? Ba { get; set; }
        public int? MainOrderId { get; set; }
        public int? EndCustomerId { get; set; }
        public bool? IsOrderWithoutFixedCustomer { get; set; }
        public int? Lot { get; set; }
        public DateTime? SupplierDeliveryDateOriginal { get; set; }
        public DateTime? LatestFridate { get; set; }
        public string PackingQb { get; set; }

        public virtual EndCustomer EndCustomer { get; set; }
        public virtual Order Orders { get; set; }
    }
}
