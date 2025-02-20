using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkForId",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_WorkForId",
                table: "employees",
                column: "WorkForId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_WorkForId",
                table: "employees",
                column: "WorkForId",
                principalTable: "departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_WorkForId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_WorkForId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "WorkForId",
                table: "employees");
        }
    }
}
