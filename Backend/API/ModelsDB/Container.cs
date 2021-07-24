using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Container
    {
        public Container()
        {
            AppointmentsContainers = new HashSet<AppointmentsContainer>();
            ContainerContents = new HashSet<ContainerContent>();
        }

        public int Id { get; set; }
        public string AtbNumber { get; set; }
        public string AtcNumber { get; set; }
        public string ContainerPin { get; set; }
        public string ContainerType { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? EstimatedTimeOfArrival { get; set; }
        public int ItemId { get; set; }
        public double? NumberOfArticlesInContainer { get; set; }
        public double? NumberOfCartonsInContainer { get; set; }
        public string ReturnOfEmptyContainer { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int? ShippingCompanyId { get; set; }
        public string Title { get; set; }
        public string Vessel { get; set; }
        public string Warehouse { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ShippingCompany ShippingCompany { get; set; }
        public virtual ICollection<AppointmentsContainer> AppointmentsContainers { get; set; }
        public virtual ICollection<ContainerContent> ContainerContents { get; set; }
    }
}
