using System;
using System.Collections.Generic;

namespace dotnet_ef_demo.Data
{
    public partial class Shipper
    {
        public Shipper()
        {
            SalesOrder = new HashSet<SalesOrder>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<SalesOrder> SalesOrder { get; set; }
    }
}
