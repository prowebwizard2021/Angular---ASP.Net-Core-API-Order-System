using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class TaskInstancesEnquiry
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
