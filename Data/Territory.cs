using System;
using System.Collections.Generic;

namespace dotnet_ef_demo.Data
{
    public partial class Territory
    {
        public Territory()
        {
            EmployeeTerritory = new HashSet<EmployeeTerritory>();
        }

        public string TerritoryId { get; set; }
        public string Territorydescription { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<EmployeeTerritory> EmployeeTerritory { get; set; }
    }
}
