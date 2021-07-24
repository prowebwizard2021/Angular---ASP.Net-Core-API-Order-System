using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Currency
    {
        public Currency()
        {
            EnquiryItemCurrencyEkNavigations = new HashSet<EnquiryItem>();
            EnquiryItemCurrencyOfGpSellingPricesNavigations = new HashSet<EnquiryItem>();
            EnquiryItemCurrencyPurchPrSurchargeNavigations = new HashSet<EnquiryItem>();
            EnquiryItemCurrencyVkClientNavigations = new HashSet<EnquiryItem>();
            ExchangeAcceptances = new HashSet<ExchangeAcceptance>();
            ForwardExchangeDealings = new HashSet<ForwardExchangeDealing>();
            MaterialFeatures = new HashSet<MaterialFeature>();
            OrderMarkups = new HashSet<OrderMarkup>();
            OrderStyleCurrencyPurchasePriceNavigations = new HashSet<OrderStyle>();
            OrderStyleCurrencySellingPriceNavigations = new HashSet<OrderStyle>();
        }

        public int Id { get; set; }
        public double? ExchangeRate { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<EnquiryItem> EnquiryItemCurrencyEkNavigations { get; set; }
        public virtual ICollection<EnquiryItem> EnquiryItemCurrencyOfGpSellingPricesNavigations { get; set; }
        public virtual ICollection<EnquiryItem> EnquiryItemCurrencyPurchPrSurchargeNavigations { get; set; }
        public virtual ICollection<EnquiryItem> EnquiryItemCurrencyVkClientNavigations { get; set; }
        public virtual ICollection<ExchangeAcceptance> ExchangeAcceptances { get; set; }
        public virtual ICollection<ForwardExchangeDealing> ForwardExchangeDealings { get; set; }
        public virtual ICollection<MaterialFeature> MaterialFeatures { get; set; }
        public virtual ICollection<OrderMarkup> OrderMarkups { get; set; }
        public virtual ICollection<OrderStyle> OrderStyleCurrencyPurchasePriceNavigations { get; set; }
        public virtual ICollection<OrderStyle> OrderStyleCurrencySellingPriceNavigations { get; set; }
    }
}
