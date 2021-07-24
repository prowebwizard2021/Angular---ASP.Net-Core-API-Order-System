using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class EnquiriesMaterial
    {
        public int Id { get; set; }
        public int? EnquiryId { get; set; }
        public int? MaterialId { get; set; }

        public virtual Enquiry Enquiry { get; set; }
        public virtual Material Material { get; set; }
    }
}
