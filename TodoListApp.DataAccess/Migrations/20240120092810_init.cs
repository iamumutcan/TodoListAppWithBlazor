using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoAppBlazorDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TodoTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TodoTasks_TodoStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "TodoStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TodoTasks_StatusId",
                table: "TodoTasks",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoTasks");

            migrationBuilder.DropTable(
                name: "TodoStatuses");
        }
    }
}
