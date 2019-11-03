using System;
using System.Collections.Generic;

namespace dotnet_ef_demo.Data
{
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            CustCustDemographics = new HashSet<CustCustDemographics>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<CustCustDemographics> CustCustDemographics { get; set; }
    }
}
