using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace dotnet_ef_demo.Data
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CustCustDemographics> CustCustDemographics { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeTerritory> EmployeeTerritory { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<SalesOrder> SalesOrder { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Territory> Territory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseMySql(ConfigurationManager.AppSetting.GetValue<String>("connectionString"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("categoryName")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<CustCustDemographics>(entity =>
            {
                entity.HasKey(e => new { e.CustId, e.CustomerTypeId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CustomerTypeId)
                    .HasName("customerTypeId");

                entity.Property(e => e.CustId)
                    .HasColumnName("custId")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.CustomerTypeId)
                    .HasColumnName("customerTypeId")
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.CustCustDemographics)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CustCustDemographics_ibfk_1");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.CustCustDemographics)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CustCustDemographics_ibfk_2");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PRIMARY");

                entity.Property(e => e.CustId)
                    .HasColumnName("custId")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("companyName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contactName")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("contactTitle")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(225)");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postalCode")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(15)");
            });

            modelBuilder.Entity<CustomerDemographics>(entity =>
            {
                entity.HasKey(e => e.CustomerTypeId)
                    .HasName("PRIMARY");

                entity.Property(e => e.CustomerTypeId)
                    .HasColumnName("customerTypeId")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CustomerDesc)
                    .HasColumnName("customerDesc")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birthDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(225)");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.HireDate)
                    .HasColumnName("hireDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MgrId)
                    .HasColumnName("mgrId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("blob");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("blob");

                entity.Property(e => e.PhotoPath)
                    .HasColumnName("photoPath")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postalCode")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TitleOfCourtesy)
                    .HasColumnName("titleOfCourtesy")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<EmployeeTerritory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.TerritoryId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.TerritoryId)
                    .HasName("territoryId");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("territoryId")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeTerritory)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EmployeeTerritory_ibfk_1");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.EmployeeTerritory)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EmployeeTerritory_ibfk_2");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("orderId");

                entity.HasIndex(e => e.ProductId)
                    .HasName("productId");

                entity.Property(e => e.OrderDetailId)
                    .HasColumnName("orderDetailId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unitPrice")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetail_ibfk_2");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("categoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("supplierId");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Discontinued)
                    .IsRequired()
                    .HasColumnName("discontinued")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("productName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.QuantityPerUnit)
                    .HasColumnName("quantityPerUnit")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnName("reorderLevel")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplierId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unitPrice")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.UnitsInStock)
                    .HasColumnName("unitsInStock")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UnitsOnOrder)
                    .HasColumnName("unitsOnOrder")
                    .HasColumnType("smallint(6)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("Product_ibfk_2");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("Product_ibfk_1");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId)
                    .HasColumnName("regionId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Regiondescription)
                    .IsRequired()
                    .HasColumnName("regiondescription")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.CustId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CustId)
                    .HasName("custId");

                entity.HasIndex(e => e.Shipperid)
                    .HasName("shipperid");

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderId")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustId)
                    .HasColumnName("custId")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Freight)
                    .HasColumnName("freight")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("orderDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequiredDate)
                    .HasColumnName("requiredDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipAddress)
                    .HasColumnName("shipAddress")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.ShipCity)
                    .HasColumnName("shipCity")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.ShipCountry)
                    .HasColumnName("shipCountry")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.ShipName)
                    .HasColumnName("shipName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.ShipPostalCode)
                    .HasColumnName("shipPostalCode")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ShipRegion)
                    .HasColumnName("shipRegion")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.ShippedDate)
                    .HasColumnName("shippedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Shipperid)
                    .HasColumnName("shipperid")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.SalesOrder)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SalesOrder_ibfk_2");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.SalesOrder)
                    .HasForeignKey(d => d.Shipperid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SalesOrder_ibfk_1");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.ShipperId)
                    .HasColumnName("shipperId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("companyName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(44)");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.SupplierId)
                    .HasColumnName("supplierId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("companyName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contactName")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("contactTitle")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(225)");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.HomePage).HasColumnType("text");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postalCode")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(15)");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.HasIndex(e => e.RegionId)
                    .HasName("regionId");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("territoryId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Territorydescription)
                    .IsRequired()
                    .HasColumnName("territorydescription")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Territory)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Territory_ibfk_1");
            });
        }
    }
}
