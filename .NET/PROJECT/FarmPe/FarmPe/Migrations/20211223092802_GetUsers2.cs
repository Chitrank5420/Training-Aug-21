using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmPe.Migrations
{
    public partial class GetUsers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetUsers2]
                        @FirstName VARCHAR(20)
                      AS
                    BEGIN
                        SET NOCOUNT ON;
                        SELECT * FROM Users WHERE FirstName LIKE @FirstName + '%'
                    END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
