using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceRiskAssessment.DataAccessLayer.Migrations
{
    public partial class AddPersonalPropertyEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirTransports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClimatZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Functionality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreviousAccidents = table.Column<bool>(type: "bit", nullable: false),
                    ManifactureYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityEquipmenPossession = table.Column<bool>(type: "bit", nullable: false),
                    TechnicalServiceability = table.Column<bool>(type: "bit", nullable: false),
                    DistanceTraveled = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    RegisteredCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirTransports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEnterprises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurposeOfTheEnterprise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreviousAccidents = table.Column<bool>(type: "bit", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireExtinguishers = table.Column<bool>(type: "bit", nullable: false),
                    EmergencyExit = table.Column<bool>(type: "bit", nullable: false),
                    SquareFeet = table.Column<double>(type: "float", nullable: false),
                    AlarmSystem = table.Column<bool>(type: "bit", nullable: false),
                    GasBottles = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEnterprises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommercialProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreviousAccidents = table.Column<bool>(type: "bit", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireExtinguishers = table.Column<bool>(type: "bit", nullable: false),
                    EmergencyExit = table.Column<bool>(type: "bit", nullable: false),
                    SquareFeet = table.Column<double>(type: "float", nullable: false),
                    AlarmSystem = table.Column<bool>(type: "bit", nullable: false),
                    GasBottles = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommercialProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResidentialBuildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreviousAccidents = table.Column<bool>(type: "bit", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireExtinguishers = table.Column<bool>(type: "bit", nullable: false),
                    EmergencyExit = table.Column<bool>(type: "bit", nullable: false),
                    SquareFeet = table.Column<double>(type: "float", nullable: false),
                    AlarmSystem = table.Column<bool>(type: "bit", nullable: false),
                    GasBottles = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentialBuildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeaTransports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClimatZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoesRoutePassesPirateZones = table.Column<bool>(type: "bit", nullable: false),
                    Functionality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfMovability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreviousAccidents = table.Column<bool>(type: "bit", nullable: false),
                    ManifactureYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityEquipmenPossession = table.Column<bool>(type: "bit", nullable: false),
                    TechnicalServiceability = table.Column<bool>(type: "bit", nullable: false),
                    DistanceTraveled = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    RegisteredCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeaTransports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehiclesByLand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parktronic = table.Column<bool>(type: "bit", nullable: false),
                    MostCommonRoutes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreviousAccidents = table.Column<bool>(type: "bit", nullable: false),
                    ManifactureYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityEquipmenPossession = table.Column<bool>(type: "bit", nullable: false),
                    TechnicalServiceability = table.Column<bool>(type: "bit", nullable: false),
                    DistanceTraveled = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    RegisteredCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclesByLand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VillaBuildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreviousAccidents = table.Column<bool>(type: "bit", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireExtinguishers = table.Column<bool>(type: "bit", nullable: false),
                    EmergencyExit = table.Column<bool>(type: "bit", nullable: false),
                    SquareFeet = table.Column<double>(type: "float", nullable: false),
                    AlarmSystem = table.Column<bool>(type: "bit", nullable: false),
                    GasBottles = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaBuildings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirTransports");

            migrationBuilder.DropTable(
                name: "BusinessEnterprises");

            migrationBuilder.DropTable(
                name: "CommercialProperties");

            migrationBuilder.DropTable(
                name: "ResidentialBuildings");

            migrationBuilder.DropTable(
                name: "SeaTransports");

            migrationBuilder.DropTable(
                name: "VehiclesByLand");

            migrationBuilder.DropTable(
                name: "VillaBuildings");
        }
    }
}
