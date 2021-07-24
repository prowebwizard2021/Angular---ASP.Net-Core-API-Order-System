using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderResultDatum
    {
        public int OrderItemId { get; set; }
        public Guid OrderWebId { get; set; }
        public int? EnquiryItemItemId { get; set; }
        public Guid? EnquiryItemWebId { get; set; }
        public int? EnquiryItemId { get; set; }
        public Guid? EnquiryWebId { get; set; }
        public string AdditionalCode { get; set; }
        public string ArticleDescription { get; set; }
        public string OrderNumber { get; set; }
        public string SeasonTitle { get; set; }
        public string ClientTitle { get; set; }
        public string ProductGroupTitle { get; set; }
        public DateTime? DeliveryDateFrom { get; set; }
        public DateTime? DeliveryDateTo { get; set; }
    }
}
