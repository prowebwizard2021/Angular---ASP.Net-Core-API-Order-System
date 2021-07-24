using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderStyleMotive
    {
        public int OrderStyleMotiveId { get; set; }
        public int? OrderStyleId { get; set; }
        public int? MotiveId { get; set; }

        public virtual Motive Motive { get; set; }
        public virtual OrderStyle OrderStyle { get; set; }
    }
}
