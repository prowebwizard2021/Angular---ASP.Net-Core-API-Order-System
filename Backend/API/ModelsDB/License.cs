using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class License
    {
        public License()
        {
            LicenseAgentLicenses = new HashSet<LicenseAgentLicense>();
            Motives = new HashSet<Motive>();
        }

        public int LicenseId { get; set; }
        public string LicenseName { get; set; }
        public bool? WithholdingTaxConsidered { get; set; }

        public virtual ICollection<LicenseAgentLicense> LicenseAgentLicenses { get; set; }
        public virtual ICollection<Motive> Motives { get; set; }
    }
}
