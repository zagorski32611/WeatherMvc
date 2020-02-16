using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace weatherMvc.Migrations
{
    public partial class WeatherClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlertDatas",
                columns: table => new
                {
                    alertDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    severity = table.Column<string>(nullable: true),
                    time = table.Column<DateTime>(nullable: false),
                    expires = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    uri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertDatas", x => x.alertDataId);
                });

            migrationBuilder.CreateTable(
                name: "Currentlies",
                columns: table => new
                {
                    currentlyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    time = table.Column<DateTime>(nullable: false),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true),
                    nearestStormDistance = table.Column<double>(nullable: false),
                    precipIntensity = table.Column<double>(nullable: false),
                    precipIntensityError = table.Column<double>(nullable: false),
                    precipProbability = table.Column<double>(nullable: false),
                    precipType = table.Column<string>(nullable: true),
                    temperature = table.Column<double>(nullable: false),
                    apparentTemperature = table.Column<double>(nullable: false),
                    dewPoint = table.Column<double>(nullable: false),
                    humidity = table.Column<double>(nullable: false),
                    pressure = table.Column<int>(nullable: false),
                    windSpeed = table.Column<double>(nullable: false),
                    windGust = table.Column<double>(nullable: false),
                    windBearing = table.Column<int>(nullable: false),
                    cloudCover = table.Column<double>(nullable: false),
                    uvIndex = table.Column<int>(nullable: false),
                    visibility = table.Column<int>(nullable: false),
                    ozone = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currentlies", x => x.currentlyId);
                });

            migrationBuilder.CreateTable(
                name: "Dailies",
                columns: table => new
                {
                    dailyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dailies", x => x.dailyId);
                });

            migrationBuilder.CreateTable(
                name: "DbFlags",
                columns: table => new
                {
                    flagsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    neareststation = table.Column<double>(nullable: false),
                    units = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbFlags", x => x.flagsId);
                });

            migrationBuilder.CreateTable(
                name: "Hourlies",
                columns: table => new
                {
                    hourlyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hourlies", x => x.hourlyId);
                });

            migrationBuilder.CreateTable(
                name: "Minutelies",
                columns: table => new
                {
                    minutelyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Minutelies", x => x.minutelyId);
                });

            migrationBuilder.CreateTable(
                name: "AlertRegions",
                columns: table => new
                {
                    alertRegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regions = table.Column<string>(nullable: true),
                    alertDataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertRegions", x => x.alertRegionId);
                    table.ForeignKey(
                        name: "FK_AlertRegions_AlertDatas_alertDataId",
                        column: x => x.alertDataId,
                        principalTable: "AlertDatas",
                        principalColumn: "alertDataId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyDatas",
                columns: table => new
                {
                    dailyDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    time = table.Column<DateTime>(nullable: false),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true),
                    sunriseTime = table.Column<DateTime>(nullable: false),
                    sunsetTime = table.Column<DateTime>(nullable: false),
                    moonPhase = table.Column<double>(nullable: false),
                    precipIntensity = table.Column<double>(nullable: false),
                    precipIntensityMax = table.Column<double>(nullable: false),
                    precipIntensityMaxTime = table.Column<DateTime>(nullable: false),
                    precipProbability = table.Column<double>(nullable: false),
                    precipType = table.Column<string>(nullable: true),
                    temperatureHigh = table.Column<double>(nullable: false),
                    temperatureHighTime = table.Column<DateTime>(nullable: false),
                    temperatureLow = table.Column<double>(nullable: false),
                    temperatureLowTime = table.Column<DateTime>(nullable: false),
                    apparentTemperatureHigh = table.Column<double>(nullable: false),
                    apparentTemperatureHighTime = table.Column<DateTime>(nullable: false),
                    apparentTemperatureLow = table.Column<double>(nullable: false),
                    apparentTemperatureLowTime = table.Column<DateTime>(nullable: false),
                    dewPoint = table.Column<double>(nullable: false),
                    humidity = table.Column<double>(nullable: false),
                    pressure = table.Column<double>(nullable: false),
                    windSpeed = table.Column<double>(nullable: false),
                    windGust = table.Column<double>(nullable: false),
                    windGustTime = table.Column<DateTime>(nullable: false),
                    windBearing = table.Column<int>(nullable: false),
                    cloudCover = table.Column<double>(nullable: false),
                    uvIndex = table.Column<int>(nullable: false),
                    uvIndexTime = table.Column<DateTime>(nullable: false),
                    visibility = table.Column<double>(nullable: false),
                    ozone = table.Column<double>(nullable: false),
                    temperatureMin = table.Column<double>(nullable: false),
                    temperatureMinTime = table.Column<DateTime>(nullable: false),
                    temperatureMax = table.Column<double>(nullable: false),
                    temperatureMaxTime = table.Column<DateTime>(nullable: false),
                    apparentTemperatureMin = table.Column<double>(nullable: false),
                    apparentTemperatureMinTime = table.Column<DateTime>(nullable: false),
                    apparentTemperatureMax = table.Column<double>(nullable: false),
                    apparentTemperatureMaxTime = table.Column<DateTime>(nullable: false),
                    dailyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyDatas", x => x.dailyDataId);
                    table.ForeignKey(
                        name: "FK_DailyDatas_Dailies_dailyId",
                        column: x => x.dailyId,
                        principalTable: "Dailies",
                        principalColumn: "dailyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlagSources",
                columns: table => new
                {
                    flagSourceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flag_type = table.Column<string>(nullable: true),
                    flagsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlagSources", x => x.flagSourceId);
                    table.ForeignKey(
                        name: "FK_FlagSources_DbFlags_flagsId",
                        column: x => x.flagsId,
                        principalTable: "DbFlags",
                        principalColumn: "flagsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HourlyDatas",
                columns: table => new
                {
                    hourlyDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    time = table.Column<DateTime>(nullable: false),
                    summary = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true),
                    precipIntensity = table.Column<double>(nullable: false),
                    precipProbability = table.Column<double>(nullable: false),
                    precipType = table.Column<string>(nullable: true),
                    temperature = table.Column<double>(nullable: false),
                    apparentTemperature = table.Column<double>(nullable: false),
                    dewPoint = table.Column<double>(nullable: false),
                    humidity = table.Column<double>(nullable: false),
                    pressure = table.Column<double>(nullable: false),
                    windSpeed = table.Column<double>(nullable: false),
                    windGust = table.Column<double>(nullable: false),
                    windBearing = table.Column<int>(nullable: false),
                    cloudCover = table.Column<double>(nullable: false),
                    uvIndex = table.Column<int>(nullable: false),
                    visibility = table.Column<int>(nullable: false),
                    ozone = table.Column<double>(nullable: false),
                    hourlyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlyDatas", x => x.hourlyDataId);
                    table.ForeignKey(
                        name: "FK_HourlyDatas_Hourlies_hourlyId",
                        column: x => x.hourlyId,
                        principalTable: "Hourlies",
                        principalColumn: "hourlyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MinutelyDatas",
                columns: table => new
                {
                    minutelyDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    time = table.Column<DateTime>(nullable: false),
                    precipIntensity = table.Column<double>(nullable: false),
                    precipIntensityError = table.Column<double>(nullable: false),
                    precipProbability = table.Column<double>(nullable: false),
                    precipType = table.Column<string>(nullable: true),
                    minutelyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinutelyDatas", x => x.minutelyDataId);
                    table.ForeignKey(
                        name: "FK_MinutelyDatas_Minutelies_minutelyId",
                        column: x => x.minutelyId,
                        principalTable: "Minutelies",
                        principalColumn: "minutelyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeatherDatas",
                columns: table => new
                {
                    weatherDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    latitude = table.Column<double>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    offset = table.Column<int>(nullable: false),
                    timezone = table.Column<DateTime>(nullable: false),
                    currentlyId = table.Column<int>(nullable: true),
                    minutelyId = table.Column<int>(nullable: true),
                    hourlyId = table.Column<int>(nullable: true),
                    dailyId = table.Column<int>(nullable: true),
                    flagsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherDatas", x => x.weatherDataId);
                    table.ForeignKey(
                        name: "FK_WeatherDatas_Currentlies_currentlyId",
                        column: x => x.currentlyId,
                        principalTable: "Currentlies",
                        principalColumn: "currentlyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherDatas_Dailies_dailyId",
                        column: x => x.dailyId,
                        principalTable: "Dailies",
                        principalColumn: "dailyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherDatas_DbFlags_flagsId",
                        column: x => x.flagsId,
                        principalTable: "DbFlags",
                        principalColumn: "flagsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherDatas_Hourlies_hourlyId",
                        column: x => x.hourlyId,
                        principalTable: "Hourlies",
                        principalColumn: "hourlyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherDatas_Minutelies_minutelyId",
                        column: x => x.minutelyId,
                        principalTable: "Minutelies",
                        principalColumn: "minutelyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alerts",
                columns: table => new
                {
                    alertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weatherDataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.alertId);
                    table.ForeignKey(
                        name: "FK_Alerts_WeatherDatas_weatherDataId",
                        column: x => x.weatherDataId,
                        principalTable: "WeatherDatas",
                        principalColumn: "weatherDataId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlertRegions_alertDataId",
                table: "AlertRegions",
                column: "alertDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_weatherDataId",
                table: "Alerts",
                column: "weatherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyDatas_dailyId",
                table: "DailyDatas",
                column: "dailyId");

            migrationBuilder.CreateIndex(
                name: "IX_FlagSources_flagsId",
                table: "FlagSources",
                column: "flagsId");

            migrationBuilder.CreateIndex(
                name: "IX_HourlyDatas_hourlyId",
                table: "HourlyDatas",
                column: "hourlyId");

            migrationBuilder.CreateIndex(
                name: "IX_MinutelyDatas_minutelyId",
                table: "MinutelyDatas",
                column: "minutelyId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDatas_currentlyId",
                table: "WeatherDatas",
                column: "currentlyId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDatas_dailyId",
                table: "WeatherDatas",
                column: "dailyId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDatas_flagsId",
                table: "WeatherDatas",
                column: "flagsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDatas_hourlyId",
                table: "WeatherDatas",
                column: "hourlyId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDatas_minutelyId",
                table: "WeatherDatas",
                column: "minutelyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlertRegions");

            migrationBuilder.DropTable(
                name: "Alerts");

            migrationBuilder.DropTable(
                name: "DailyDatas");

            migrationBuilder.DropTable(
                name: "FlagSources");

            migrationBuilder.DropTable(
                name: "HourlyDatas");

            migrationBuilder.DropTable(
                name: "MinutelyDatas");

            migrationBuilder.DropTable(
                name: "AlertDatas");

            migrationBuilder.DropTable(
                name: "WeatherDatas");

            migrationBuilder.DropTable(
                name: "Currentlies");

            migrationBuilder.DropTable(
                name: "Dailies");

            migrationBuilder.DropTable(
                name: "DbFlags");

            migrationBuilder.DropTable(
                name: "Hourlies");

            migrationBuilder.DropTable(
                name: "Minutelies");
        }
    }
}
