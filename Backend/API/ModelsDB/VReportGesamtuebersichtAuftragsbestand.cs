using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportGesamtuebersichtAuftragsbestand
    {
        public double? Umsatz { get; set; }
        public double? Db { get; set; }
        public double? Menge { get; set; }
        public string Client { get; set; }
        public string Season { get; set; }
        public int? SeasonId { get; set; }
        public double? Sort { get; set; }
        public int? ProductGroup { get; set; }
        public string Year { get; set; }
        public string Vertreter { get; set; }
        public string OrderId { get; set; }
    }
}
