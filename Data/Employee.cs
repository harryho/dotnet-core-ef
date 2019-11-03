using System;
using System.Collections.Generic;

namespace dotnet_ef_demo.Data
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeTerritory = new HashSet<EmployeeTerritory>();
        }

        public int EmployeeId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Notes { get; set; }
        public int? MgrId { get; set; }
        public string PhotoPath { get; set; }

        public virtual ICollection<EmployeeTerritory> EmployeeTerritory { get; set; }
    }
}
