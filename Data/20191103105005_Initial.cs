using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_ef_demo.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(type: "varchar(15)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    picture = table.Column<byte[]>(type: "blob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    custId = table.Column<string>(type: "varchar(15)", nullable: false),
                    companyName = table.Column<string>(type: "varchar(40)", nullable: false),
                    contactName = table.Column<string>(type: "varchar(30)", nullable: true),
                    contactTitle = table.Column<string>(type: "varchar(30)", nullable: true),
                    address = table.Column<string>(type: "varchar(60)", nullable: true),
                    city = table.Column<string>(type: "varchar(15)", nullable: true),
                    region = table.Column<string>(type: "varchar(15)", nullable: true),
                    postalCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    country = table.Column<string>(type: "varchar(15)", nullable: true),
                    phone = table.Column<string>(type: "varchar(24)", nullable: true),
                    mobile = table.Column<string>(type: "varchar(24)", nullable: true),
                    email = table.Column<string>(type: "varchar(225)", nullable: true),
                    fax = table.Column<string>(type: "varchar(24)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.custId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDemographics",
                columns: table => new
                {
                    customerTypeId = table.Column<string>(type: "varchar(10)", nullable: false),
                    customerDesc = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.customerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    employeeId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    lastname = table.Column<string>(type: "varchar(20)", nullable: false),
                    firstname = table.Column<string>(type: "varchar(10)", nullable: false),
                    title = table.Column<string>(type: "varchar(30)", nullable: true),
                    titleOfCourtesy = table.Column<string>(type: "varchar(25)", nullable: true),
                    birthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    hireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    address = table.Column<string>(type: "varchar(60)", nullable: true),
                    city = table.Column<string>(type: "varchar(15)", nullable: true),
                    region = table.Column<string>(type: "varchar(15)", nullable: true),
                    postalCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    country = table.Column<string>(type: "varchar(15)", nullable: true),
                    phone = table.Column<string>(type: "varchar(24)", nullable: true),
                    extension = table.Column<string>(type: "varchar(4)", nullable: true),
                    mobile = table.Column<string>(type: "varchar(24)", nullable: true),
                    email = table.Column<string>(type: "varchar(225)", nullable: true),
                    photo = table.Column<byte[]>(type: "blob", nullable: true),
                    notes = table.Column<byte[]>(type: "blob", nullable: true),
                    mgrId = table.Column<int>(type: "int(11)", nullable: true),
                    photoPath = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.employeeId);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    regionId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    regiondescription = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.regionId);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    shipperId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    companyName = table.Column<string>(type: "varchar(40)", nullable: false),
                    phone = table.Column<string>(type: "varchar(44)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.shipperId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    supplierId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    companyName = table.Column<string>(type: "varchar(40)", nullable: false),
                    contactName = table.Column<string>(type: "varchar(30)", nullable: true),
                    contactTitle = table.Column<string>(type: "varchar(30)", nullable: true),
                    address = table.Column<string>(type: "varchar(60)", nullable: true),
                    city = table.Column<string>(type: "varchar(15)", nullable: true),
                    region = table.Column<string>(type: "varchar(15)", nullable: true),
                    postalCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    country = table.Column<string>(type: "varchar(15)", nullable: true),
                    phone = table.Column<string>(type: "varchar(24)", nullable: true),
                    email = table.Column<string>(type: "varchar(225)", nullable: true),
                    fax = table.Column<string>(type: "varchar(24)", nullable: true),
                    HomePage = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.supplierId);
                });

            migrationBuilder.CreateTable(
                name: "CustCustDemographics",
                columns: table => new
                {
                    custId = table.Column<string>(type: "varchar(5)", nullable: false),
                    customerTypeId = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.custId, x.customerTypeId });
                    table.ForeignKey(
                        name: "CustCustDemographics_ibfk_1",
                        column: x => x.custId,
                        principalTable: "Customer",
                        principalColumn: "custId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "CustCustDemographics_ibfk_2",
                        column: x => x.customerTypeId,
                        principalTable: "CustomerDemographics",
                        principalColumn: "customerTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Territory",
                columns: table => new
                {
                    territoryId = table.Column<string>(type: "varchar(20)", nullable: false),
                    territorydescription = table.Column<string>(type: "varchar(50)", nullable: false),
                    regionId = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territory", x => x.territoryId);
                    table.ForeignKey(
                        name: "Territory_ibfk_1",
                        column: x => x.regionId,
                        principalTable: "Region",
                        principalColumn: "regionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrder",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    custId = table.Column<string>(type: "varchar(15)", nullable: false),
                    employeeId = table.Column<int>(type: "int(11)", nullable: true),
                    orderDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    requiredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    shippedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    shipperid = table.Column<int>(type: "int(11)", nullable: false),
                    freight = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    shipName = table.Column<string>(type: "varchar(40)", nullable: true),
                    shipAddress = table.Column<string>(type: "varchar(60)", nullable: true),
                    shipCity = table.Column<string>(type: "varchar(15)", nullable: true),
                    shipRegion = table.Column<string>(type: "varchar(15)", nullable: true),
                    shipPostalCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    shipCountry = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.orderId, x.custId });
                    table.ForeignKey(
                        name: "SalesOrder_ibfk_2",
                        column: x => x.custId,
                        principalTable: "Customer",
                        principalColumn: "custId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "SalesOrder_ibfk_1",
                        column: x => x.shipperid,
                        principalTable: "Shipper",
                        principalColumn: "shipperId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productName = table.Column<string>(type: "varchar(40)", nullable: false),
                    supplierId = table.Column<int>(type: "int(11)", nullable: true),
                    categoryId = table.Column<int>(type: "int(11)", nullable: true),
                    quantityPerUnit = table.Column<string>(type: "varchar(20)", nullable: true),
                    unitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    unitsInStock = table.Column<short>(type: "smallint(6)", nullable: true),
                    unitsOnOrder = table.Column<short>(type: "smallint(6)", nullable: true),
                    reorderLevel = table.Column<short>(type: "smallint(6)", nullable: true),
                    discontinued = table.Column<string>(type: "char(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productId);
                    table.ForeignKey(
                        name: "Product_ibfk_2",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Product_ibfk_1",
                        column: x => x.supplierId,
                        principalTable: "Supplier",
                        principalColumn: "supplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTerritory",
                columns: table => new
                {
                    employeeId = table.Column<int>(type: "int(11)", nullable: false),
                    territoryId = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.employeeId, x.territoryId });
                    table.ForeignKey(
                        name: "EmployeeTerritory_ibfk_1",
                        column: x => x.employeeId,
                        principalTable: "Employee",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "EmployeeTerritory_ibfk_2",
                        column: x => x.territoryId,
                        principalTable: "Territory",
                        principalColumn: "territoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    orderDetailId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    orderId = table.Column<int>(type: "int(11)", nullable: false),
                    productId = table.Column<int>(type: "int(11)", nullable: false),
                    unitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    quantity = table.Column<short>(type: "smallint(6)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.orderDetailId);
                    table.ForeignKey(
                        name: "OrderDetail_ibfk_2",
                        column: x => x.productId,
                        principalTable: "Product",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "customerTypeId",
                table: "CustCustDemographics",
                column: "customerTypeId");

            migrationBuilder.CreateIndex(
                name: "territoryId",
                table: "EmployeeTerritory",
                column: "territoryId");

            migrationBuilder.CreateIndex(
                name: "orderId",
                table: "OrderDetail",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "productId",
                table: "OrderDetail",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "categoryId",
                table: "Product",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "supplierId",
                table: "Product",
                column: "supplierId");

            migrationBuilder.CreateIndex(
                name: "custId",
                table: "SalesOrder",
                column: "custId");

            migrationBuilder.CreateIndex(
                name: "shipperid",
                table: "SalesOrder",
                column: "shipperid");

            migrationBuilder.CreateIndex(
                name: "regionId",
                table: "Territory",
                column: "regionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustCustDemographics");

            migrationBuilder.DropTable(
                name: "EmployeeTerritory");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "SalesOrder");

            migrationBuilder.DropTable(
                name: "CustomerDemographics");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Territory");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
