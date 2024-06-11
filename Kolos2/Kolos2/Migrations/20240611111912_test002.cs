using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolos2.Migrations
{
    /// <inheritdoc />
    public partial class test002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Characters_CharacterId",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Items_ItemId",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTitles_Characters_CharacterId",
                table: "CharacterTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTitles_Titles_TitleId",
                table: "CharacterTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Titles",
                table: "Titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterTitles",
                table: "CharacterTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks");

            migrationBuilder.RenameTable(
                name: "Titles",
                newName: "titles");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "items");

            migrationBuilder.RenameTable(
                name: "CharacterTitles",
                newName: "characterTitles");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "characters");

            migrationBuilder.RenameTable(
                name: "Backpacks",
                newName: "backpacks");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterTitles_TitleId",
                table: "characterTitles",
                newName: "IX_characterTitles_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Backpacks_ItemId",
                table: "backpacks",
                newName: "IX_backpacks_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_titles",
                table: "titles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_items",
                table: "items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_characterTitles",
                table: "characterTitles",
                columns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_characters",
                table: "characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks",
                columns: new[] { "CharacterId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_characters_CharacterId",
                table: "backpacks",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_items_ItemId",
                table: "backpacks",
                column: "ItemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characterTitles_characters_CharacterId",
                table: "characterTitles",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characterTitles_titles_TitleId",
                table: "characterTitles",
                column: "TitleId",
                principalTable: "titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_characters_CharacterId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_items_ItemId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_characterTitles_characters_CharacterId",
                table: "characterTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_characterTitles_titles_TitleId",
                table: "characterTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_titles",
                table: "titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_items",
                table: "items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_characterTitles",
                table: "characterTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_characters",
                table: "characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks");

            migrationBuilder.RenameTable(
                name: "titles",
                newName: "Titles");

            migrationBuilder.RenameTable(
                name: "items",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "characterTitles",
                newName: "CharacterTitles");

            migrationBuilder.RenameTable(
                name: "characters",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "backpacks",
                newName: "Backpacks");

            migrationBuilder.RenameIndex(
                name: "IX_characterTitles_TitleId",
                table: "CharacterTitles",
                newName: "IX_CharacterTitles_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_backpacks_ItemId",
                table: "Backpacks",
                newName: "IX_Backpacks_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Titles",
                table: "Titles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterTitles",
                table: "CharacterTitles",
                columns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks",
                columns: new[] { "CharacterId", "ItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Characters_CharacterId",
                table: "Backpacks",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Items_ItemId",
                table: "Backpacks",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTitles_Characters_CharacterId",
                table: "CharacterTitles",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTitles_Titles_TitleId",
                table: "CharacterTitles",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
