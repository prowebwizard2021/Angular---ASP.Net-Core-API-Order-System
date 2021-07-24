using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Season
    {
        public Season()
        {
            Enquiries = new HashSet<Enquiry>();
            ExchangeAcceptances = new HashSet<ExchangeAcceptance>();
            ForwardExchangeDealings = new HashSet<ForwardExchangeDealing>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int ItemId { get; set; }
        public double? SortNumber { get; set; }
        public string Title { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Enquiry> Enquiries { get; set; }
        public virtual ICollection<ExchangeAcceptance> ExchangeAcceptances { get; set; }
        public virtual ICollection<ForwardExchangeDealing> ForwardExchangeDealings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
