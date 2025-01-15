using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingAreaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkingAreaTypeDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingAreaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkingAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkingAreaTypeID = table.Column<int>(type: "int", nullable: false),
                    ParkingAreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingAreas_ParkingAreaTypes_ParkingAreaTypeID",
                        column: x => x.ParkingAreaTypeID,
                        principalTable: "ParkingAreaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkingPermits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkingAreaID = table.Column<int>(type: "int", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingPermits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingPermits_ParkingAreas_ParkingAreaID",
                        column: x => x.ParkingAreaID,
                        principalTable: "ParkingAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkingAreas_ParkingAreaTypeID",
                table: "ParkingAreas",
                column: "ParkingAreaTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingPermits_ParkingAreaID",
                table: "ParkingPermits",
                column: "ParkingAreaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingPermits");

            migrationBuilder.DropTable(
                name: "ParkingAreas");

            migrationBuilder.DropTable(
                name: "ParkingAreaTypes");
        }
    }
}
