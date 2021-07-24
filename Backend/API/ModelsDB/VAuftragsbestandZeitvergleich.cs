using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VAuftragsbestandZeitvergleich
    {
        public string Kunde { get; set; }
        public double? UmsatzinEur { get; set; }
        public double? Db { get; set; }
        public int? Season { get; set; }
        public string Produktgruppe { get; set; }
        public string Vertreter { get; set; }
        public string SeasonTitle { get; set; }
        public int? Woche { get; set; }
        public int? Jahr { get; set; }
        public DateTime? MinCreationDate { get; set; }
    }
}
