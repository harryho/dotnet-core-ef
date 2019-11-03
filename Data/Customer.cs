using System;
using System.Collections.Generic;

namespace dotnet_ef_demo.Data
{
    public partial class Customer
    {
        public Customer()
        {
            CustCustDemographics = new HashSet<CustCustDemographics>();
            SalesOrder = new HashSet<SalesOrder>();
        }

        public string CustId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<CustCustDemographics> CustCustDemographics { get; set; }
        public virtual ICollection<SalesOrder> SalesOrder { get; set; }
    }
}
