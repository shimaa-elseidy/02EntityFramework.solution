using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_departments_EmpId",
                table: "departments",
                column: "EmpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_employees_EmpId",
                table: "departments",
                column: "EmpId",
                principalTable: "employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_employees_EmpId",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_EmpId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "departments");
        }
    }
}
