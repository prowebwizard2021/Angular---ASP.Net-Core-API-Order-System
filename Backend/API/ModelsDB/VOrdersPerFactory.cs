using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VOrdersPerFactory
    {
        public string OrderId { get; set; }
        public string Artikel { get; set; }
        public double? Menge { get; set; }
        public DateTime? Ltbis { get; set; }
        public string BsciDatabaseId { get; set; }
        public string FactoryTitle { get; set; }
        public string Country { get; set; }
        public string FactoryConnection { get; set; }
        public int? Season { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string Lieferant { get; set; }
        public string Country2 { get; set; }
    }
}
