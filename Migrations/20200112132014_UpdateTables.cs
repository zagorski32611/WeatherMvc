using Microsoft.EntityFrameworkCore.Migrations;

namespace weatherMvc.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlertRegions_AlertDatas_alertDataId",
                table: "AlertRegions");

            migrationBuilder.DropForeignKey(
                name: "FK_Alerts_WeatherDatas_weatherDataId",
                table: "Alerts");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyDatas_Dailies_dailyId",
                table: "DailyDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_FlagSources_DbFlags_flagsId",
                table: "FlagSources");

            migrationBuilder.DropForeignKey(
                name: "FK_HourlyDatas_Hourlies_hourlyId",
                table: "HourlyDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_MinutelyDatas_Minutelies_minutelyId",
                table: "MinutelyDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherDatas_Currentlies_currentlyId",
                table: "WeatherDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherDatas_Dailies_dailyId",
                table: "WeatherDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherDatas_DbFlags_flagsId",
                table: "WeatherDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherDatas_Hourlies_hourlyId",
                table: "WeatherDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherDatas_Minutelies_minutelyId",
                table: "WeatherDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeatherDatas",
                table: "WeatherDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MinutelyDatas",
                table: "MinutelyDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Minutelies",
                table: "Minutelies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HourlyDatas",
                table: "HourlyDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hourlies",
                table: "Hourlies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbFlags",
                table: "DbFlags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyDatas",
                table: "DailyDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dailies",
                table: "Dailies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currentlies",
                table: "Currentlies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlertDatas",
                table: "AlertDatas");

            migrationBuilder.RenameTable(
                name: "WeatherDatas",
                newName: "WeatherData");

            migrationBuilder.RenameTable(
                name: "MinutelyDatas",
                newName: "MinutelyData");

            migrationBuilder.RenameTable(
                name: "Minutelies",
                newName: "Minutely");

            migrationBuilder.RenameTable(
                name: "HourlyDatas",
                newName: "HourlyData");

            migrationBuilder.RenameTable(
                name: "Hourlies",
                newName: "Hourly");

            migrationBuilder.RenameTable(
                name: "DbFlags",
                newName: "WeatherFlags");

            migrationBuilder.RenameTable(
                name: "DailyDatas",
                newName: "DailyData");

            migrationBuilder.RenameTable(
                name: "Dailies",
                newName: "Daily");

            migrationBuilder.RenameTable(
                name: "Currentlies",
                newName: "Currently");

            migrationBuilder.RenameTable(
                name: "AlertDatas",
                newName: "AlertData");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherDatas_minutelyId",
                table: "WeatherData",
                newName: "IX_WeatherData_minutelyId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherDatas_hourlyId",
                table: "WeatherData",
                newName: "IX_WeatherData_hourlyId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherDatas_flagsId",
                table: "WeatherData",
                newName: "IX_WeatherData_flagsId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherDatas_dailyId",
                table: "WeatherData",
                newName: "IX_WeatherData_dailyId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherDatas_currentlyId",
                table: "WeatherData",
                newName: "IX_WeatherData_currentlyId");

            migrationBuilder.RenameIndex(
                name: "IX_MinutelyDatas_minutelyId",
                table: "MinutelyData",
                newName: "IX_MinutelyData_minutelyId");

            migrationBuilder.RenameIndex(
                name: "IX_HourlyDatas_hourlyId",
                table: "HourlyData",
                newName: "IX_HourlyData_hourlyId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyDatas_dailyId",
                table: "DailyData",
                newName: "IX_DailyData_dailyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeatherData",
                table: "WeatherData",
                column: "weatherDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MinutelyData",
                table: "MinutelyData",
                column: "minutelyDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Minutely",
                table: "Minutely",
                column: "minutelyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HourlyData",
                table: "HourlyData",
                column: "hourlyDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hourly",
                table: "Hourly",
                column: "hourlyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeatherFlags",
                table: "WeatherFlags",
                column: "flagsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyData",
                table: "DailyData",
                column: "dailyDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Daily",
                table: "Daily",
                column: "dailyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currently",
                table: "Currently",
                column: "currentlyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlertData",
                table: "AlertData",
                column: "alertDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlertRegions_AlertData_alertDataId",
                table: "AlertRegions",
                column: "alertDataId",
                principalTable: "AlertData",
                principalColumn: "alertDataId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alerts_WeatherData_weatherDataId",
                table: "Alerts",
                column: "weatherDataId",
                principalTable: "WeatherData",
                principalColumn: "weatherDataId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyData_Daily_dailyId",
                table: "DailyData",
                column: "dailyId",
                principalTable: "Daily",
                principalColumn: "dailyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlagSources_WeatherFlags_flagsId",
                table: "FlagSources",
                column: "flagsId",
                principalTable: "WeatherFlags",
                principalColumn: "flagsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HourlyData_Hourly_hourlyId",
                table: "HourlyData",
                column: "hourlyId",
                principalTable: "Hourly",
                principalColumn: "hourlyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MinutelyData_Minutely_minutelyId",
                table: "MinutelyData",
                column: "minutelyId",
                principalTable: "Minutely",
                principalColumn: "minutelyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_Currently_currentlyId",
                table: "WeatherData",
                column: "currentlyId",
                principalTable: "Currently",
                principalColumn: "currentlyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_Daily_dailyId",
                table: "WeatherData",
                column: "dailyId",
                principalTable: "Daily",
                principalColumn: "dailyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_WeatherFlags_flagsId",
                table: "WeatherData",
                column: "flagsId",
                principalTable: "WeatherFlags",
                principalColumn: "flagsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_Hourly_hourlyId",
                table: "WeatherData",
                column: "hourlyId",
                principalTable: "Hourly",
                principalColumn: "hourlyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_Minutely_minutelyId",
                table: "WeatherData",
                column: "minutelyId",
                principalTable: "Minutely",
                principalColumn: "minutelyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlertRegions_AlertData_alertDataId",
                table: "AlertRegions");

            migrationBuilder.DropForeignKey(
                name: "FK_Alerts_WeatherData_weatherDataId",
                table: "Alerts");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyData_Daily_dailyId",
                table: "DailyData");

            migrationBuilder.DropForeignKey(
                name: "FK_FlagSources_WeatherFlags_flagsId",
                table: "FlagSources");

            migrationBuilder.DropForeignKey(
                name: "FK_HourlyData_Hourly_hourlyId",
                table: "HourlyData");

            migrationBuilder.DropForeignKey(
                name: "FK_MinutelyData_Minutely_minutelyId",
                table: "MinutelyData");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_Currently_currentlyId",
                table: "WeatherData");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_Daily_dailyId",
                table: "WeatherData");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_WeatherFlags_flagsId",
                table: "WeatherData");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_Hourly_hourlyId",
                table: "WeatherData");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_Minutely_minutelyId",
                table: "WeatherData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeatherFlags",
                table: "WeatherFlags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeatherData",
                table: "WeatherData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MinutelyData",
                table: "MinutelyData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Minutely",
                table: "Minutely");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HourlyData",
                table: "HourlyData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hourly",
                table: "Hourly");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyData",
                table: "DailyData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Daily",
                table: "Daily");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currently",
                table: "Currently");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlertData",
                table: "AlertData");

            migrationBuilder.RenameTable(
                name: "WeatherFlags",
                newName: "DbFlags");

            migrationBuilder.RenameTable(
                name: "WeatherData",
                newName: "WeatherDatas");

            migrationBuilder.RenameTable(
                name: "MinutelyData",
                newName: "MinutelyDatas");

            migrationBuilder.RenameTable(
                name: "Minutely",
                newName: "Minutelies");

            migrationBuilder.RenameTable(
                name: "HourlyData",
                newName: "HourlyDatas");

            migrationBuilder.RenameTable(
                name: "Hourly",
                newName: "Hourlies");

            migrationBuilder.RenameTable(
                name: "DailyData",
                newName: "DailyDatas");

            migrationBuilder.RenameTable(
                name: "Daily",
                newName: "Dailies");

            migrationBuilder.RenameTable(
                name: "Currently",
                newName: "Currentlies");

            migrationBuilder.RenameTable(
                name: "AlertData",
                newName: "AlertDatas");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherData_minutelyId",
                table: "WeatherDatas",
                newName: "IX_WeatherDatas_minutelyId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherData_hourlyId",
                table: "WeatherDatas",
                newName: "IX_WeatherDatas_hourlyId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherData_flagsId",
                table: "WeatherDatas",
                newName: "IX_WeatherDatas_flagsId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherData_dailyId",
                table: "WeatherDatas",
                newName: "IX_WeatherDatas_dailyId");

            migrationBuilder.RenameIndex(
                name: "IX_WeatherData_currentlyId",
                table: "WeatherDatas",
                newName: "IX_WeatherDatas_currentlyId");

            migrationBuilder.RenameIndex(
                name: "IX_MinutelyData_minutelyId",
                table: "MinutelyDatas",
                newName: "IX_MinutelyDatas_minutelyId");

            migrationBuilder.RenameIndex(
                name: "IX_HourlyData_hourlyId",
                table: "HourlyDatas",
                newName: "IX_HourlyDatas_hourlyId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyData_dailyId",
                table: "DailyDatas",
                newName: "IX_DailyDatas_dailyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbFlags",
                table: "DbFlags",
                column: "flagsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeatherDatas",
                table: "WeatherDatas",
                column: "weatherDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MinutelyDatas",
                table: "MinutelyDatas",
                column: "minutelyDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Minutelies",
                table: "Minutelies",
                column: "minutelyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HourlyDatas",
                table: "HourlyDatas",
                column: "hourlyDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hourlies",
                table: "Hourlies",
                column: "hourlyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyDatas",
                table: "DailyDatas",
                column: "dailyDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dailies",
                table: "Dailies",
                column: "dailyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currentlies",
                table: "Currentlies",
                column: "currentlyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlertDatas",
                table: "AlertDatas",
                column: "alertDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlertRegions_AlertDatas_alertDataId",
                table: "AlertRegions",
                column: "alertDataId",
                principalTable: "AlertDatas",
                principalColumn: "alertDataId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alerts_WeatherDatas_weatherDataId",
                table: "Alerts",
                column: "weatherDataId",
                principalTable: "WeatherDatas",
                principalColumn: "weatherDataId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyDatas_Dailies_dailyId",
                table: "DailyDatas",
                column: "dailyId",
                principalTable: "Dailies",
                principalColumn: "dailyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlagSources_DbFlags_flagsId",
                table: "FlagSources",
                column: "flagsId",
                principalTable: "DbFlags",
                principalColumn: "flagsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HourlyDatas_Hourlies_hourlyId",
                table: "HourlyDatas",
                column: "hourlyId",
                principalTable: "Hourlies",
                principalColumn: "hourlyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MinutelyDatas_Minutelies_minutelyId",
                table: "MinutelyDatas",
                column: "minutelyId",
                principalTable: "Minutelies",
                principalColumn: "minutelyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDatas_Currentlies_currentlyId",
                table: "WeatherDatas",
                column: "currentlyId",
                principalTable: "Currentlies",
                principalColumn: "currentlyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDatas_Dailies_dailyId",
                table: "WeatherDatas",
                column: "dailyId",
                principalTable: "Dailies",
                principalColumn: "dailyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDatas_DbFlags_flagsId",
                table: "WeatherDatas",
                column: "flagsId",
                principalTable: "DbFlags",
                principalColumn: "flagsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDatas_Hourlies_hourlyId",
                table: "WeatherDatas",
                column: "hourlyId",
                principalTable: "Hourlies",
                principalColumn: "hourlyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDatas_Minutelies_minutelyId",
                table: "WeatherDatas",
                column: "minutelyId",
                principalTable: "Minutelies",
                principalColumn: "minutelyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
