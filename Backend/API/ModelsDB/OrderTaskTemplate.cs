using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderTaskTemplate
    {
        public OrderTaskTemplate()
        {
            OrderTasks = new HashSet<OrderTask>();
        }

        public int Id { get; set; }
        public double? DefaultOffset { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        public string OfficialInChargeField { get; set; }
        public string OffsetPrimaryField { get; set; }
        public string OffsetSecondaryField { get; set; }
        public bool? Standard { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public int? OrderTaskType { get; set; }
        public bool? FollowUpStandard { get; set; }

        public virtual ICollection<OrderTask> OrderTasks { get; set; }
    }
}
