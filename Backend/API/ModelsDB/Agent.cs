using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Agent
    {
        public Agent()
        {
            AgentsContactPeople = new HashSet<AgentsContactPerson>();
            EnquiryItems = new HashSet<EnquiryItem>();
            FactoryAgent2s = new HashSet<Factory>();
            FactoryAgents = new HashSet<Factory>();
            MaterialFeatures = new HashSet<MaterialFeature>();
        }

        public int Id { get; set; }
        public string Abc { get; set; }
        public string Address { get; set; }
        public string AgentNameChiefList { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool? Deleted { get; set; }
        public string Email { get; set; }
        public string FactoryCategories { get; set; }
        public string FactoryIds { get; set; }
        public string HouseNumber { get; set; }
        public int ItemId { get; set; }
        public string PhoneNumber { get; set; }
        public string Province { get; set; }
        public string Title { get; set; }
        public string ZipCode { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<AgentsContactPerson> AgentsContactPeople { get; set; }
        public virtual ICollection<EnquiryItem> EnquiryItems { get; set; }
        public virtual ICollection<Factory> FactoryAgent2s { get; set; }
        public virtual ICollection<Factory> FactoryAgents { get; set; }
        public virtual ICollection<MaterialFeature> MaterialFeatures { get; set; }
    }
}
