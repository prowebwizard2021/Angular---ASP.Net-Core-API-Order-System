using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class WeAndWa
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string GeneralComments { get; set; }
        public string GoodsReceivedorIssued { get; set; }
        public int ItemId { get; set; }
        public int? OrderGroupId { get; set; }
        public int? OrderId { get; set; }
        public int? Quantity { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrderGroup OrderGroup { get; set; }
    }
}
