using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportOrdersByDate
    {
        public DateTime? CreationDate { get; set; }
        public double? QtyEkeur { get; set; }
        public double? QtyEkusd { get; set; }
        public double? Qty { get; set; }
        public int? AnzahlAuftraege { get; set; }
        public int? SaisonId { get; set; }
        public string ProductLineId { get; set; }
    }
}
