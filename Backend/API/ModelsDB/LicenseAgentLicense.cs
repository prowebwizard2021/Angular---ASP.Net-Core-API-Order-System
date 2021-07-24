using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class LicenseAgentLicense
    {
        public int LicenseAgentLicenseId { get; set; }
        public int? LicenseId { get; set; }
        public int? LicenseAgentId { get; set; }
        public decimal? AgentFee { get; set; }

        public virtual License License { get; set; }
        public virtual LicenseAgent LicenseAgent { get; set; }
    }
}
