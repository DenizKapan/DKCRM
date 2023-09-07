using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKCRM.Data.Migrations
{
    /// <inheritdoc />
    public partial class sondurum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonelIDID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestIdID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SolutionIDID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatuIDID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonelIDID",
                table: "Ticket_ATTs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketID1",
                table: "Ticket_ATTs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerIDID",
                table: "Telephones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityCodeID",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityCodeID",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerIDID",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictCodeID",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 26, 11, 596, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 26, 11, 596, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 26, 11, 596, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SolutionGroups",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 26, 11, 596, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 26, 11, 596, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 26, 11, 596, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 26, 11, 596, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PersonelIDID",
                table: "Tickets",
                column: "PersonelIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RequestIdID",
                table: "Tickets",
                column: "RequestIdID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SolutionIDID",
                table: "Tickets",
                column: "SolutionIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatuIDID",
                table: "Tickets",
                column: "StatuIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ATTs_PersonelIDID",
                table: "Ticket_ATTs",
                column: "PersonelIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ATTs_TicketID1",
                table: "Ticket_ATTs",
                column: "TicketID1");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_CustomerIDID",
                table: "Telephones",
                column: "CustomerIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityCodeID",
                table: "Cities",
                column: "CityCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityCodeID",
                table: "Addresses",
                column: "CityCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerIDID",
                table: "Addresses",
                column: "CustomerIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictCodeID",
                table: "Addresses",
                column: "DistrictCodeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityCodeID",
                table: "Addresses",
                column: "CityCodeID",
                principalTable: "Cities",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_DistrictCodeID",
                table: "Addresses",
                column: "DistrictCodeID",
                principalTable: "Cities",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerIDID",
                table: "Addresses",
                column: "CustomerIDID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Cities_CityCodeID",
                table: "Cities",
                column: "CityCodeID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_Customers_CustomerIDID",
                table: "Telephones",
                column: "CustomerIDID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_ATTs_Tickets_TicketID1",
                table: "Ticket_ATTs",
                column: "TicketID1",
                principalTable: "Tickets",
                principalColumn: "TicketID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_ATTs_Users_PersonelIDID",
                table: "Ticket_ATTs",
                column: "PersonelIDID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Requests_RequestIdID",
                table: "Tickets",
                column: "RequestIdID",
                principalTable: "Requests",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_SolutionGroups_SolutionIDID",
                table: "Tickets",
                column: "SolutionIDID",
                principalTable: "SolutionGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Status_StatuIDID",
                table: "Tickets",
                column: "StatuIDID",
                principalTable: "Status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_PersonelIDID",
                table: "Tickets",
                column: "PersonelIDID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityCodeID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_DistrictCodeID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerIDID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Cities_CityCodeID",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_Customers_CustomerIDID",
                table: "Telephones");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_ATTs_Tickets_TicketID1",
                table: "Ticket_ATTs");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_ATTs_Users_PersonelIDID",
                table: "Ticket_ATTs");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Requests_RequestIdID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_SolutionGroups_SolutionIDID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Status_StatuIDID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_PersonelIDID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PersonelIDID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_RequestIdID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_SolutionIDID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_StatuIDID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ATTs_PersonelIDID",
                table: "Ticket_ATTs");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ATTs_TicketID1",
                table: "Ticket_ATTs");

            migrationBuilder.DropIndex(
                name: "IX_Telephones_CustomerIDID",
                table: "Telephones");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CityCodeID",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityCodeID",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CustomerIDID",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_DistrictCodeID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PersonelIDID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "RequestIdID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SolutionIDID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "StatuIDID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PersonelIDID",
                table: "Ticket_ATTs");

            migrationBuilder.DropColumn(
                name: "TicketID1",
                table: "Ticket_ATTs");

            migrationBuilder.DropColumn(
                name: "CustomerIDID",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "CityCodeID",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityCodeID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CustomerIDID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DistrictCodeID",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "SolutionGroups",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "InDate",
                value: new DateTime(2023, 9, 6, 14, 24, 1, 36, DateTimeKind.Local).AddTicks(5576));
        }
    }
}
