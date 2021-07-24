using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class ExchangeAcceptance
    {
        public int Id { get; set; }
        public double? AmountForeignCurrency { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? DateAcceptance { get; set; }
        public string Department { get; set; }
        public double? ExchangeRate { get; set; }
        public int ItemId { get; set; }
        public int? SeasonId { get; set; }
        public string Title { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Season Season { get; set; }
    }
}
