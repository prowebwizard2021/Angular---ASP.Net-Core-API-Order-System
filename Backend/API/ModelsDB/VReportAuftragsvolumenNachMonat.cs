using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportAuftragsvolumenNachMonat
    {
        public double? Quantity { get; set; }
        public double? UmsatzinEur { get; set; }
        public double? Db { get; set; }
        public int? SeasonId { get; set; }
        public string SeasonTitle { get; set; }
        public double? Ekusd { get; set; }
        public string DeliveryMonth { get; set; }
        public double? SeasonSort { get; set; }
        public int? MonthSort { get; set; }
        public string Vertreter { get; set; }
    }
}
