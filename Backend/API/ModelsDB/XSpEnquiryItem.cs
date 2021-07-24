using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class XSpEnquiryItem
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public string Title { get; set; }
        public Guid? WebId { get; set; }
    }
}
