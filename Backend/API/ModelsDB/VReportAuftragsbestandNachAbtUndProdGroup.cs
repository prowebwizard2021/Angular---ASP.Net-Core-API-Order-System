using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportAuftragsbestandNachAbtUndProdGroup
    {
        public string Abteilung { get; set; }
        public int? Produktgruppe { get; set; }
        public int? SaisonId { get; set; }
        public int? Anzahl { get; set; }
        public double? Menge { get; set; }
        public double? Umsatz { get; set; }
        public double? Db { get; set; }
        public double? Dbpercent { get; set; }
    }
}
