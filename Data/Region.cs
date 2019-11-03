using System;
using System.Collections.Generic;

namespace dotnet_ef_demo.Data
{
    public partial class Region
    {
        public Region()
        {
            Territory = new HashSet<Territory>();
        }

        public int RegionId { get; set; }
        public string Regiondescription { get; set; }

        public virtual ICollection<Territory> Territory { get; set; }
    }
}
