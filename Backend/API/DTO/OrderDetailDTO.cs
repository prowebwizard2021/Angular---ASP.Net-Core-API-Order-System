using System;
using System.Collections.Generic;

namespace API.DTO
{
    public class OrderDetailDTO
    {
        public int Id {get;set;}
        public string tmp_Inc { get; set; }
        public string tmp_Out { get; set; }
        public int OrderStatus{get;set;}
        //Header information
        public string OrderId { get; set; }
        public string AdditionalCode {get;set;}
        public string Title { get; set; }
        public string TitleEN{ get; set; }
        public double? QuantityOrderedByClient { get; set; }
        public double? QuantityPlacedAtFactory { get; set; }
        public double? CartonCount{get;set;}
        public ShortDTO Customer { get; set; }
        public IList<ShortDTO> Customers { get; set; }
        public string Season { get; set; }
        public IList<string> Seasons { get; set; }
        public DateTime? DeliveryDateFrom { get; set; }
        public DateTime? DeliveryDateTo { get; set; }
        public string ProductCategory { get; set; }
        public List<string> ProductCategories { get; set; }
        public int Styles{get;set;}
        public int? MainOrderID {get;set;}
        
        //---------- AssosiatedOrders
        public IList<AssosiatedOrdersDTO> OtherOrders  { get; set; }
        
        //---------- Factory
        public IList<ShortDTO> Factories {get;set;}
        public ShortDTO MainFactory{get;set;}
        public ShortDTO FactoryGroup{get;set;}
        public IList<ShortDTO> FactoryGroups{get;set;}
        public string Country{get;set;}
        public IList<string> Countries{get;set;}
        public bool? FactoryFixed{get;set;}
        
        //---------- Pricing
        public double? PurchasePrice1 {get;set;}
        public double? PurchasePrice2 {get;set;}
        public double? PurchasePrice3 {get;set;}
        public ShortDTO Currency {get;set;}
        public IList<ShortDTO> Currencies {get;set;}
        public double? ExchangeRatePurchasePrice{get;set;}
        public double? RateOfDutyPurchasePrice{get;set;}
        public decimal? EKAufschlag{get;set;}
        public ShortDTO CurrencyEKAufschlag{get;set;}
        public double? VKGP {get; set;}
        public double? VKGPNachLB {get; set;}
        public ShortDTO CurrencyVK {get;set;}
        public double? exchangeRateVK {get;set;}
        public bool? EKNotFixed{get;set;}
        //---------- Abwicklung
        public string MerchandiserQB{get;set;}
        public string PackingQB{get;set;}
        public DateTime? OrderPlacedAtSupplier{get;set;}


        //---------- Angebote A/B
        public ShortDTO TermsOfDeliveryIncoming { get; set; }
        public IList<ShortDTO> TermsOfDeliveryIncomings { get; set; }
        public ShortDTO TermsOfDeliveryOutgoing { get; set; }
        public IList<ShortDTO> TermsOfDeliveryOutgoings { get; set; }
        public bool? TermsOfDeliveryFixed {get;set;}

        //---------- Rechnungswesen
        public string TermsOfPayment {get;set;}
        public IList<string> TermsOfPayments {get;set;}
        public string LCStatus {get;set;}
        public IList<string> LCStatuses {get;set;}

        //---------- Laboratory
        public string TestingLab {get;set;}
        public IList<string> TestingLabs {get;set;}
 
        //---------- Beschaffung Lieferung
        public DateTime? OriginalSamplePick {get;set;}
        public DateTime? NewSamplePick {get;set;}
        public string SamplePickShortResult {get;set;}
       public List<string> SamplePickShortResults {get;set;}
        //---------- Verschiffung

        //Internes
        public List<string> Departments{get;set;}
        public string Department{get;set;}

        //AdditionalOrderInformationTable
        public string ProcurementQB { get; set; }
        public string MerchandiserSupplier { get; set; }
        public string QC { get; set; }
        public string KnitWoven { get; set; }
        public DateTime? FMReceivedDate { get; set; }
        public DateTime? CDexDate { get; set; }
        public string TestingLaboratory { get; set; }
        public DateTime?  RevisedETD { get; set; }
        public DateTime? LatestETA { get; set; }
        public string FabricsFromCountry { get; set; }
        public string friLab {get;set;}
        public List<string> friLabs {get;set;}
        public DateTime? fri1date { get; set; }
        public DateTime? Latestfridate { get; set; }
        public int? fri1Quantity { get; set; }
        public string fri1Result { get; set; }
        public DateTime? fri2date { get; set; }
        public int? fri2Quantity { get; set; }
        public string fri2Result { get; set; }
        public DateTime? fri3date { get; set; }
        public int? fri3Quantity { get; set; }
        public string fri3Result { get; set; }
        public DateTime? ReportAldiDate { get; set; }
        public string ForwarderFreight { get; set; }
        public string ForwarderDelivery { get; set; }
        public DateTime? BLReceivedDate { get; set; }
        public string Vessel { get; set; }
        public ShortDTO KeyAccounter { get; set; }
        public List<ShortDTO> KeyAccounters { get; set; }
        public decimal? InspectionCosts { get; set; }
        public decimal? AirFreightCosts { get; set; }
        public string SPFinalResult { get; set; }
        public DateTime? BA { get; set; }

        public List<OrderStyleDTO> OrderStyles {get;set;}
        public List<ShortDTO> OtherFactories { get; set; }

        public List<String> MarkupTypes {get{
                return new List<string>(){"First Markup", "Second Markup"};
            }
            }
        public List<String> MarkDownTypes {get{
                return new List<string>(){"First Markdown", "Second Markdown"};
            }
            }
        
        public List<MarkupDTO> Markups {get;set;}
        public List<MarkupDTO> Markdowns {get;set;}

        public string CustomerArticleNumber { get; set; }  
        public int? Lot { get; set; }  


        public DateTime? SupplierDeliveryDateOriginal { get; set; }
        public DateTime? SupplierDeliveryDateNew { get; set; }
        public DateTime? SupplierDeliveryDateLastPossibility { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? ShipmentDateNew { get; set; }
        public string Shipname { get; set; }
        public List<ShortDTO> EndCustomers {get;set;}
        public ShortDTO EndCustomer {get;set;}
        public bool? IsOrderWithoutFixedCustomer{get;set;}
    }
}
