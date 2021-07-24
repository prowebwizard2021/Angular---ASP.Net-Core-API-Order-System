using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class ContactPerson
    {
        public ContactPerson()
        {
            AgentsContactPeople = new HashSet<AgentsContactPerson>();
            FactoriesContactPeople = new HashSet<FactoriesContactPerson>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string DescriptionOfPosition { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string GeneralComments { get; set; }
        public string HouseNumber { get; set; }
        public string IdContactPerson { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string ZipCode { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<AgentsContactPerson> AgentsContactPeople { get; set; }
        public virtual ICollection<FactoriesContactPerson> FactoriesContactPeople { get; set; }
    }
}
