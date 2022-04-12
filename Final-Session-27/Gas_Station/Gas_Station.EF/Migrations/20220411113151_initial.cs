using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gas_Station.EF.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employeess",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HireDateStart = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false),
                    HireDateEnd = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false),
                    SallaryPerMonth = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    EmployeeType = table.Column<int>(type: "int", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeess", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ItemType = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ledgers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Month = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    Expenses = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledgers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    EmployeeID = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    EmployeeID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    CustomerID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    TotalValue = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_CustomerID1",
                        column: x => x.CustomerID1,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Employeess_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employeess",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionLines",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    TransactionID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemID = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    ItemID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    NetValue = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false),
                    TotalValue = table.Column<decimal>(type: "decimal(18,2)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransactionLines_Items_ItemID1",
                        column: x => x.ItemID1,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLines_Transactions_TransactionID1",
                        column: x => x.TransactionID1,
                        principalTable: "Transactions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_ItemID1",
                table: "TransactionLines",
                column: "ItemID1");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_TransactionID1",
                table: "TransactionLines",
                column: "TransactionID1");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerID1",
                table: "Transactions",
                column: "CustomerID1");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_EmployeeID1",
                table: "Transactions",
                column: "EmployeeID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ledgers");

            migrationBuilder.DropTable(
                name: "TransactionLines");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employeess");
        }
    }
}
