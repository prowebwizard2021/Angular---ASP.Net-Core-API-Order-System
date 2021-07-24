using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Order
    {
        public Order()
        {
            AdditionalOrderInformations = new HashSet<AdditionalOrderInformation>();
            AppointmentsOrders = new HashSet<AppointmentsOrder>();
            ArticleVariations = new HashSet<ArticleVariation>();
            FactoryConnections = new HashSet<FactoryConnection>();
            OrderGroups = new HashSet<OrderGroup>();
            OrderMarkups = new HashSet<OrderMarkup>();
            OrderStyles = new HashSet<OrderStyle>();
            OrderTasks = new HashSet<OrderTask>();
            ProductionStatuses = new HashSet<ProductionStatus>();
            WeAndWas = new HashSet<WeAndWa>();
        }

        public int Id { get; set; }
        public string AdditionalCode { get; set; }
        public string AdditionalTestRequirementsAccordingToCustomerContractReceipt { get; set; }
        public string ArticleDescriptionClient { get; set; }
        public string ArticleNumberOfClient { get; set; }
        public int? BuyingAgentId { get; set; }
        public double? CartonHeight { get; set; }
        public double? CartonLength { get; set; }
        public string CartonType { get; set; }
        public double? CartonWidth { get; set; }
        public double? CartonsPerLayer { get; set; }
        public double? CartonsPerPallet { get; set; }
        public int? ClientId { get; set; }
        public string CommentsProductionCountry { get; set; }
        public string CommentsRegardingCustomerClaimOrRework { get; set; }
        public string ContractNumberClient { get; set; }
        public bool? Critical { get; set; }
        public bool? CustomerClaim { get; set; }
        public DateTime? CustomerDeliveryDateFrom { get; set; }
        public DateTime? CustomerDeliveryDateTill { get; set; }
        public DateTime? DatePlacementOfOrderByClient { get; set; }
        public bool? Deleted { get; set; }
        public double? DeliveryStatusOfAccessories { get; set; }
        public string DescriptionOfPackaging { get; set; }
        public bool? EkFixed { get; set; }
        public int? EnquiryItemId { get; set; }
        public double? EstimatedNumberOfContainersNeeded { get; set; }
        public bool? FactoryFixed { get; set; }
        public string FunctionalLevelOfArticle { get; set; }
        public string GeneralComments { get; set; }
        public string GpRepresentative { get; set; }
        public string IdOrder { get; set; }
        public DateTime? InternalOrderMeeting { get; set; }
        public int ItemId { get; set; }
        public DateTime? LabOekoTexRequiredByCustomerUntil { get; set; }
        public DateTime? LabOekoTexSubmittedToCustomer { get; set; }
        public DateTime? LastShipmentOfOrder { get; set; }
        public DateTime? LatestEtaGermany { get; set; }
        public double? LayersPerPallet { get; set; }
        public string LcType { get; set; }
        public string MerchandiserQuakenbrueck { get; set; }
        public double? NumberOfArticlesPerCarton { get; set; }
        public double? NumberOfShippedCartons { get; set; }
        public double? NumberOfShippedPieces { get; set; }
        public string OekoTexApplicationSentOut { get; set; }
        public string OekoTexStandardControlPlan { get; set; }
        public DateTime? OrderDetailsAlignedWithCustomer { get; set; }
        public DateTime? OrderFixedWithSupplier { get; set; }
        public double? OrderQuantityDeliveredToClient { get; set; }
        public double? OrderQuantityPlaced { get; set; }
        public double? OrderQuantityReceivedFromSupplier { get; set; }
        public string OrderTaskConnector { get; set; }
        public double? ProductionStatusCutting { get; set; }
        public double? ProductionStatusPackaging { get; set; }
        public double? ProductionStatusSewing { get; set; }
        public double? QuantityOrderedByClient { get; set; }
        public bool? ReworkOfGoodsRequired { get; set; }
        public int? SeasonId { get; set; }
        public DateTime? ShipmentDateOriginal { get; set; }
        public DateTime? ShipmentDateRevised { get; set; }
        public string ShipmentDetailsDeliveryToCustomer { get; set; }
        public string ShipmentDetailsDeliveryToGp { get; set; }
        public string SizesFrom { get; set; }
        public string SizesTo { get; set; }
        public string SourceLocationOfTruckDeliveryToPort { get; set; }
        public DateTime? SupplierRevisedDeliveryDate { get; set; }
        public string TechnicianQuakenbrueck { get; set; }
        public bool? TermsOfDeliveryFixed { get; set; }
        public string TermsOfDeliveryToClient { get; set; }
        public string TermsOfDeliveryToGp { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }
        public string WebTitle { get; set; }
        public double? WeightPerCarton { get; set; }
        public string _3rdPartyInspectionCompany { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string ShipName { get; set; }
        public string LcState { get; set; }
        public string ProductLineId { get; set; }
        public DateTime? HandoverToAccounting { get; set; }
        public DateTime? TransferredOn { get; set; }
        public DateTime? CreationDateAccess { get; set; }
        public string ReferenceMainOrder { get; set; }
        public DateTime? DateOfFabric { get; set; }
        public string DuProLaboratory { get; set; }
        public DateTime? DateOfDuPro { get; set; }
        public DateTime? LatestDuProDate { get; set; }
        public string OrderKombi { get; set; }

        public virtual BuyingAgent BuyingAgent { get; set; }
        public virtual Client Client { get; set; }
        public virtual EnquiryItem EnquiryItem { get; set; }
        public virtual Season Season { get; set; }
        public virtual ICollection<AdditionalOrderInformation> AdditionalOrderInformations { get; set; }
        public virtual ICollection<AppointmentsOrder> AppointmentsOrders { get; set; }
        public virtual ICollection<ArticleVariation> ArticleVariations { get; set; }
        public virtual ICollection<FactoryConnection> FactoryConnections { get; set; }
        public virtual ICollection<OrderGroup> OrderGroups { get; set; }
        public virtual ICollection<OrderMarkup> OrderMarkups { get; set; }
        public virtual ICollection<OrderStyle> OrderStyles { get; set; }
        public virtual ICollection<OrderTask> OrderTasks { get; set; }
        public virtual ICollection<ProductionStatus> ProductionStatuses { get; set; }
        public virtual ICollection<WeAndWa> WeAndWas { get; set; }
    }
}
