using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VAmxGetEnquiryItemByOrderId
    {
        public string IdOrder { get; set; }
        public int Factory { get; set; }
        public string Title { get; set; }
        public int ItemIdEnqiry { get; set; }
        public int IdEnquiry { get; set; }
    }
}
