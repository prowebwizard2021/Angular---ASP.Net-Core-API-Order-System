using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderStyle
    {
        public OrderStyle()
        {
            OrderStyleMotives = new HashSet<OrderStyleMotive>();
        }

        public int OrderStylesId { get; set; }
        public string Title { get; set; }
        public int? QuantityPlacedAtFactory { get; set; }
        public int? OrderId { get; set; }
        public int? QuantityOrderedByCustomer { get; set; }
        public decimal? PurchasePrice1 { get; set; }
        public decimal? PurchasePrice2 { get; set; }
        public decimal? PurchasePrice3 { get; set; }
        public int? CurrencyPurchasePrice { get; set; }
        public bool? PurchasePriceNotFixed { get; set; }
        public decimal? RateOfDuty { get; set; }
        public decimal? GpsellingPrice { get; set; }
        public decimal? SellingPriceInclIncoTerm { get; set; }
        public int? CurrencySellingPrice { get; set; }
        public decimal? ExchangeRateSellingPrice { get; set; }

        public virtual Currency CurrencyPurchasePriceNavigation { get; set; }
        public virtual Currency CurrencySellingPriceNavigation { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<OrderStyleMotive> OrderStyleMotives { get; set; }
    }
}
