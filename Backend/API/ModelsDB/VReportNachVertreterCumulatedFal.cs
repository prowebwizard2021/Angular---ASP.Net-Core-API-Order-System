using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportNachVertreterCumulatedFal
    {
        public int? Jahr { get; set; }
        public string KwNorm { get; set; }
        public string SeasonTitle { get; set; }
        public string SeasonShort { get; set; }
        public double? Revenue { get; set; }
        public double? RevenueCum { get; set; }
    }
}
