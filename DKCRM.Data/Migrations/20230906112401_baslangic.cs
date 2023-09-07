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
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Definations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Definations", x => x.ID);
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SolutionGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatuCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrefixCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.ID);
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
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "InDate" },
                values: new object[] { 1, "Şikayet", new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "Description", "Discriminator", "InDate" },
                values: new object[] { 1, "Adana", "City", new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "ID", "DisplayFlag", "InDate", "RequestName" },
                values: new object[] { 1, false, new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5737), "Geç Teslim" });

            migrationBuilder.InsertData(
                table: "SolutionGroups",
                columns: new[] { "ID", "DisplayFlag", "InDate", "SolutionName" },
                values: new object[] { 1, true, new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5751), "BackOffice" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "InDate", "IsAdmin", "IsAgent", "IsBO", "Name", "Password", "SurName" },
                values: new object[,]
                {
                    { 1, "admin@kapan.com", new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5564), true, null, null, "Deniz", "010203", "Kapan" },
                    { 2, "bo@kapan.com", new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5575), null, null, true, "Deniz", "010203", "Kapan" },
                    { 3, "agent@kapan.com", new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5576), null, true, null, "Deniz", "010203", "Kapan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Definations");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "SolutionGroups");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Ticket_ATTs");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
