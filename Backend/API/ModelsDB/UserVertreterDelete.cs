using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class UserVertreterDelete
    {
        public string UserName { get; set; }
        public string Vertreter { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public bool? GesperrtRls { get; set; }
        public string Userprincipalname { get; set; }
    }
}
