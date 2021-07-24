using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportAnschlussLaenderNord
    {
        public string Short { get; set; }
        public string AldiNordId { get; set; }
        public string AnschlussId { get; set; }
        public string Artikel { get; set; }
        public string Client { get; set; }
        public string Sachbearbeiter { get; set; }
        public double? Quantity { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? DeliveryDateAnschlussFrom { get; set; }
        public DateTime? DeliveryDateAnschlussTo { get; set; }
        public string Factory { get; set; }
        public DateTime? Eta { get; set; }
        public string Remark { get; set; }
        public DateTime? DeliveryDateNordFrom { get; set; }
        public DateTime? DeliveryDateNordTo { get; set; }
        public string ArticleNumberClient { get; set; }
        public int? SeasonId { get; set; }
        public DateTime? Kundenliefertermin { get; set; }
        public double? Cartons { get; set; }
        public string WebTitle { get; set; }
    }
}
