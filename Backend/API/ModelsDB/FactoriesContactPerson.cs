using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class FactoriesContactPerson
    {
        public int Id { get; set; }
        public int? ContactPersonId { get; set; }
        public int? FactoryId { get; set; }

        public virtual ContactPerson ContactPerson { get; set; }
        public virtual Factory Factory { get; set; }
    }
}
