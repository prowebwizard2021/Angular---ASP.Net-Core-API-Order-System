using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderGroup
    {
        public OrderGroup()
        {
            WeAndWas = new HashSet<WeAndWa>();
        }

        public int Id { get; set; }
        public string CommentsOrderGroup { get; set; }
        public DateTime? DateControllingSheetClosed { get; set; }
        public int ItemId { get; set; }
        public int? OrderId { get; set; }
        public string TypeOfOrderGroup { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<WeAndWa> WeAndWas { get; set; }
    }
}
