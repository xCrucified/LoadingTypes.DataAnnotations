using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadingTypes.DataAnnotations.Migrations
{
    public partial class UpdateConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionsId",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShopsId",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CitiesId",
                table: "Shops",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 1, "Waiter" },
                    { 2, "Chef" },
                    { 3, "Administrator" },
                    { 4, "Barman" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PositionsId",
                table: "Workers",
                column: "PositionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_ShopsId",
                table: "Workers",
                column: "ShopsId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CitiesId",
                table: "Shops",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesId",
                table: "Products",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoriesId",
                table: "Products",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_Cities_CitiesId",
                table: "Shops",
                column: "CitiesId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Positions_PositionsId",
                table: "Workers",
                column: "PositionsId",
                principalTable: "Positions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Shops_ShopsId",
                table: "Workers",
                column: "ShopsId",
                principalTable: "Shops",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoriesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Shops_Cities_CitiesId",
                table: "Shops");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Positions_PositionsId",
                table: "Workers");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Shops_ShopsId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_PositionsId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_ShopsId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Shops_CitiesId",
                table: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoriesId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "PositionsId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "ShopsId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "CitiesId",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Products");
        }
    }
}
