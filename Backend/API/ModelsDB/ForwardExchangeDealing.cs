using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class ForwardExchangeDealing
    {
        public int Id { get; set; }
        public double? AmountForeignCurrency { get; set; }
        public string Bank { get; set; }
        public DateTime? CallAt { get; set; }
        public string Comments { get; set; }
        public string Company { get; set; }
        public int? CurrencyId { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? ExertionFrom { get; set; }
        public DateTime? ExertionTo { get; set; }
        public int ItemId { get; set; }
        public int? SeasonId { get; set; }
        public string Title { get; set; }
        public DateTime? Tradingdate { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Season Season { get; set; }
    }
}
