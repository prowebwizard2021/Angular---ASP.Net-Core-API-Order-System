using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VwRmgproduction
    {
        public int ItemIdOrder { get; set; }
        public string OrderId { get; set; }
        public int ItemIdFactory { get; set; }
        public string FactoryTitle { get; set; }
        public string IdTypeOfFactoryInvolvementId { get; set; }
    }
}
