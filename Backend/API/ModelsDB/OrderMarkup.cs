using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderMarkup
    {
        public int OrderMarkupId { get; set; }
        public int? OrderMarkupTypeId { get; set; }
        public decimal? Markup { get; set; }
        public int? MarkupCurrency { get; set; }
        public decimal? MarkupExchangeRate { get; set; }
        public int? OrderId { get; set; }

        public virtual Currency MarkupCurrencyNavigation { get; set; }
        public virtual Order Order { get; set; }
    }
}
