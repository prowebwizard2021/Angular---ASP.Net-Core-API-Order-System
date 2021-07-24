using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.ModelsDB;
using Microsoft.EntityFrameworkCore;
using API.DTO;
using System.Threading;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
         DBContext _context = new DBContext();

        private static string _NOSELECTION = "- Please Select -";
        private static ShortDTO _Empty = new ShortDTO{Id = 0, Title  = _NOSELECTION};

        private static List<string> _TERMS_OF_PAYMENT = new List<string>(){_NOSELECTION, "T/T", "D/P","L/C"};
        private static List<string> _LCSTATUS = new List<string>(){_NOSELECTION, "eröffnet", "erledigt"};
        private static List<string> _PRODUCTGROUPS = new List<string>(){_NOSELECTION,"HAKA","DOB","Heimtex","Unisex","KOB","Sport","Dessous","Taschen" };
        private static List<string> _DEPARTMENTS = new List<string>(){_NOSELECTION, "DOB", "HAKA", "KIKO","Sport", "Lingerie", "Luggage", "Tchibo", "UK, AU"};
        private static List<string> _COUNTRIES = new List<string>(){_NOSELECTION, "Bangladesh", "China", "Myanmar", "India", "Pakistan", "Turkey", "Italy", "Laos"};
        private static List<string> _LABORATORIES = new List<string>() { _NOSELECTION, "Labtech", "BV"};
        private static List<string> _RESULTS = new List<string>() { _NOSELECTION, "pass", "fail"};

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<OrderOverviewDTO> Get()
        {
            List<Order> orders = _context.Orders.Where(x=>x.Deleted==true)
             .Include(x=> x.Season)
             .Include(x=> x.Client)
             .ToList();
            
            List<OrderOverviewDTO> dtos = new List<OrderOverviewDTO>();
             
            foreach(Order o in orders)
            {
                OrderOverviewDTO dto  = new OrderOverviewDTO();
                dto.Customer = o.Client == null ? "" : o.Client.Title;
                dto.Season = o.Season == null ? "" : o.Season.Title;
                dto.ProductGroup = o.ProductLineId;
                dto.Title = o.Title;
                dto.OrderId = o.IdOrder + o.AdditionalCode;
                dto.Id = o.Id;
                dtos.Add(dto);
            }
            
            return dtos;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetailDTO>>Get(int id, CancellationToken cancellationToken = default) 
        {
            DBContext context = new DBContext();


            if(id > 0 && !await context.Orders.AnyAsync(p => p.Id == id))
            {
                return NotFound();
            }

            List<ShortDTO> todIncoming = context.IncomingTermsOfDeliveries.Select(y=>new ShortDTO{Title =y.Title, Id = y.Id }).ToList();
            List<ShortDTO> todOutgoing = context.TermsOfDeliveries.Select(y=>new ShortDTO{Title =y.Title, Id = y.Id }).ToList();
            List<ShortDTO> endCustomers = context.EndCustomers.Select(x=> new ShortDTO{Id = x.EndCustomerId, Title = x.Title}).ToList();
            List<ShortDTO> keyAccounters = context.KeyAccounters.Select(y=>new ShortDTO{ Id =  y.KeyAccounterId, Title = y.Title}).ToList();
            
            todIncoming.Insert(0, _Empty);
            todOutgoing.Insert(0, _Empty);
            endCustomers.Insert(0, _Empty);
            keyAccounters.Insert(0, _Empty);
            OrderDetailDTO order = null;
            
            if(id > 0)
            order = await context.Orders
                .AsNoTracking()
                .Where(x=>x.Id==id)
                .Include(x=>x.Client)
                .Include(x=>x.Season)
                .Include(x=>x.EnquiryItem)
                .Include(x=>x.FactoryConnections)
                .Select(o => new OrderDetailDTO {
                    Customer = o.Client == null ? _Empty : new ShortDTO{Id = o.Client.Id, Title = o.Client.Title},
                    Season = o.Season.Title,
                    ProductCategory = o.ProductLineId,
                    Title = o.Title,
                    OrderId = o.IdOrder,
                    Id = o.Id,
                    Department = o.WebTitle,
                    DeliveryDateFrom = o.CustomerDeliveryDateFrom,
                    DeliveryDateTo = o.CustomerDeliveryDateTill,
                    // OrderStatus = o. OrderStatus,
                    QuantityOrderedByClient = o. QuantityOrderedByClient,
                    QuantityPlacedAtFactory = o.OrderQuantityPlaced,
                    CustomerArticleNumber = o.ArticleNumberOfClient,
                    CartonCount = o.NumberOfShippedCartons,
                    // Styles = o.Styles,
                    ShipmentDate = o.ShipmentDateOriginal,
                    MainFactory = o.EnquiryItem.FactoryId == null ? _Empty : context.Factories.Select(x => new ShortDTO { Id = x.Id, Title = x.Title }).First(x=> x.Id == o.EnquiryItem.FactoryId),
                    FactoryGroup = o.EnquiryItem.AgentId == null  ? _Empty : context.Agents.Select(x => new ShortDTO { Id = x.Id, Title = x.Title }).First(x=> x.Id == o.EnquiryItem.AgentId),
                    Country = o.EnquiryItem.Country,
                    FactoryFixed = o.FactoryFixed,
                    PurchasePrice1 = o.EnquiryItem.PurchasePrice1,
                    PurchasePrice2 = o.EnquiryItem.PurchasePrice2,
                    PurchasePrice3 = o.EnquiryItem.PurchasePrice3,
                    Currency = o.EnquiryItem.CurrencyEk == null ? _Empty : context.Currencies.Select(x => new ShortDTO { Id = x.Id, Title = x.Title }).First(x=> x.Id == o.EnquiryItem.CurrencyEk),
                    CurrencyVK = o.EnquiryItem.CurrencyOfGpSellingPrices == null ? _Empty : context.Currencies.Select(x => new ShortDTO { Id = x.Id, Title = x.Title }).First(x=> x.Id == o.EnquiryItem.CurrencyOfGpSellingPrices),
                    CurrencyEKAufschlag = o.EnquiryItem.CurrencyPurchPrSurcharge == null ? _Empty : context.Currencies.Select(x => new ShortDTO { Id = x.Id, Title = x.Title }).First(x=> x.Id == o.EnquiryItem.CurrencyPurchPrSurcharge),
                    ExchangeRatePurchasePrice = o.EnquiryItem.ExchangeRateOfPurchasePrice,
                    RateOfDutyPurchasePrice = o.EnquiryItem.RateOfDuty,
                    EKAufschlag = o.EnquiryItem.CurrencyPurchPrSurcharge,
                    VKGP = o.EnquiryItem.SellingPriceGp,
                    VKGPNachLB = o.EnquiryItem.SellingPriceGpInclIncoTerm,
                    exchangeRateVK = o.EnquiryItem.ExchangeRateofGpSellingPrices,
                    EKNotFixed = o.EkFixed,
                    MerchandiserQB = o.MerchandiserQuakenbrueck,
                    OrderPlacedAtSupplier = o.DatePlacementOfOrderByClient,
                    TermsOfDeliveryFixed = o.TermsOfDeliveryFixed,
                    tmp_Inc = o.TermsOfDeliveryToGp,
                    tmp_Out = o.TermsOfDeliveryToClient,
                    TermsOfPayment = string.IsNullOrEmpty(o.LcType) ? _NOSELECTION : o.LcType,
                    TermsOfPayments = _TERMS_OF_PAYMENT,
                    LCStatus = string.IsNullOrEmpty(o.LcState) ? _NOSELECTION : o.LcState,
                    TestingLab = string.IsNullOrEmpty(o.DuProLaboratory) ? _NOSELECTION : o.DuProLaboratory,
                    ShipmentDateNew = o.ShipmentDateRevised,
                    LatestETA = o.LatestEtaGermany,
                    Shipname = o.ShipName,
                    SupplierDeliveryDateNew = o.SupplierRevisedDeliveryDate,
                    SupplierDeliveryDateLastPossibility = o.LatestEtaGermany,
                    OtherFactories = o.FactoryConnections.Select(x => new ShortDTO{Id = x.Factory.Id, Title = x.Factory.Title}).ToList()
                })
                .FirstOrDefaultAsync(cancellationToken)
                .ConfigureAwait(false);
            
            if(order == null)
            {
                order = new OrderDetailDTO
                {
                    Customer = _Empty, MainFactory = _Empty, FactoryGroup = _Empty, Country = _NOSELECTION, Currency = _Empty, CurrencyVK = _Empty, CurrencyEKAufschlag = _Empty
                    , TermsOfPayment = _NOSELECTION, LCStatus = _NOSELECTION, TestingLab = _NOSELECTION, Season = _NOSELECTION, Department = _NOSELECTION, Id = 0, KeyAccounter = _Empty
                    , EndCustomer = _Empty
                };
            }

            if(order.tmp_Inc != null)
            {
                order.TermsOfDeliveryIncoming = todIncoming.First(z=>z.Id == int.Parse(order.tmp_Inc));
            }
            else
            {
                order.TermsOfDeliveryIncoming = _Empty;
            }

             if(order.tmp_Out != null)
            {
                order.TermsOfDeliveryOutgoing = todOutgoing.First(z=>z.Id == int.Parse(order.tmp_Out));
            }
            else
            {
                order.TermsOfDeliveryOutgoing = _Empty;
            }

            order.KeyAccounters = keyAccounters;
            order.SamplePickShortResults = _RESULTS;
            order.Customers = context.Clients.AsNoTracking().Select( x=> new ShortDTO{Title = x.Title, Id  =x.Id}).ToList();
            order.Currencies = context.Currencies.AsNoTracking().Select( x=> new ShortDTO{Title = x.Title, Id  =x.Id}).ToList();
            order.Factories = context.Factories.AsNoTracking().Select( x=> new ShortDTO{Title = x.Title, Id  =x.Id}).ToList();
            order.FactoryGroups = context.Agents.AsNoTracking().Select( x=> new ShortDTO{Title = x.Title, Id  =x.Id}).ToList();
            order.TestingLabs = _LABORATORIES;
            order.friLabs = _LABORATORIES;
            order.LCStatuses = _LCSTATUS;
            order.TermsOfDeliveryIncomings = todIncoming;
            order.TermsOfDeliveryOutgoings = todOutgoing;
            order.Countries = _COUNTRIES;
            order.ProductCategories = _PRODUCTGROUPS;
            order.Departments = _DEPARTMENTS;
            order.Seasons = context.Seasons.AsNoTracking().Select( x=> x.Title).ToList();
            order.EndCustomers = endCustomers;
            order.OtherOrders = new List<AssosiatedOrdersDTO>();

            if(order.Id > 0)
            {
                 AdditionalOrderInformation additionalOrders = context.AdditionalOrderInformations.FirstOrDefault(x => x.OrdersId == order.Id);
                if (additionalOrders != null)
                {
                    order.OriginalSamplePick = additionalOrders.OriginalSamplePickDate;
                    order.NewSamplePick = additionalOrders.NewSamplePickDate;
                    order.SamplePickShortResult = additionalOrders.SamplePickShortResult;
                    order.ProcurementQB = additionalOrders.ProcurementQb;
                    order.MerchandiserQB = additionalOrders.MerchandiserSupplier;
                    order.QC = additionalOrders.Qc;
                    order.KnitWoven = additionalOrders.KnitWoven;
                    order.FMReceivedDate = additionalOrders.FmreceivedDate;
                    order.CDexDate = additionalOrders.CdexDate;
                    order.TestingLab = additionalOrders.TestingLaboratory;
                    order.TestingLabs = _LABORATORIES;
                    order.RevisedETD = additionalOrders.RevisedEtd;
                    order.LatestETA = additionalOrders.LatestEta;
                    order.FabricsFromCountry = additionalOrders.FabricsFromCountry;
                    order.friLabs = _LABORATORIES;
                    order.friLab = additionalOrders.Frilaboratory;
                    order.fri1date = additionalOrders.Fri1date;
                    order.fri1Quantity = additionalOrders.Fri1quantity;
                    order.fri1Result = additionalOrders.Fri1result;
                    order.fri2date = additionalOrders.Fri2date;
                    order.fri2Quantity = additionalOrders.Fri2quantity;
                    order.fri2Result = additionalOrders.Fri2result;
                    order.fri3date = additionalOrders.Fri3date;
                    order.fri3Quantity = additionalOrders.Fri3quantity;
                    order.fri3Result = additionalOrders.Fri3result;
                    order.ReportAldiDate = additionalOrders.ReportAldiDate;
                    order.ForwarderDelivery = additionalOrders.ForwarderDelivery;
                    order.ForwarderFreight = additionalOrders.ForwarderFreight;
                    order.BLReceivedDate  = additionalOrders.BlreceivedDate;
                    order.Vessel = additionalOrders.Vessel;
                    order.InspectionCosts = additionalOrders.InspectionCosts;
                    order.AirFreightCosts = additionalOrders.AirFreightCosts;
                    order.SPFinalResult = additionalOrders.SpfinalResult;
                    order.BA = additionalOrders.Ba;
                    order.MainOrderID = additionalOrders.MainOrderId;
                    order.KeyAccounter = additionalOrders.KeyAccounter != null ? keyAccounters.FirstOrDefault(x => x.Id == additionalOrders.KeyAccounter) : _Empty;
                    order.IsOrderWithoutFixedCustomer = additionalOrders.IsOrderWithoutFixedCustomer;
                    order.EndCustomer = additionalOrders.EndCustomerId != null ? endCustomers.FirstOrDefault(y=> y.Id == additionalOrders.EndCustomerId) : _Empty;
                    order.Lot = additionalOrders.Lot;
                    order.SupplierDeliveryDateOriginal = additionalOrders.SupplierDeliveryDateOriginal;
                    order.Latestfridate = additionalOrders.LatestFridate;
                    order.PackingQB = additionalOrders.PackingQb;
                }
                //Anschlüsse zum aktuellen Auftrag
                List<AssosiatedOrdersDTO> t3 = 
                    context.AdditionalOrderInformations.Where(x=> x.MainOrderId == order.Id).Include(x=> x.Orders).Include(y=> y.Orders.Client).Select(
                    x => new AssosiatedOrdersDTO { 
                        Customer = x.Orders.Client.Title
                        , DeliveryDate = x.Orders.CustomerDeliveryDateFrom != null ? x.Orders.CustomerDeliveryDateFrom.Value.ToString("dd.MM.yyyy") : "" + x.Orders.CustomerDeliveryDateFrom != null ? x.Orders.CustomerDeliveryDateFrom.Value.ToString("dd.MM.yyyy") : ""
                        , IsMain = false
                        , OrderId = x.OrdersId
                        , OrderNumber = x.Orders.IdOrder + x.Orders.AdditionalCode
                        , Quantity = x.Orders.QuantityOrderedByClient
                        }).ToList();
                
                foreach(AssosiatedOrdersDTO a in t3)
                {
                    order.OtherOrders.Add(a);
                }
                            
                // Anschlüsse zum gleichen Hauptauftrag wie aktueller Auftrag
                List<AssosiatedOrdersDTO> t1 = context.AdditionalOrderInformations.Where(x=> x.MainOrderId == order.MainOrderID && x.OrdersId != order.Id).Include(x=> x.Orders).Include(y=> y.Orders.Client).Select(
                    x => new AssosiatedOrdersDTO { 
                        Customer = x.Orders.Client.Title
                        , DeliveryDate = x.Orders.CustomerDeliveryDateFrom != null ? x.Orders.CustomerDeliveryDateFrom.Value.ToString("dd.MM.yyyy") : "" + x.Orders.CustomerDeliveryDateFrom != null ? x.Orders.CustomerDeliveryDateFrom.Value.ToString("dd.MM.yyyy") : ""
                        , IsMain = false
                        , OrderId = x.OrdersId
                        , OrderNumber = x.Orders.IdOrder + x.Orders.AdditionalCode
                        , Quantity = x.Orders.QuantityOrderedByClient
                        }).ToList();
                
                foreach(AssosiatedOrdersDTO a in t1)
                {
                    order.OtherOrders.Add(a);
                }
                // Hauptauftrag zum aktuellen Auftrag
                List<AssosiatedOrdersDTO> t2 = context.AdditionalOrderInformations.Where(x=> x.OrdersId == order.MainOrderID).Include(x=> x.Orders).Include(y=> y.Orders.Client).Select(
                    x => new AssosiatedOrdersDTO { 
                        Customer = x.Orders.Client.Title
                        , DeliveryDate = x.Orders.CustomerDeliveryDateFrom != null ? x.Orders.CustomerDeliveryDateFrom.Value.ToString("dd.MM.yyyy") : "" + x.Orders.CustomerDeliveryDateFrom != null ? x.Orders.CustomerDeliveryDateFrom.Value.ToString("dd.MM.yyyy") : ""
                        , IsMain = false
                        , OrderId = x.OrdersId
                        , OrderNumber = x.Orders.IdOrder + x.Orders.AdditionalCode
                        , Quantity = x.Orders.QuantityOrderedByClient
                        }).ToList();
                
                foreach(AssosiatedOrdersDTO a in t2)
                {
                    order.OtherOrders.Add(a);
                } 

                List<OrderStyle> stylesDB = context.OrderStyles.Where(x=> x.OrderId == order.Id).ToList();
                foreach(OrderStyle s in stylesDB)
                {
                    // order.OrderStyles.Add(MapOrderStyleToDTO(order, s));
                }
            }
            if(order.OrderStyles == null)
                order.OrderStyles = new List<OrderStyleDTO>();

            

            return Ok(order);
        }


        // private OrderStyleDTO MapOrderStyleToDTO(OrderDetailDTO orderDTO, OrderStyle source)
        // {
        //     OrderStyleDTO dto = new OrderStyleDTO();

        //     dto.Id = source.OrderStylesId;
        //     dto.Currencies = orderDTO.Currencies;
        //     dto.Currency = orderDTO.Currencies.First(x=> x.Id == source.CurrencyPurchasePrice);
        //     ToDo , CurrencyEKAufschlag = order.Currencies.First(x=> x.Id ==y.CurrencyPurchasePrice)
        //     dto.CurrencyVK = orderDTO.Currencies.First(x=> x.Id == source.CurrencySellingPrice);
        //     dto.EKAufschlag = null;
        //     dto.EKNotFixed = source.PurchasePriceNotFixed;
        //     dto.ExchangeRatePurchasePrice = null;
        //     dto.exchangeRateVK = source.ExchangeRateofGpSellingPrices; 
        //     dto.PurchasePrice1 = source.PurchasePrice1;
        //     dto.PurchasePrice2 = source.PurchasePrice2;
        //     dto.PurchasePrice3 = source.PurchasePrice3;
        //     dto.QuantityPlaced = source.QuantityPlacedAtFactory;
        //     dto.QuantityOrdered = source.QuantityOrderedByCustomer;
        //     dto.VKGP = source.SellingPriceInclIncoTerm;
        //     dto.VKGPNachLB = source.SellingPriceInclIncoTerm;
        //     dto.RateOfDutyPuchasePrice = source.RateOfDuty;
        //     dto.Title = source.Title;
        //     return dto;
        // }

        // private OrderStyle MapOrderStyleDtoToDB(OrderStyleDTO styleDTO, OrderDetailDTO orderDTO)
        // {
        //     OrderStyle style = new OrderStyle();
        //     style.OrderStylesId = styleDTO.Id;
        //     style.CurrencySellingPrice = styleDTO.CurrencyVK.Id;
        //     style.PurchasePriceNotFixed = styleDTO.EKNotFixed;
        //     style.ExchangeRateofGpSellingPrices = styleDTO.exchangeRateVK;
        //     style.PurchasePrice1 = styleDTO.PurchasePrice1;
        //     style.PurchasePrice2 = styleDTO.PurchasePrice2;
        //     style.PurchasePrice3 = styleDTO.PurchasePrice3;
        //     style.QuantityPlacedAtFactory = styleDTO.QuantityPlaced;
        //     style.QuantityOrderedByCustomer = styleDTO.QuantityOrdered;
        //     style.SellingPriceInclIncoTerm = styleDTO.VKGP;
        //     style.SellingPriceInclIncoTerm = styleDTO.VKGPNachLB;
        //     style.RateOfDuty = styleDTO.RateOfDutyPuchasePrice;
        //     style.Title = styleDTO.Title;
        //     return style;
        // }

        // CurrencyPurchasePrice (currency), CurrencySellingPrice (currency)
        // Production: factoryGroup, mainfactory ; neu anlage factory wird nicht gespeichert

        [AllowAnonymous]
        [HttpPut("{id:int}")]
        public async Task<ActionResult<int>> Put([FromRoute]int id, [FromBody]OrderDetailDTO dto, CancellationToken cancellationToken = default) 
        { 
            var result = new object();
                result = new { id = "9601" };
                return Content(JsonConvert.SerializeObject(result, Formatting.None), "text/json");
            // return Ok( 9601);

            Order orders = null;
            EnquiryItem ei = null;
            AdditionalOrderInformation aoi = null;
            
            if(id == 0)
            {
                orders = new Order();
                ei = new EnquiryItem();
                orders.EnquiryItem = ei;
                aoi = new AdditionalOrderInformation(){Orders = orders};
            }
            else
            {
                orders = _context.Orders.FirstOrDefault(x=>x.Id == id);
                
                if(orders != null)
                {
                    ei = _context.EnquiryItems.FirstOrDefault(x=> x.Id == orders.EnquiryItemId);
                    aoi = _context.AdditionalOrderInformations.FirstOrDefault(x=> x.OrdersId == orders.Id);
                }
            }
        
            if(ei == null)
                ei = new EnquiryItem();
                
            if(aoi == null)
                aoi = new AdditionalOrderInformation(){Orders = orders, OrdersId = orders.Id};
                    
            MapOrder(dto, ref orders, ref ei, ref aoi);

            using var transaction = await _context.Database.BeginTransactionAsync();


            try 
            {
                _context.Orders.Update(orders);
                await _context.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                return Ok();
            } catch(Exception ex) 
            {
                await transaction.RollbackAsync(cancellationToken);
                return Problem(ex.Message);
            }
        }

        private void MapOrder(OrderDetailDTO src, ref Order dest, ref EnquiryItem ei, ref AdditionalOrderInformation additionalOrder)
        {
            DateTime now = DateTime.Now;
            dest.IdOrder = src.OrderId;
            dest.Title = src.Title;
            dest.QuantityOrderedByClient = src.QuantityOrderedByClient;
            dest.OrderQuantityPlaced = src.QuantityPlacedAtFactory;
            dest.CustomerDeliveryDateFrom = src.DeliveryDateFrom;
            dest.CustomerDeliveryDateTill = src.DeliveryDateTo;
            dest.ArticleNumberOfClient = src.CustomerArticleNumber;
            
            dest.ShipmentDateRevised = src.ShipmentDateNew;
            dest.ShipmentDateOriginal = src.ShipmentDate;
            dest.LatestEtaGermany = src.SupplierDeliveryDateLastPossibility;
            dest.ShipName = src.Shipname;
            dest.SupplierRevisedDeliveryDate = src.SupplierDeliveryDateNew;
            dest.NumberOfShippedCartons = src.CartonCount;
            dest.LcType = (!string.IsNullOrEmpty(src.TermsOfPayment) && src.TermsOfPayment != _NOSELECTION) ? src.TermsOfPayment : null;

            dest.Modified = now;
            ei.Modified = now;
            
            if(!string.IsNullOrEmpty(src.ProductCategory) && src.ProductCategory != _NOSELECTION)
                dest.ProductLineId = src.ProductCategory;
            else 
                dest.ProductLineId = null;

            if(src.Customer != null && src.Customer.Id > 0)
            {
                Client client = _context.Clients.FirstOrDefault(x => x.Id == src.Customer.Id);
                dest.Client = client;
                dest.ClientId = client.Id;
            }
            else
            {
                dest.Client = null;
                dest.ClientId = null;
            }

            if(src.Season != null && src.Season != _NOSELECTION)
            {
                Season season = _context.Seasons.FirstOrDefault(x => x.Title == src.Season);
                dest.Season = season;
                dest.SeasonId = season.Id;
            }

            if(src.FactoryGroup != null && src.FactoryGroup.Title != _NOSELECTION)
            {
                ei.Agent = _context.Agents.First(x => x.Title == src.FactoryGroup.Title);
                ei.AgentId = ei.Agent.Id;
            } 
            else 
            {
                ei.Agent = null;
                ei.AgentId = null;
            }

            if(src.MainFactory != null && src.MainFactory.Title != _NOSELECTION)
            {
                ei.Factory = _context.Factories.First(x => x.Title == src.MainFactory.Title);
                ei.FactoryId = ei.Factory.Id;
            } 
            else 
            {
                ei.Factory = null;
                ei.FactoryId = null;
            }
            if(src.Country != null && src.Country != _NOSELECTION) {
                ei.Country = src.Country;
            } 
            else if (src.MainFactory != null && src.MainFactory.Title != _NOSELECTION )
            {
                if (ei.Factory != null && !string.IsNullOrEmpty(ei.Factory.Country)) 
                {
                    ei.Country = ei.Factory.Country;
                } 
            } 
            else if (src.FactoryGroup != null && src.FactoryGroup.Title != _NOSELECTION) 
            {
                if(ei.Agent != null && !string.IsNullOrEmpty(ei.Agent.Country)) 
                {
                    ei.Country = ei.Agent.Country;
                }
            }
            else
            {
                ei.Country = null;
            }

            List<Currency> currencies = _context.Currencies.ToList();
            // Einkaufspreis
            ei.PurchasePrice1 = src.PurchasePrice1 > 0 ? src.PurchasePrice1 : null;
            ei.PurchasePrice2 = src.PurchasePrice2 > 0? src.PurchasePrice2 : null;
            ei.PurchasePrice3 = src.PurchasePrice3 > 0 ? src.PurchasePrice3 : null;
            
            if(src.Currency != null && src.Currency.Title != _NOSELECTION) 
                ei.CurrencyEk = currencies.First(x=> x.Title.Equals(src.Currency.Title)).Id;
            else
                ei.CurrencyEk = null;

            ei.ExchangeRateOfPurchasePrice = src.ExchangeRatePurchasePrice > 0 ? src.ExchangeRatePurchasePrice : null;

            //Zollsatz
            ei.RateOfDuty = src.RateOfDutyPurchasePrice > 0 ? src.RateOfDutyPurchasePrice : null;

            //EK-Aufschlag
            ei.PurchPrSurcharge = src.EKAufschlag > 0 ? src.EKAufschlag : null;

            if(src.CurrencyEKAufschlag != null && src.CurrencyEKAufschlag.Title != _NOSELECTION)
                ei.CurrencyPurchPrSurcharge = currencies.First(x => x.Title.Equals(src.CurrencyEKAufschlag.Title)).Id;
            else
                ei.CurrencyPurchPrSurcharge = null;
            
            //Verkaufspreis
            if (src.CurrencyVK != null && src.CurrencyVK.Title != _NOSELECTION) 
                ei.CurrencyOfGpSellingPrices = currencies.First(x => x.Title.Equals(src.CurrencyVK.Title)).Id;
            else 
                ei.CurrencyOfGpSellingPrices = null;

            ei.SellingPriceGp = src.VKGP > 0 ? src.VKGP : null;
            ei.SellingPriceGpInclIncoTerm = src.VKGPNachLB > 0 ? src.VKGPNachLB : null;
            ei.ExchangeRateofGpSellingPrices = src.exchangeRateVK > 0 ? src.exchangeRateVK : null;

            dest.FactoryFixed = src.FactoryFixed;
            dest.EkFixed = src.EKNotFixed;
            dest.MerchandiserQuakenbrueck = src.MerchandiserQB;
            dest.DatePlacementOfOrderByClient = src.OrderPlacedAtSupplier;
            dest.TermsOfDeliveryFixed = src.TermsOfDeliveryFixed;
            dest.TermsOfDeliveryToGp = (src.TermsOfDeliveryIncoming !=null && src.TermsOfDeliveryIncoming != _Empty) ? src.TermsOfDeliveryIncoming.Id.ToString() : null ;
            dest.TermsOfDeliveryToClient = (src.TermsOfDeliveryOutgoing !=null && src.TermsOfDeliveryOutgoing != _Empty) ? src.TermsOfDeliveryOutgoing.Id.ToString() : null ;
            dest.LcState = ((!string.IsNullOrEmpty(src.LCStatus)) && src.LCStatus != _NOSELECTION) ? src.LCStatus : null ;
            dest.DuProLaboratory = src.TestingLab;
            dest.ItemId = dest.Id;
            dest.WebTitle = src.Department;
            //dest.Deleted = false;
            
            additionalOrder.OriginalSamplePickDate = src.OriginalSamplePick;
            additionalOrder.NewSamplePickDate = src.NewSamplePick;
            additionalOrder.SamplePickShortResult = (!string.IsNullOrEmpty(src.SamplePickShortResult) && src.SamplePickShortResult != _NOSELECTION) ? src.SamplePickShortResult : null;
            additionalOrder.ProcurementQb = src.ProcurementQB;
            additionalOrder.MerchandiserSupplier = src.MerchandiserQB;
            additionalOrder.Qc = src.QC;
            additionalOrder.KnitWoven = (!string.IsNullOrEmpty(src.KnitWoven) && src.KnitWoven != _NOSELECTION) ? src.KnitWoven : null;
            additionalOrder.FmreceivedDate = src.FMReceivedDate;
            additionalOrder.CdexDate = src.CDexDate;
            additionalOrder.TestingLaboratory = (!string.IsNullOrEmpty(src.TestingLab ) && src.TestingLab != _NOSELECTION) ? src.TestingLab  : null;

            additionalOrder.RevisedEtd = src.RevisedETD;
            additionalOrder.LatestEta = src.LatestETA;
            additionalOrder.FabricsFromCountry = src.FabricsFromCountry;

            additionalOrder.Frilaboratory = src.friLab;
            additionalOrder.Fri1date = src.fri1date ;
            additionalOrder.Fri1quantity = src.fri1Quantity;
            additionalOrder.Fri1result = (!string.IsNullOrEmpty(src.fri1Result) && src.fri1Result != _NOSELECTION) ? src.fri1Result : null;
            additionalOrder.Fri2date = src.fri2date ;
            additionalOrder.Fri2quantity = src.fri2Quantity;
            additionalOrder.Fri2result = (!string.IsNullOrEmpty(src.fri2Result) && src.fri2Result != _NOSELECTION) ? src.fri2Result : null;
            additionalOrder.Fri3date = src.fri3date ;
            additionalOrder.Fri3quantity = src.fri3Quantity;
            additionalOrder.Fri3result = (!string.IsNullOrEmpty(src.fri3Result) && src.fri3Result != _NOSELECTION) ? src.fri3Result : null;
            additionalOrder.ReportAldiDate = src.ReportAldiDate;
            additionalOrder.ForwarderDelivery = (!string.IsNullOrEmpty(src.ForwarderDelivery) && src.ForwarderDelivery != _NOSELECTION) ? src.ForwarderDelivery : null;
            additionalOrder.ForwarderFreight = (!string.IsNullOrEmpty(src.ForwarderFreight) && src.ForwarderFreight != _NOSELECTION) ? src.ForwarderFreight: null;
            additionalOrder.BlreceivedDate = src.BLReceivedDate;
            additionalOrder.Vessel = src.Vessel ;
            additionalOrder.InspectionCosts = src.InspectionCosts;
            additionalOrder.AirFreightCosts = src.AirFreightCosts;
            additionalOrder.SpfinalResult = (!string.IsNullOrEmpty(src.SPFinalResult) && src.SPFinalResult != _NOSELECTION) ? src.SPFinalResult : null;
            additionalOrder.Ba = src.BA;
            additionalOrder.IsOrderWithoutFixedCustomer = src.IsOrderWithoutFixedCustomer;
            additionalOrder.KeyAccounter = (src.KeyAccounter != null && src.KeyAccounter.Id > 0) ? src.KeyAccounter.Id : null;
            additionalOrder.EndCustomerId = (src.EndCustomer != null && src.EndCustomer.Id > 0) ? src.EndCustomer.Id : null;
            additionalOrder.Lot = src.Lot;
            additionalOrder.SupplierDeliveryDateOriginal = src.SupplierDeliveryDateOriginal;
            additionalOrder.LatestFridate = src.Latestfridate;
            additionalOrder.PackingQb = src.PackingQB;
            
            if (src.Department == "Sport")
            {
                dest.WebId = new Guid("E08D8ACC-E09A-4B68-AA58-5245F92B98EA");
            } else if (src.Department == "KIKO")
            {
                dest.WebId = new Guid("52EDC05A-9060-41B4-A696-2989341F7666");
            }else if (src.Department == "DOB")
            {
                dest.WebId = new Guid("4C146EC0-38C1-4682-9120-C067189376DE");
            }else if (src.Department == "Aldi USA")
            {
                dest.WebId = new Guid("FF52D6D7-B992-40EE-A35E-7ADFE9A4404E");
            }else if (src.Department == "Bags")
            {
                dest.WebId = new Guid("929481A2-76CF-4F47-8523-DEF01407826C");
            }else if (src.Department == "HAKA")
            {
                dest.WebId = new Guid("FD42EB2A-3640-42A6-986B-E8E5AF0A3358");
            }else if (src.Department == "Lingerie")
            {
                dest.WebId = new Guid("0E1077F2-29C8-41C7-8137-94EF63312050");
            }else if (src.Department == "Tchibo")
            {
                dest.WebId = new Guid("B2642F30-4151-4FAA-9452-291E4B1B6DF5");
            }else if (src.Department == "Aldi UK, AU")
            {
                dest.WebId = new Guid("04760AD8-4EAE-4DBC-BD6E-45FAF3399BCA");
            }
            ei.Deleted = false;
            ei.WebId = dest.WebId;
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute]int id, CancellationToken cancellationToken = default) 
        {
            DBContext context = new DBContext();
            Order order = context.Orders.FirstOrDefault(p=>p.Id == id);
            if(order == null){
                return NotFound();
            }
            order.Deleted = true;
            order.Modified = DateTime.Now;
            using var transaction = await context.Database.BeginTransactionAsync();
            try {
                context.Orders.Update(order);
                await context.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                return Ok();
            } catch(Exception ex) {
                await transaction.RollbackAsync(cancellationToken);
                return Problem(ex.Message);
            }
        }
        
    }
}
