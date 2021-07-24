using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class MaterialProductLine
    {
        public MaterialProductLine()
        {
            FactoryFeatures = new HashSet<FactoryFeature>();
        }

        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<FactoryFeature> FactoryFeatures { get; set; }
    }
}
