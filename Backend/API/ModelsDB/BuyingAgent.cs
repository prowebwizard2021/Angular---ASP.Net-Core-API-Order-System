using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class BuyingAgent
    {
        public BuyingAgent()
        {
            Enquiries = new HashSet<Enquiry>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string BuyingAgentResponsibleFor { get; set; }
        public string City { get; set; }
        public int? ClientId { get; set; }
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string GeneralComments { get; set; }
        public string HouseNumber { get; set; }
        public string IdBuyingAgent { get; set; }
        public int ItemId { get; set; }
        public string Province { get; set; }
        public string Title { get; set; }
        public string ZipCode { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<Enquiry> Enquiries { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
