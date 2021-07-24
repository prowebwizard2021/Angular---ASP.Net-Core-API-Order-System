using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Client
    {
        public Client()
        {
            BuyingAgents = new HashSet<BuyingAgent>();
            Enquiries = new HashSet<Enquiry>();
            GpRepresentativeMappings = new HashSet<GpRepresentativeMapping>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string ClientNameChiefList { get; set; }
        public string IdClient { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public int? ClientCountryId { get; set; }

        public virtual ICollection<BuyingAgent> BuyingAgents { get; set; }
        public virtual ICollection<Enquiry> Enquiries { get; set; }
        public virtual ICollection<GpRepresentativeMapping> GpRepresentativeMappings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
