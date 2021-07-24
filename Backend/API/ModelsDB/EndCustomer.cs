using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class EndCustomer
    {
        public EndCustomer()
        {
            AdditionalOrderInformations = new HashSet<AdditionalOrderInformation>();
        }

        public int EndCustomerId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<AdditionalOrderInformation> AdditionalOrderInformations { get; set; }
    }
}
