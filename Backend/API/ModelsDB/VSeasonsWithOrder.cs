using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VSeasonsWithOrder
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public double? SortNumber { get; set; }
        public string Title { get; set; }
    }
}
