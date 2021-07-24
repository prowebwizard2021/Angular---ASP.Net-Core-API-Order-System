using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VReportJahrAbtProdGr
    {
        public double? Umsatz { get; set; }
        public string Client { get; set; }
        public int? Season { get; set; }
        public int? ProductGroup { get; set; }
        public string Year { get; set; }
    }
}
