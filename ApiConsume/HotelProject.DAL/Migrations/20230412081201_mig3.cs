using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HotelProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                schema: "public",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Mail = table.Column<string>(type: "text", nullable: true),
                    Checkin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AdultCount = table.Column<string>(type: "text", nullable: true),
                    ChildCount = table.Column<string>(type: "text", nullable: true),
                    RoomCount = table.Column<string>(type: "text", nullable: true),
                    SpecialRequest = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings",
                schema: "public");
        }
    }
}
