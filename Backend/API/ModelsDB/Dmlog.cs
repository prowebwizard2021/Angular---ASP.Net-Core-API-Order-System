using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Dmlog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTime Date { get; set; }
    }
}
