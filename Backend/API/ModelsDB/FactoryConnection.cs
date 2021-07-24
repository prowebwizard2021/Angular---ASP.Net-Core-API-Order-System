using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class FactoryConnection
    {
        public int Id { get; set; }
        public double? DailyOutput { get; set; }
        public int? FactoryId { get; set; }
        public DateTime? FactoryWasReportedToCustomerOn { get; set; }
        public string IdTypeOfFactoryInvolvementId { get; set; }
        public int ItemId { get; set; }
        public int? OrderId { get; set; }
        public string ProductionStatusOfFactoryInvolvement { get; set; }
        public double? QuantityOfFabric { get; set; }
        public string UnitOfDailyOutput { get; set; }
        public string UnitOfFabricQuantity { get; set; }
        public Guid WebId { get; set; }
        public string WebTitle { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Factory Factory { get; set; }
        public virtual Order Order { get; set; }
    }
}
