using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportShipmentDate
    {
        public string IdOrder { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int? ShipmentYear { get; set; }
        public int? ShipmentMonth { get; set; }
        public int? ShipmentWeek { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryYear { get; set; }
        public int? DeliveryMonth { get; set; }
        public int? DeliveryWeek { get; set; }
        public DateTime? DeliveryDate2 { get; set; }
        public int? DeliveryYear2 { get; set; }
        public int? DeliveryMonth2 { get; set; }
        public int? DeliveryWeek2 { get; set; }
        public string Fabrikgruppe { get; set; }
        public int? Capacity { get; set; }
        public double? Quantity { get; set; }
        public string Country { get; set; }
        public int? SeasonId { get; set; }
        public string Title { get; set; }
        public string OrderId { get; set; }
    }
}
