using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadingTypes.DataAnnotations.Migrations
{
    public partial class Filling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 1, "Produce" },
                    { 2, "Drinks" },
                    { 3, "Dairy" },
                    { 4, "Meat" },
                    { 5, "Frozen" },
                    { 6, "Cleaning" },
                    { 7, "Baking" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Country" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Poland" },
                    { 3, "United States of America" },
                    { 4, "Japan" },
                    { 5, "Kambojo" },
                    { 6, "Netherland" },
                    { 7, "Greece" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { 1, "Chill" },
                    { 2, "Fast" },
                    { 3, "Boring" },
                    { 4, "Amazing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Discount", "Avaible", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, null, 47f, true, "Bottle of Water", 430m, 4 },
                    { 2, null, 12f, false, "Glasses", 630m, 0 },
                    { 3, null, 134f, true, "Weight", 122m, 93 },
                    { 4, null, 2f, true, "VGA Monitor", 1120m, 12 },
                    { 5, null, 0f, true, "Keyboard", 3224m, 3 },
                    { 6, null, 45f, true, "Steam Deck", 7400m, 1120 },
                    { 7, null, 0f, true, "Morshinska", 17m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "City" },
                values: new object[,]
                {
                    { 1, 1, "Rivne" },
                    { 2, 2, "Lutsk" },
                    { 3, 3, "Lviv" },
                    { 4, 4, "Kiev" },
                    { 5, 5, "Odessa" },
                    { 6, 6, "Lublin" },
                    { 7, 7, "Miami" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Adress", "CityId", "Name", "ParkingArea" },
                values: new object[,]
                {
                    { 1, "near shag", 1, "Zlata Plaza", 1 },
                    { 2, "bariga house", 2, "Vandal", 0 },
                    { 3, "Asgard", 3, "Ekvator", 70 },
                    { 4, "Stepana Bandery", 4, "23Sim", 2 },
                    { 5, "Kolodenka", 5, "ABC", 5 },
                    { 6, "Near Kolodenka", 6, "Penny", 6 },
                    { 7, "Steam Platform", 7, "Defense of the Ancients", 346 }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "Email", "Name", "Phone", "PositionId", "Salary", "ShopId", "Surname" },
                values: new object[,]
                {
                    { 1, "Word@gmail.com", "Ivan", "+3806543905", 1, 0m, 1, "Kuban" },
                    { 2, "SuperPro@gmail.com", "Luda", "+12543623", 2, 1234m, 2, "OneTapMaster" },
                    { 3, "LargeShake@gmail.com", "Yarik", "+20983452345", 3, 76455656m, 3, "TwoTapsMaster" },
                    { 4, "ThorProMaster69@gmail.com", "Dasha", "+01230941025", 4, 3423m, 4, "ProMaster69" },
                    { 5, "PetroBiba@ukr.ua", "Petro", "+3806834563", 1, 99999m, 5, "Biba" },
                    { 6, "idonthameanemail@gmail.com", "Pudge", "+99999999", 2, 1215624618m, 6, "Hook" },
                    { 7, "ihaveanemail@gmail.com", "Mc Soloway", "+1235537345", 3, 12m, 7, "PussyLake" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
