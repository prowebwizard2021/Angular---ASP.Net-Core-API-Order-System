using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class AuditingCompany
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string HouseNumber { get; set; }
        public int ItemId { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string ZipCode { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
