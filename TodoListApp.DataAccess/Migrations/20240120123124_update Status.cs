using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoAppBlazorDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "btnclass",
                table: "TodoStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "btnclass",
                table: "TodoStatuses");

            migrationBuilder.InsertData(
                table: "TodoStatuses",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Yapacaklarım" },
                    { 2, false, "Yapıyorum" },
                    { 3, false, "Yaptım" }
                });

            migrationBuilder.InsertData(
                table: "TodoTasks",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "StatusId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1888), false, 1, "İlk görev" },
                    { 2, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1900), false, 2, "İkinci görev" },
                    { 3, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1901), false, 3, "Üçüncü görev" },
                    { 4, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1902), false, 1, "Dördüncü görev" },
                    { 5, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1903), false, 2, "Beşinci görev" },
                    { 6, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1904), false, 3, "Altıncı görev" },
                    { 7, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1905), false, 1, "Yedinci görev" },
                    { 8, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1906), false, 2, "Sekizinci görev" },
                    { 9, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1908), false, 3, "Dokuzuncu görev" },
                    { 10, new DateTime(2024, 1, 20, 12, 28, 9, 995, DateTimeKind.Local).AddTicks(1909), false, 1, "Onuncu görev" }
                });
        }
    }
}
