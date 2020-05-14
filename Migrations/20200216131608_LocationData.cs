using Microsoft.EntityFrameworkCore.Migrations;

namespace weatherMvc.Migrations
{
    public partial class LocationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocationData",
                columns: table => new
                {
                    locationDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationLatitude = table.Column<double>(nullable: true),
                    locationLongitude = table.Column<double>(nullable: true),
                    locationCity = table.Column<string>(nullable: true),
                    locationState = table.Column<string>(nullable: true),
                    locationCountry = table.Column<string>(nullable: true),
                    locationZipCode = table.Column<string>(nullable: true),
                    locationTimeZone = table.Column<System.DateTimeOffset>(nullable: true)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationData", x => x.locationDataId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
