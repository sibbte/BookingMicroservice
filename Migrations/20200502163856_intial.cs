using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingMicroservice.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Cats = table.Column<Guid>(nullable: false),
                    Room = table.Column<Guid>(nullable: false),
                    Customer = table.Column<Guid>(nullable: false),
                    BookingMade = table.Column<DateTime>(nullable: false),
                    CheckedIn = table.Column<bool>(nullable: true),
                    CheckedOut = table.Column<bool>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CatsAmount = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    CCTV = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
