using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportNordOrdersWithAttachment
    {
        public string Short { get; set; }
        public string AldiNordId { get; set; }
        public string AnschlussId { get; set; }
        public string Artikel { get; set; }
        public string Client { get; set; }
        public string Sachbearbeiter { get; set; }
        public double? Quantity { get; set; }
        public double? QuantityAnschluss { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? DeliveryDateAnschlussFrom { get; set; }
        public DateTime? DeliveryDateAnschlussTo { get; set; }
        public DateTime? DeliveryDateNordFrom { get; set; }
        public DateTime? DeliveryDateNordTo { get; set; }
        public string Factory { get; set; }
        public DateTime? Eta { get; set; }
        public string Remark { get; set; }
        public double? CartonCount { get; set; }
        public double? CartonCountAnschluss { get; set; }
        public DateTime? FabricDate { get; set; }
        public DateTime? DuProDate { get; set; }
        public string Laboratory { get; set; }
        public string Kombi { get; set; }
        public string ArticleNumberClient { get; set; }
        public int? SeasonId { get; set; }
        public string T1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string FactoryAnschluss { get; set; }
        public string Lieferant { get; set; }
        public string Kombinationen { get; set; }
    }
}
