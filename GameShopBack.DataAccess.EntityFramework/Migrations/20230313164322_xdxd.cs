using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShopBack.DataAccess.EntityFramework.Migrations
{
    public partial class xdxd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameBasket_Baskets_BasketId",
                table: "GameBasket");

            migrationBuilder.DropForeignKey(
                name: "FK_GameBasket_Games_GameId",
                table: "GameBasket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameBasket",
                table: "GameBasket");

            migrationBuilder.RenameTable(
                name: "GameBasket",
                newName: "GameBaskets");

            migrationBuilder.RenameIndex(
                name: "IX_GameBasket_GameId",
                table: "GameBaskets",
                newName: "IX_GameBaskets_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameBasket_BasketId",
                table: "GameBaskets",
                newName: "IX_GameBaskets_BasketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameBaskets",
                table: "GameBaskets",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameBaskets_Baskets_BasketId",
                table: "GameBaskets",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameBaskets_Games_GameId",
                table: "GameBaskets",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameBaskets_Baskets_BasketId",
                table: "GameBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_GameBaskets_Games_GameId",
                table: "GameBaskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameBaskets",
                table: "GameBaskets");

            migrationBuilder.RenameTable(
                name: "GameBaskets",
                newName: "GameBasket");

            migrationBuilder.RenameIndex(
                name: "IX_GameBaskets_GameId",
                table: "GameBasket",
                newName: "IX_GameBasket_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameBaskets_BasketId",
                table: "GameBasket",
                newName: "IX_GameBasket_BasketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameBasket",
                table: "GameBasket",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameBasket_Baskets_BasketId",
                table: "GameBasket",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameBasket_Games_GameId",
                table: "GameBasket",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
