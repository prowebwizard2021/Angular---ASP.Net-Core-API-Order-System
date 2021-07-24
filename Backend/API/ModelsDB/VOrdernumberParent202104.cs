using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VOrdernumberParent202104
    {
        public string OrderNumber { get; set; }
        public string Part01Season { get; set; }
        public string Part02Customer { get; set; }
        public string Part03Order { get; set; }
        public string Sub03KeyAccounter { get; set; }
        public DateTime? DeliveryDateFrom { get; set; }
        public string OrdernumberParent { get; set; }
        public int? AnzahlAufträgeImParent { get; set; }
        public DateTime? MinDeliveryDateFromParent { get; set; }
        public string AldipurchOrga { get; set; }
    }
}
