using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportBySeason
    {
        public double? Quantity { get; set; }
        public double? Usdollar { get; set; }
        public double? ExchangeRatePurchasePrice { get; set; }
        public double? Gst { get; set; }
        public double? Db { get; set; }
        public double? Ekusd { get; set; }
        public string Produktgruppe { get; set; }
        public string Vertreter { get; set; }
        public string SeasonTitle { get; set; }
        public string Kunde { get; set; }
    }
}
