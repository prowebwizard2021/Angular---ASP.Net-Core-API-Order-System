using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Dprsync
    {
        public int DprsyncId { get; set; }
        public string FileName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? NewRows { get; set; }
        public int? ModifiedRows { get; set; }
        public string Message { get; set; }
        public string Direction { get; set; }
    }
}
