using System.Collections.Generic;

namespace API.DTO
{
    public class LicenseDTO
    {
        public string LicenseTitle{get;set;}
        public IList<string> Motive{get;set;}
    }
}