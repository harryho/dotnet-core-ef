using System;
using System.Collections.Generic;

namespace dotnet_ef_demo.Data
{
    public partial class CustCustDemographics
    {
        public string CustId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
