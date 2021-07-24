using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class EnquiryItemsMaterial
    {
        public int Id { get; set; }
        public int? EnquiryItemId { get; set; }
        public int? MaterialId { get; set; }

        public virtual EnquiryItem EnquiryItem { get; set; }
        public virtual Material Material { get; set; }
    }
}
