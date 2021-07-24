using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportNachFactoryGroupAndFactory
    {
        public string OrderNumber { get; set; }
        public string AdditionalCode { get; set; }
        public string Kunde { get; set; }
        public string ArticleDescription { get; set; }
        public double? Quantity { get; set; }
        public string DeliveryDate { get; set; }
        public DateTime? DeliverySort { get; set; }
        public string Fabrik { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int? Season { get; set; }
        public string Land { get; set; }
        public string Lieferant { get; set; }
        public string Produktgruppe { get; set; }
        public string Vertreter { get; set; }
        public bool? Ekfixed { get; set; }
        public string SeasonTitle { get; set; }
        public double? SeasonSort { get; set; }
        public int? DeliveryMonth { get; set; }
        public string T1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string TermsOfDeliveryToGp { get; set; }
    }
}
