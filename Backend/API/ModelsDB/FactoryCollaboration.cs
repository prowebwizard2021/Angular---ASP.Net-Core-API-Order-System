using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class FactoryCollaboration
    {
        public int Id { get; set; }
        public int? CollaborationFactoryId { get; set; }
        public int? FactoryId { get; set; }
        public string GeneralComments { get; set; }
        public int ItemId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Factory CollaborationFactory { get; set; }
        public virtual Factory Factory { get; set; }
    }
}
