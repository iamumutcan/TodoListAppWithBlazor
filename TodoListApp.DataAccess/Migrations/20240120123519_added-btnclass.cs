using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoAppBlazorDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedbtnclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoStatuses",
                columns: new[] { "Id", "IsDeleted", "Name", "btnclass" },
                values: new object[,]
                {
                    { 1, false, "Yapacaklarım", "btn btn-warning" },
                    { 2, false, "Yapıyorum", "btn btn-primary" },
                    { 3, false, "Yaptım", "btn btn-success" }
                });

            migrationBuilder.InsertData(
                table: "TodoTasks",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "StatusId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1079), false, 1, "İlk görev" },
                    { 2, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1091), false, 2, "İkinci görev" },
                    { 3, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1092), false, 3, "Üçüncü görev" },
                    { 4, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1093), false, 1, "Dördüncü görev" },
                    { 5, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1095), false, 2, "Beşinci görev" },
                    { 6, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1096), false, 3, "Altıncı görev" },
                    { 7, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1097), false, 1, "Yedinci görev" },
                    { 8, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1098), false, 2, "Sekizinci görev" },
                    { 9, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1099), false, 3, "Dokuzuncu görev" },
                    { 10, new DateTime(2024, 1, 20, 15, 35, 19, 154, DateTimeKind.Local).AddTicks(1100), false, 1, "Onuncu görev" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TodoStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoStatuses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
