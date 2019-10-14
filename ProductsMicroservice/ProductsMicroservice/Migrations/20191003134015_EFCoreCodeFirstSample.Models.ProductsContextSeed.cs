using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsMicroservice.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsProductsContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Price", "ProductName" },
                values: new object[] { 1L, "Intel wirles keyboard", 20m, "Intel-Keyboard" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Price", "ProductName" },
                values: new object[] { 2L, "Intel wirles mouse", 20m, "Intel-Mouse" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
