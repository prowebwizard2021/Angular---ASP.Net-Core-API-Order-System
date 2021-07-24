using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VCubeReportNachVertreter
    {
        public string Id { get; set; }
        public string Idorder { get; set; }
        public string Abteilung { get; set; }
        public string Auftragsnummer { get; set; }
        public string Kunde { get; set; }
        public string Artikelbeschreibung { get; set; }
        public double? PcsStat { get; set; }
        public DateTime? AuslieferungVon { get; set; }
        public DateTime? AuslieferungBis { get; set; }
        public int? FactoryId { get; set; }
        public DateTime? Verschiffungsdatum { get; set; }
        public double? Vk { get; set; }
        public double? VkFw { get; set; }
        public string VkWährung { get; set; }
        public double? VkWechselkurs { get; set; }
        public double? EkEur { get; set; }
        public double? EkFw { get; set; }
        public string EkWährung { get; set; }
        public double? EkWechselkurs { get; set; }
        public string Produktgruppe { get; set; }
        public string KeyAccount { get; set; }
        public string TermOfDeliveryToGp { get; set; }
        public string Saison { get; set; }
        public double? SaisonSortierung { get; set; }
        public string Lctyp { get; set; }
        public string Lcstate { get; set; }
        public DateTime? AnlagedatumNorm { get; set; }
        public DateTime? Anlagedatum { get; set; }
        public bool? OrderstatusGelöscht { get; set; }
        public string DatenBis { get; set; }
        public string Datenquelle { get; set; }
        public DateTime DataAsOf { get; set; }
        public string SupplierOrder { get; set; }
        public string Kostenstelle { get; set; }
        public string Sachbearbeiter { get; set; }
        public string ShipName { get; set; }
        public DateTime? ShipmentDateOriginal { get; set; }
        public DateTime? ShipmentDateRevised { get; set; }
        public DateTime? SupplierRevisedDeliveryDate { get; set; }
        public double? NumberOfShippedCartons { get; set; }
        public string GeneralComments { get; set; }
        public string ArticleNumberOfClient { get; set; }
    }
}
