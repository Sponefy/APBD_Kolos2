using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolos2.Migrations
{
    /// <inheritdoc />
    public partial class test001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_characters_CharacterId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_backpacks_itmes_ItemId",
                table: "backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_character_titles_characters_CharacterId",
                table: "character_titles");

            migrationBuilder.DropForeignKey(
                name: "FK_character_titles_titles_TitleId",
                table: "character_titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_titles",
                table: "titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_characters",
                table: "characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_itmes",
                table: "itmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_character_titles",
                table: "character_titles");

            migrationBuilder.RenameTable(
                name: "titles",
                newName: "Titles");

            migrationBuilder.RenameTable(
                name: "characters",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "backpacks",
                newName: "Backpacks");

            migrationBuilder.RenameTable(
                name: "itmes",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "character_titles",
                newName: "CharacterTitles");

            migrationBuilder.RenameIndex(
                name: "IX_backpacks_ItemId",
                table: "Backpacks",
                newName: "IX_Backpacks_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_character_titles_TitleId",
                table: "CharacterTitles",
                newName: "IX_CharacterTitles_TitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Titles",
                table: "Titles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks",
                columns: new[] { "CharacterId", "ItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterTitles",
                table: "CharacterTitles",
                columns: new[] { "CharacterId", "TitleId" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterTitles",
                table: "CharacterTitles");

            migrationBuilder.RenameTable(
                name: "Titles",
                newName: "titles");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "characters");

            migrationBuilder.RenameTable(
                name: "Backpacks",
                newName: "backpacks");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "itmes");

            migrationBuilder.RenameTable(
                name: "CharacterTitles",
                newName: "character_titles");

            migrationBuilder.RenameIndex(
                name: "IX_Backpacks_ItemId",
                table: "backpacks",
                newName: "IX_backpacks_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterTitles_TitleId",
                table: "character_titles",
                newName: "IX_character_titles_TitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_titles",
                table: "titles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_characters",
                table: "characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks",
                columns: new[] { "CharacterId", "ItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_itmes",
                table: "itmes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_character_titles",
                table: "character_titles",
                columns: new[] { "CharacterId", "TitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_characters_CharacterId",
                table: "backpacks",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_backpacks_itmes_ItemId",
                table: "backpacks",
                column: "ItemId",
                principalTable: "itmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_character_titles_characters_CharacterId",
                table: "character_titles",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_character_titles_titles_TitleId",
                table: "character_titles",
                column: "TitleId",
                principalTable: "titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
