using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    /// <inheritdoc />
    public partial class objectifs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Objective");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Objective",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 1,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 2,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 3,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 4,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 5,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 6,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 7,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 8,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 9,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Objective",
                keyColumn: "Id",
                keyValue: 10,
                column: "Completed",
                value: false);
        }
    }
}
