using Microsoft.EntityFrameworkCore.Migrations;

namespace ForeignKeyPractice.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CoursesCourseId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "CoursesCourseId",
                table: "Students",
                newName: "CId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CoursesCourseId",
                table: "Students",
                newName: "IX_Students_CId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CId",
                table: "Students",
                column: "CId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "CId",
                table: "Students",
                newName: "CoursesCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CId",
                table: "Students",
                newName: "IX_Students_CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesCourseId",
                table: "Students",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
