using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankStatInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class remove_ProductInfos_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInfos");

            migrationBuilder.AddColumn<string>(
                name: "ProductInfo_AccountId",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ProductInfo_Amount",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProductInfo_CurrencyId",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductInfo_AccountId",
                table: "Products",
                column: "ProductInfo_AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductInfo_CurrencyId",
                table: "Products",
                column: "ProductInfo_CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Accounts_ProductInfo_AccountId",
                table: "Products",
                column: "ProductInfo_AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Currencies_ProductInfo_CurrencyId",
                table: "Products",
                column: "ProductInfo_CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Accounts_ProductInfo_AccountId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Currencies_ProductInfo_CurrencyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductInfo_AccountId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductInfo_CurrencyId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductInfo_AccountId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductInfo_Amount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductInfo_CurrencyId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductInfos",
                columns: table => new
                {
                    ProductEntityId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    CurrencyId = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInfos", x => x.ProductEntityId);
                    table.ForeignKey(
                        name: "FK_ProductInfos_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInfos_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInfos_Products_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfos_AccountId",
                table: "ProductInfos",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfos_CurrencyId",
                table: "ProductInfos",
                column: "CurrencyId");
        }
    }
}
