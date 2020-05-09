using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace weatherMvc.Migrations
{
    public partial class AddResultTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "locationDataId",
                table: "WeatherData",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "time",
                table: "MinutelyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "time",
                table: "HourlyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "windGustTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "uvIndexTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "time",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "temperatureMinTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "temperatureMaxTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "temperatureLowTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "temperatureHighTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "sunsetTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "sunriseTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "precipIntensityMaxTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "apparentTemperatureMinTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "apparentTemperatureMaxTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "apparentTemperatureLowTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "apparentTemperatureHighTime",
                table: "DailyData",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<long>(
                name: "time",
                table: "Currently",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    locationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<double>(nullable: false),
                    lng = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.locationId);
                });

            migrationBuilder.CreateTable(
                name: "LocationData",
                columns: table => new
                {
                    locationDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(nullable: true),
                    searchAddress = table.Column<string>(nullable: true),
                    searchLat = table.Column<double>(nullable: false),
                    searchLng = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationData", x => x.locationDataId);
                });

            migrationBuilder.CreateTable(
                name: "Northeast",
                columns: table => new
                {
                    northEastId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<double>(nullable: false),
                    lng = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northeast", x => x.northEastId);
                });

            migrationBuilder.CreateTable(
                name: "Southwest",
                columns: table => new
                {
                    southWestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<double>(nullable: false),
                    lng = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Southwest", x => x.southWestId);
                });

            migrationBuilder.CreateTable(
                name: "Bounds",
                columns: table => new
                {
                    boundsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    northEastId = table.Column<int>(nullable: true),
                    southWestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bounds", x => x.boundsId);
                    table.ForeignKey(
                        name: "FK_Bounds_Northeast_northEastId",
                        column: x => x.northEastId,
                        principalTable: "Northeast",
                        principalColumn: "northEastId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bounds_Southwest_southWestId",
                        column: x => x.southWestId,
                        principalTable: "Southwest",
                        principalColumn: "southWestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Viewport",
                columns: table => new
                {
                    viewportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    northEastId = table.Column<int>(nullable: true),
                    southWestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewport", x => x.viewportId);
                    table.ForeignKey(
                        name: "FK_Viewport_Northeast_northEastId",
                        column: x => x.northEastId,
                        principalTable: "Northeast",
                        principalColumn: "northEastId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viewport_Southwest_southWestId",
                        column: x => x.southWestId,
                        principalTable: "Southwest",
                        principalColumn: "southWestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Geometry",
                columns: table => new
                {
                    geometryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location_type = table.Column<string>(nullable: true),
                    boundsId = table.Column<int>(nullable: true),
                    locationId = table.Column<int>(nullable: true),
                    viewportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geometry", x => x.geometryId);
                    table.ForeignKey(
                        name: "FK_Geometry_Bounds_boundsId",
                        column: x => x.boundsId,
                        principalTable: "Bounds",
                        principalColumn: "boundsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Geometry_Location_locationId",
                        column: x => x.locationId,
                        principalTable: "Location",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Geometry_Viewport_viewportId",
                        column: x => x.viewportId,
                        principalTable: "Viewport",
                        principalColumn: "viewportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    resultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    formatted_address = table.Column<string>(nullable: true),
                    place_id = table.Column<string>(nullable: true),
                    geometryId = table.Column<int>(nullable: true),
                    locationDataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.resultId);
                    table.ForeignKey(
                        name: "FK_Result_Geometry_geometryId",
                        column: x => x.geometryId,
                        principalTable: "Geometry",
                        principalColumn: "geometryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_LocationData_locationDataId",
                        column: x => x.locationDataId,
                        principalTable: "LocationData",
                        principalColumn: "locationDataId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressComponent",
                columns: table => new
                {
                    addressComponentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    long_name = table.Column<string>(nullable: true),
                    short_name = table.Column<string>(nullable: true),
                    resultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressComponent", x => x.addressComponentId);
                    table.ForeignKey(
                        name: "FK_AddressComponent_Result_resultId",
                        column: x => x.resultId,
                        principalTable: "Result",
                        principalColumn: "resultId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultTypes",
                columns: table => new
                {
                    resultTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    result = table.Column<string>(nullable: true),
                    resultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultTypes", x => x.resultTypeId);
                    table.ForeignKey(
                        name: "FK_ResultTypes_Result_resultId",
                        column: x => x.resultId,
                        principalTable: "Result",
                        principalColumn: "resultId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherData_locationDataId",
                table: "WeatherData",
                column: "locationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressComponent_resultId",
                table: "AddressComponent",
                column: "resultId");

            migrationBuilder.CreateIndex(
                name: "IX_Bounds_northEastId",
                table: "Bounds",
                column: "northEastId");

            migrationBuilder.CreateIndex(
                name: "IX_Bounds_southWestId",
                table: "Bounds",
                column: "southWestId");

            migrationBuilder.CreateIndex(
                name: "IX_Geometry_boundsId",
                table: "Geometry",
                column: "boundsId");

            migrationBuilder.CreateIndex(
                name: "IX_Geometry_locationId",
                table: "Geometry",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_Geometry_viewportId",
                table: "Geometry",
                column: "viewportId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_geometryId",
                table: "Result",
                column: "geometryId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_locationDataId",
                table: "Result",
                column: "locationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultTypes_resultId",
                table: "ResultTypes",
                column: "resultId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_northEastId",
                table: "Viewport",
                column: "northEastId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_southWestId",
                table: "Viewport",
                column: "southWestId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_LocationData_locationDataId",
                table: "WeatherData",
                column: "locationDataId",
                principalTable: "LocationData",
                principalColumn: "locationDataId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_LocationData_locationDataId",
                table: "WeatherData");

            migrationBuilder.DropTable(
                name: "AddressComponent");

            migrationBuilder.DropTable(
                name: "ResultTypes");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Geometry");

            migrationBuilder.DropTable(
                name: "LocationData");

            migrationBuilder.DropTable(
                name: "Bounds");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Viewport");

            migrationBuilder.DropTable(
                name: "Northeast");

            migrationBuilder.DropTable(
                name: "Southwest");

            migrationBuilder.DropIndex(
                name: "IX_WeatherData_locationDataId",
                table: "WeatherData");

            migrationBuilder.DropColumn(
                name: "locationDataId",
                table: "WeatherData");

            migrationBuilder.AlterColumn<DateTime>(
                name: "time",
                table: "MinutelyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "time",
                table: "HourlyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "windGustTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "uvIndexTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "time",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "temperatureMinTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "temperatureMaxTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "temperatureLowTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "temperatureHighTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "sunsetTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "sunriseTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "precipIntensityMaxTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "apparentTemperatureMinTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "apparentTemperatureMaxTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "apparentTemperatureLowTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "apparentTemperatureHighTime",
                table: "DailyData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "time",
                table: "Currently",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
