using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DKCRM.Data.Migrations
{
    /// <inheritdoc />
    public partial class baslangic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    DistrictCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Definations",
                columns: table => new
                {
                    DefinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Definations", x => x.DefinationID);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatuCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatuID);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    TelephoneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrefixCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.TelephoneID);
                });

            migrationBuilder.CreateTable(
                name: "Ticket_ATTs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ATTValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket_ATTs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBO = table.Column<bool>(type: "bit", nullable: true),
                    IsAgent = table.Column<bool>(type: "bit", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityCodeCityID = table.Column<int>(type: "int", nullable: false),
                    DistrictCodeCityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityCodeCityID",
                        column: x => x.CityCodeCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_DistrictCodeCityID",
                        column: x => x.DistrictCodeCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonelIDUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_PersonelIDUserID",
                        column: x => x.PersonelIDUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "InDate", "IsActive" },
                values: new object[] { 1, "Şikayet", new DateTime(2023, 9, 7, 23, 41, 17, 55, DateTimeKind.Local).AddTicks(6304), false });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "Description", "Discriminator", "InDate" },
                values: new object[] { 1, "Adana", "City", new DateTime(2023, 9, 7, 23, 41, 17, 55, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "RequestID", "DisplayFlag", "InDate", "RequestName" },
                values: new object[] { 1, false, new DateTime(2023, 9, 7, 23, 41, 17, 55, DateTimeKind.Local).AddTicks(6320), "Geç Teslim" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "InDate", "IsAdmin", "IsAgent", "IsBO", "Name", "Password", "SurName" },
                values: new object[,]
                {
                    { 1, "admin@kapan.com", new DateTime(2023, 9, 7, 23, 41, 17, 55, DateTimeKind.Local).AddTicks(6119), true, null, null, "Deniz", "010203", "Kapan" },
                    { 2, "bo@kapan.com", new DateTime(2023, 9, 7, 23, 41, 17, 55, DateTimeKind.Local).AddTicks(6138), null, null, true, "Deniz", "010203", "Kapan" },
                    { 3, "agent@kapan.com", new DateTime(2023, 9, 7, 23, 41, 17, 55, DateTimeKind.Local).AddTicks(6141), null, true, null, "Deniz", "010203", "Kapan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityCodeCityID",
                table: "Addresses",
                column: "CityCodeCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictCodeCityID",
                table: "Addresses",
                column: "DistrictCodeCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PersonelIDUserID",
                table: "Tickets",
                column: "PersonelIDUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Definations");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Ticket_ATTs");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
