using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportNachVertreterGruppiert
    {
        public int? OrderCount { get; set; }
        public double? Quantity { get; set; }
        public double? UmsatzinEur { get; set; }
        public double? Db { get; set; }
        public int? Season { get; set; }
        public string Produktgruppe { get; set; }
        public string Vertreter { get; set; }
        public string SeasonTitle { get; set; }
        public double? SeasonSort { get; set; }
        public double? PrevQuantity { get; set; }
        public double? PrevDb { get; set; }
        public double? PrevUmsatz { get; set; }
        public int? PrevOrderCount { get; set; }
    }
}
