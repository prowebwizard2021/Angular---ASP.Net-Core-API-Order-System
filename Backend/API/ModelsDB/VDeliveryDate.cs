using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VDeliveryDate
    {
        public int OrderId { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
