using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class LicenseAgent
    {
        public LicenseAgent()
        {
            LicenseAgentLicenses = new HashSet<LicenseAgentLicense>();
        }

        public int LicenseAgentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LicenseAgentLicense> LicenseAgentLicenses { get; set; }
    }
}
