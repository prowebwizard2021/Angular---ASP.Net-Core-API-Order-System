using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Motive
    {
        public Motive()
        {
            OrderStyleMotives = new HashSet<OrderStyleMotive>();
        }

        public int MotiveId { get; set; }
        public string Title { get; set; }
        public int LicenseId { get; set; }
        public decimal? RoyaltyRateFob { get; set; }
        public decimal? RoyaltyRateDat { get; set; }

        public virtual License License { get; set; }
        public virtual ICollection<OrderStyleMotive> OrderStyleMotives { get; set; }
    }
}
