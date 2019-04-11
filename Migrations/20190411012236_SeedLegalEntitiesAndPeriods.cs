using Microsoft.EntityFrameworkCore.Migrations;

namespace EYCaseStudy.API.Migrations
{
    public partial class SeedLegalEntitiesAndPeriods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO LegalEntities (NAME, REGION) VALUES ('LE 1', 'NORTH')");
            migrationBuilder.Sql("INSERT INTO LegalEntities (NAME, REGION) VALUES ('LE 2', 'SOUTH')");
            migrationBuilder.Sql("INSERT INTO LegalEntities (NAME, REGION) VALUES ('LE 3', 'EAST')");
            migrationBuilder.Sql("INSERT INTO LegalEntities (NAME, REGION) VALUES ('LE 4', 'WEST')");
            migrationBuilder.Sql("INSERT INTO LegalEntities (NAME, REGION) VALUES ('LE 5', 'MIDWEST')");
            migrationBuilder.Sql("INSERT INTO LegalEntities (NAME, REGION) VALUES ('LE 6', 'CENTRAL')");

            migrationBuilder.Sql("INSERT INTO Periods (TITLE, STARTDATE) VALUES ('Period 1', '2018-01-01')");
            migrationBuilder.Sql("INSERT INTO Periods (TITLE, STARTDATE) VALUES ('Period 2', '2018-04-01')");
            migrationBuilder.Sql("INSERT INTO Periods (TITLE, STARTDATE) VALUES ('Period 3', '2018-07-01')");
            migrationBuilder.Sql("INSERT INTO Periods (TITLE, STARTDATE) VALUES ('Period 4', '2018-10-01')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM LegalEntities");
            migrationBuilder.Sql("DELETE FROM Periods");
        }
    }
}
