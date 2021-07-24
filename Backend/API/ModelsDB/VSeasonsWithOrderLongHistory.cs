using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VSeasonsWithOrderLongHistory
    {
        public string SeasonTitle { get; set; }
        public string Season { get; set; }
        public string YearLong { get; set; }
        public string Year { get; set; }
        public int SeasonSort { get; set; }
        public string YearSeason { get; set; }
        public long? Sortnumber { get; set; }
        public int FilterSharepointData { get; set; }
    }
}
