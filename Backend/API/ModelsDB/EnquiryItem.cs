using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class EnquiryItem
    {
        public EnquiryItem()
        {
            EnquiryItemsMaterials = new HashSet<EnquiryItemsMaterial>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? AgentId { get; set; }
        public int? CurrencyEk { get; set; }
        public int? CurrencyOfGpSellingPrices { get; set; }
        public int? CurrencyPurchPrSurcharge { get; set; }
        public int? CurrencyVkClient { get; set; }
        public double? CustomerSellingPrice { get; set; }
        public bool? Deleted { get; set; }
        public string DescriptionShort { get; set; }
        public int? EnquiryId { get; set; }
        public DateTime? EnquirySentToFactoryOrAgent { get; set; }
        public double? ExchRatePurchPrSurcharge { get; set; }
        public double? ExchangeRateOfCustomerSellingPrice { get; set; }
        public double? ExchangeRateOfPurchasePrice { get; set; }
        public double? ExchangeRateofGpSellingPrices { get; set; }
        public int? FactoryId { get; set; }
        public string GeneralComments { get; set; }
        public int ItemId { get; set; }
        public decimal? PurchPrSurcharge { get; set; }
        public double? PurchasePrice1 { get; set; }
        public double? PurchasePrice2 { get; set; }
        public double? PurchasePrice3 { get; set; }
        public double? RateOfDuty { get; set; }
        public double? SellingPriceGp { get; set; }
        public double? SellingPriceGpInclIncoTerm { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string Country { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Currency CurrencyEkNavigation { get; set; }
        public virtual Currency CurrencyOfGpSellingPricesNavigation { get; set; }
        public virtual Currency CurrencyPurchPrSurchargeNavigation { get; set; }
        public virtual Currency CurrencyVkClientNavigation { get; set; }
        public virtual Enquiry Enquiry { get; set; }
        public virtual Factory Factory { get; set; }
        public virtual ICollection<EnquiryItemsMaterial> EnquiryItemsMaterials { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
