using System.Collections.Generic;

namespace API.DTO
{
    public class OrderStyleDTO
    {
        public int Id{get;set;}
        public string Title{get;set;}
        public int QuantityPlaced{get;set;}
        public int QuantityOrdered{get;set;}
         //---------- Pricing
        public double? PurchasePrice1 {get;set;}
        public double? PurchasePrice2 {get;set;}
        public double? PurchasePrice3 {get;set;}
        public ShortDTO Currency {get;set;}
        public IList<ShortDTO> Currencies {get;set;}
        public double? ExchangeRatePurchasePrice{get;set;}
        public double? RateOfDutyPuchasePrice{get;set;}
        public decimal? EKAufschlag{get;set;}
        public ShortDTO CurrencyEKAufschlag{get;set;}
        public double? VKGP {get; set;}
        public double? VKGPNachLB {get; set;}
        public ShortDTO CurrencyVK {get;set;}
        public double? exchangeRateVK {get;set;}
        public bool? EKNotFixed{get;set;}
        public IList<LicenseDTO> Licenses {get;set;}
        public IList<LicenseDTO> AllLicenses {get;set;}
    }
}