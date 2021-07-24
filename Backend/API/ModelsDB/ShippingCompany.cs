using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class ShippingCompany
    {
        public ShippingCompany()
        {
            Containers = new HashSet<Container>();
        }

        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Container> Containers { get; set; }
    }
}
