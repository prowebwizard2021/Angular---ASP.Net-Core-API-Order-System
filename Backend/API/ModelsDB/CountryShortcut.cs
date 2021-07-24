using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class CountryShortcut
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string CountryShortcut1 { get; set; }
        public int ItemId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
