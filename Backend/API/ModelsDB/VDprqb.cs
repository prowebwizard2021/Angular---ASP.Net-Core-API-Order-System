using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VDprqb
    {
        public int Dprqbid { get; set; }
        public int OrderId { get; set; }
        public DateTime? ReportAldiDate { get; set; }
        public DateTime? OnSaleDate { get; set; }
        public DateTime? RevisedEtd { get; set; }
        public DateTime? RevisedEta { get; set; }
        public int? StylesCount { get; set; }
        public string KnitWoven { get; set; }
        public string FabricsFrom { get; set; }
        public DateTime? PhotoSampleDueDate { get; set; }
        public DateTime? CdExDate { get; set; }
        public string TestingLab { get; set; }
        public DateTime? OrigSamplePickDate { get; set; }
        public DateTime? NewSamplePickDate { get; set; }
        public string SpshortResult { get; set; }
        public string SpfinalResult { get; set; }
        public string Frilab { get; set; }
        public DateTime? Fri1Date { get; set; }
        public int? Fri1Qty { get; set; }
        public string Fri1Result { get; set; }
        public DateTime? Fri2Date { get; set; }
        public int? Fri2Qty { get; set; }
        public string Fri2Result { get; set; }
        public DateTime? Fri3Date { get; set; }
        public int? Fri3Qty { get; set; }
        public string Fri3Result { get; set; }
        public string ForwarderFreight { get; set; }
        public string ForwarderDelivery { get; set; }
        public DateTime? BlreceivedDate { get; set; }
        public DateTime StatusDate { get; set; }
        public string Comment { get; set; }
        public string MerchandiserSupplier { get; set; }
        public DateTime? PhotoSampleRevisedDate { get; set; }
    }
}
