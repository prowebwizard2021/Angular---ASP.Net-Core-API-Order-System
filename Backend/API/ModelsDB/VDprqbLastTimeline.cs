using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VDprqbLastTimeline
    {
        public int OrderId { get; set; }
        public DateTime? ReportAldiDate { get; set; }
        public DateTime? OnSaleDate { get; set; }
        public DateTime? RevisedEtd { get; set; }
        public DateTime? RevisedEta { get; set; }
        public DateTime? PhotoSampleDueDate { get; set; }
        public DateTime? CdExDate { get; set; }
        public DateTime? OrigSamplePickDate { get; set; }
        public DateTime? NewSamplePickDate { get; set; }
        public DateTime? BlreceivedDate { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime? PhotoSampleRevisedDate { get; set; }
        public DateTime? ProductionStart { get; set; }
        public DateTime? FabricEx { get; set; }
        public DateTime? ShipmentDateOriginal { get; set; }
        public DateTime? ShipmentDateRevised { get; set; }
        public DateTime? CustomerDeliveryDateFrom { get; set; }
        public DateTime? CustomerDeliveryDateTill { get; set; }
    }
}
