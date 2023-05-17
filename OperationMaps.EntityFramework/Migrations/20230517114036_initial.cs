using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OperationMaps.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Capacitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Designation = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    DcVoltage = table.Column<double>(type: "REAL", nullable: true),
                    AcVoltage = table.Column<double>(type: "REAL", nullable: true),
                    ImpulseVoltage = table.Column<double>(type: "REAL", nullable: true),
                    SumVoltage = table.Column<double>(type: "REAL", nullable: true),
                    AcCurrent = table.Column<double>(type: "REAL", nullable: true),
                    ThroughCurrent = table.Column<double>(type: "REAL", nullable: true),
                    DischargeCurrent = table.Column<double>(type: "REAL", nullable: true),
                    ChargingTime = table.Column<string>(type: "TEXT", nullable: true),
                    ReactivePower = table.Column<double>(type: "REAL", nullable: true),
                    Maxfrequency = table.Column<double>(type: "REAL", nullable: true),
                    ImpulseDuration = table.Column<double>(type: "REAL", nullable: true),
                    AmbientTemperature = table.Column<int>(type: "INTEGER", nullable: true),
                    SuperHeatTemperature = table.Column<double>(type: "REAL", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Form4Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Designation = table.Column<string>(type: "TEXT", nullable: false),
                    InListTTZ = table.Column<string>(type: "TEXT", nullable: false),
                    LastEditions = table.Column<string>(type: "TEXT", nullable: true),
                    ResourceHours = table.Column<int>(type: "INTEGER", nullable: true),
                    LifeTimeYears = table.Column<int>(type: "INTEGER", nullable: true),
                    FrequencyRange = table.Column<string>(type: "TEXT", nullable: true),
                    SoundPressure = table.Column<int>(type: "INTEGER", nullable: true),
                    LineAcceleration = table.Column<string>(type: "TEXT", nullable: true),
                    LowPressure = table.Column<string>(type: "TEXT", nullable: true),
                    HighPressure = table.Column<string>(type: "TEXT", nullable: true),
                    LowTemperature = table.Column<string>(type: "TEXT", nullable: true),
                    HighTemperature = table.Column<string>(type: "TEXT", nullable: true),
                    HumidityPercent = table.Column<int>(type: "INTEGER", nullable: true),
                    HumidityCelcius = table.Column<string>(type: "TEXT", nullable: true),
                    Dew = table.Column<string>(type: "TEXT", nullable: true),
                    SpecialFactors = table.Column<string>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form4Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Capacitors");

            migrationBuilder.DropTable(
                name: "Form4Items");
        }
    }
}
