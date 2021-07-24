using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportNachVertreterOverview
    {
        public string Source { get; set; }
        public string DataUsername { get; set; }
        public DateTime DataAsOf { get; set; }
        public string Productgroup { get; set; }
        public string SeasonTitle { get; set; }
        public long? SeasonSort { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? CreationDateNorm { get; set; }
        public string DatenBis { get; set; }
        public double? RevEur { get; set; }
        public double? Quantitiy { get; set; }
        public int? CountOrder { get; set; }
    }
}
