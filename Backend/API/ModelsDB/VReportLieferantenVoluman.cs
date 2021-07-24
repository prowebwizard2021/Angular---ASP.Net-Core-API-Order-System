using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportLieferantenVoluman
    {
        public string AgentenName { get; set; }
        public int? Saison { get; set; }
        public double? UmsatzInTeuro { get; set; }
        public double? EkvolInTeuro { get; set; }
        public double? StckInTsd { get; set; }
        public int? AnzahlAuftraege { get; set; }
    }
}
