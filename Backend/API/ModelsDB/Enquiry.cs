using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Enquiry
    {
        public Enquiry()
        {
            EnquiriesMaterials = new HashSet<EnquiriesMaterial>();
            EnquiryItems = new HashSet<EnquiryItem>();
            EnquiryTasks = new HashSet<EnquiryTask>();
        }

        public int Id { get; set; }
        public string ArticleNumberOfClient { get; set; }
        public int? BuyingAgentId { get; set; }
        public int? ClientId { get; set; }
        public bool? Deleted { get; set; }
        public string Designer { get; set; }
        public DateTime? DocumentsReceivedFromSourcing { get; set; }
        public string EnquiryBasedOn { get; set; }
        public DateTime? EnquiryCompleted { get; set; }
        public DateTime? EnquiryInduced { get; set; }
        public string EnquiryTaskConnector { get; set; }
        public string GeneralComments { get; set; }
        public string IdEnquiry { get; set; }
        public int ItemId { get; set; }
        public DateTime? LaunchAtClient { get; set; }
        public DateTime? OfferMade { get; set; }
        public DateTime? PresentationUntil { get; set; }
        public string ProbableSellingPriceGp { get; set; }
        public string ProductLineOfEnquiry { get; set; }
        public double? QuantityOfEnquiry { get; set; }
        public long? ReferenceEnquiryId { get; set; }
        public string ResponsibleFromSourcing { get; set; }
        public int? SeasonId { get; set; }
        public string ShortInformationAboutMaterial { get; set; }
        public string ShrinkingFactorFromOffer { get; set; }
        public string ShrinkingFactorToOffer { get; set; }
        public string SupplierOfGpClient { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public Guid WebId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual BuyingAgent BuyingAgent { get; set; }
        public virtual Client Client { get; set; }
        public virtual Season Season { get; set; }
        public virtual ICollection<EnquiriesMaterial> EnquiriesMaterials { get; set; }
        public virtual ICollection<EnquiryItem> EnquiryItems { get; set; }
        public virtual ICollection<EnquiryTask> EnquiryTasks { get; set; }
    }
}
