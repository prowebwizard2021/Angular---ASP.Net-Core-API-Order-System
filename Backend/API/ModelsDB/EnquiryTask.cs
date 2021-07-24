using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class EnquiryTask
    {
        public int Id { get; set; }
        public string AssignedTo { get; set; }
        public string Body { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DoneOn { get; set; }
        public DateTime? EnquiryDeadline { get; set; }
        public int? EnquiryId { get; set; }
        public int? EnquiryItemId { get; set; }
        public string EnquiryTaskConnector { get; set; }
        public string EnquiryTitle { get; set; }
        public int ItemId { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string OfficialInCharge { get; set; }
        public string ParentItemLink { get; set; }
        public double? Quantity { get; set; }
        public string SeasonName { get; set; }
        public string Supplier { get; set; }
        public int? TemplateId { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }

        public virtual Enquiry Enquiry { get; set; }
        public virtual EnquiryTaskTemplate Template { get; set; }
    }
}
