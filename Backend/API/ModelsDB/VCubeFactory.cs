using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class VCubeFactory
    {
        public string Name { get; set; }
        public int FactoryId { get; set; }
        public string Stadt { get; set; }
        public string Land { get; set; }
        public string Anschrift { get; set; }
        public string Bscistatus { get; set; }
        public string Bscistatus2 { get; set; }
        public string EMail { get; set; }
        public string Typ { get; set; }
        public string Kapazität { get; set; }
    }
}
