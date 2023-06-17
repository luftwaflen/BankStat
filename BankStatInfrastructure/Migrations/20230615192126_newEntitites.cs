using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankStatInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newEntitites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Amounts_AmountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Accounts_AccountID",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Amounts_AmountId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Amounts_OperationAmountId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInfos_Amounts_AmountId",
                table: "ProductInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInfos_Products_ProductId",
                table: "ProductInfos");

            migrationBuilder.DropTable(
                name: "Amounts");

            migrationBuilder.DropIndex(
                name: "IX_ProductInfos_AmountId",
                table: "ProductInfos");

            migrationBuilder.DropIndex(
                name: "IX_ProductInfos_ProductId",
                table: "ProductInfos");

            migrationBuilder.DropIndex(
                name: "IX_Operations_AccountID",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_AmountId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "AmountId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "CardMask",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Operations");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductInfos",
                newName: "CurrencyId");

            migrationBuilder.RenameColumn(
                name: "AmountId",
                table: "ProductInfos",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductInfos",
                newName: "ProductEntityId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Operations",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "OperationType",
                table: "Operations",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "OperationAmountId",
                table: "Operations",
                newName: "ReceiverId");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Operations",
                newName: "CurrencyId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Operations",
                newName: "Amount");

            migrationBuilder.RenameIndex(
                name: "IX_Operations_OperationAmountId",
                table: "Operations",
                newName: "IX_Operations_ReceiverId");

            migrationBuilder.RenameColumn(
                name: "AmountId",
                table: "Accounts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_AmountId",
                table: "Accounts",
                newName: "IX_Accounts_UserId");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Accounts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyId",
                table: "Accounts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountEntityOperationEntity",
                columns: table => new
                {
                    AccountEntityId = table.Column<string>(type: "TEXT", nullable: false),
                    OperationEntityId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountEntityOperationEntity", x => new { x.AccountEntityId, x.OperationEntityId });
                    table.ForeignKey(
                        name: "FK_AccountEntityOperationEntity_Accounts_AccountEntityId",
                        column: x => x.AccountEntityId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountEntityOperationEntity_Operations_OperationEntityId",
                        column: x => x.OperationEntityId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Iso = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfos_CurrencyId",
                table: "ProductInfos",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_CurrencyId",
                table: "Operations",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_SenderId",
                table: "Operations",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CurrencyId",
                table: "Accounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountEntityOperationEntity_OperationEntityId",
                table: "AccountEntityOperationEntity",
                column: "OperationEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Currencies_CurrencyId",
                table: "Accounts",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_UserId",
                table: "Accounts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Accounts_ReceiverId",
                table: "Operations",
                column: "ReceiverId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Accounts_SenderId",
                table: "Operations",
                column: "SenderId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Currencies_CurrencyId",
                table: "Operations",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInfos_Currencies_CurrencyId",
                table: "ProductInfos",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInfos_Products_ProductEntityId",
                table: "ProductInfos",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Currencies_CurrencyId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_UserId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Accounts_ReceiverId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Accounts_SenderId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Currencies_CurrencyId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInfos_Currencies_CurrencyId",
                table: "ProductInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInfos_Products_ProductEntityId",
                table: "ProductInfos");

            migrationBuilder.DropTable(
                name: "AccountEntityOperationEntity");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ProductInfos_CurrencyId",
                table: "ProductInfos");

            migrationBuilder.DropIndex(
                name: "IX_Operations_CurrencyId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_SenderId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_CurrencyId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                table: "ProductInfos",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "ProductInfos",
                newName: "AmountId");

            migrationBuilder.RenameColumn(
                name: "ProductEntityId",
                table: "ProductInfos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Operations",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Operations",
                newName: "OperationType");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Operations",
                newName: "OperationAmountId");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                table: "Operations",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Operations",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_Operations_ReceiverId",
                table: "Operations",
                newName: "IX_Operations_OperationAmountId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Accounts",
                newName: "AmountId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                newName: "IX_Accounts_AmountId");

            migrationBuilder.AddColumn<string>(
                name: "AccountID",
                table: "Operations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AmountId",
                table: "Operations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardMask",
                table: "Operations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Operations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Amounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CurrIso = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amounts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfos_AmountId",
                table: "ProductInfos",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfos_ProductId",
                table: "ProductInfos",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operations_AccountID",
                table: "Operations",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_AmountId",
                table: "Operations",
                column: "AmountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Amounts_AmountId",
                table: "Accounts",
                column: "AmountId",
                principalTable: "Amounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Accounts_AccountID",
                table: "Operations",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Amounts_AmountId",
                table: "Operations",
                column: "AmountId",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Amounts_OperationAmountId",
                table: "Operations",
                column: "OperationAmountId",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInfos_Amounts_AmountId",
                table: "ProductInfos",
                column: "AmountId",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInfos_Products_ProductId",
                table: "ProductInfos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
