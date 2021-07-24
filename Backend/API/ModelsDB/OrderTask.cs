using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderTask
    {
        public int Id { get; set; }
        public string AssignedTo { get; set; }
        public string Body { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DoneOn { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? FinishedAt { get; set; }
        public string InternalNameCompleted { get; set; }
        public int ItemId { get; set; }
        public string OfficialInCharge { get; set; }
        public string OrderDescription { get; set; }
        public int? OrderId { get; set; }
        public string OrderTaskConnector { get; set; }
        public string ParentItemlink { get; set; }
        public double? PercentComplete { get; set; }
        public string Predecessors { get; set; }
        public string Priority { get; set; }
        public double? Quantity { get; set; }
        public string SeasonName { get; set; }
        public DateTime? StartDate { get; set; }
        public string Status { get; set; }
        public string Supplier { get; set; }
        public int? TemplateId { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrderTaskTemplate Template { get; set; }
    }
}
