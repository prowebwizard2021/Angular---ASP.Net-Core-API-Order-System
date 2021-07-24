using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class ArticleVariation
    {
        public int Id { get; set; }
        public string ArticleNumber { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public int? OrderId { get; set; }
        public int? QuantityOrderedByClient { get; set; }
        public int? QuantityPlacedAtFactory { get; set; }

        public virtual Order Order { get; set; }
    }
}
