using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportPriceNotFilled
    {
        public string OrderShort { get; set; }
        public string OrderId { get; set; }
        public string Title { get; set; }
        public double? SellingPriceGp { get; set; }
        public double? SellingPriceGpInclIncoTerm { get; set; }
        public Guid WebId { get; set; }
        public string WebTitle { get; set; }
        public int? SeasonId { get; set; }
    }
}
