using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class FactoryFeature
    {
        public int Id { get; set; }
        public int? FactoryId { get; set; }
        public int ItemId { get; set; }
        public string ContentTypeName { get; set; }
        public string NameOfMashineType { get; set; }
        public int? QuantityOfThisMashineType { get; set; }
        public int? ProductWithinPortfolioId { get; set; }
        public int? ProductLineOfMaterialId { get; set; }
        public string ProductLineOfFinishedGoods { get; set; }
        public string ProductionStage { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Factory Factory { get; set; }
        public virtual MaterialProductLine ProductLineOfMaterial { get; set; }
        public virtual ProductsInPortfolio ProductWithinPortfolio { get; set; }
    }
}
