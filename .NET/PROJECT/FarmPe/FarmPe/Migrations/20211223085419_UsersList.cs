using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmPe.Migrations
{
    public partial class UsersList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                        create view UsersLists as
                        Select * from Users"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                        Drop view UsersLists"
           );
           
        }
    }
}
