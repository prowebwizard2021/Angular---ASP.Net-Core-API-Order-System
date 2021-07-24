using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class ContainerContent
    {
        public int Id { get; set; }
        public int? ContainerId { get; set; }
        public string DepartmentWeb { get; set; }
        public int ItemId { get; set; }
        public string OrderItemId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Container Container { get; set; }
    }
}
