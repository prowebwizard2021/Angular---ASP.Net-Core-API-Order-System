using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VProductStatusFabricInhouseStatus
    {
        public int ProductionStatusId { get; set; }
        public int? Accessories { get; set; }
        public int? Zipper { get; set; }
        public int? LinesRunning { get; set; }
        public string PcsSet { get; set; }
        public int? Knitting { get; set; }
        public int? Ironing { get; set; }
        public int? Cutting { get; set; }
        public int? Sewing { get; set; }
        public int? DailyOutput { get; set; }
        public int? WashSent { get; set; }
        public int? WashReceived { get; set; }
        public int? ItemsPacked { get; set; }
        public int? CartonsCompleted { get; set; }
        public int? CartonsShipped { get; set; }
        public string MotherVessel { get; set; }
        public int OrderId { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime? FabricEx { get; set; }
        public int? FabricInhouseStatus { get; set; }
        public DateTime? ProductionStart { get; set; }
        public long? RowNumber { get; set; }
    }
}
