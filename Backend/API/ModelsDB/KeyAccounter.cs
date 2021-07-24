using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class KeyAccounter
    {
        public int KeyAccounterId { get; set; }
        public string Title { get; set; }
        public bool Disabled { get; set; }
    }
}
