using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_self_healthcare.Migrations
{
    public partial class UpdateKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "Diet",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Diet_FoodID",
                table: "Diet",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Diet_Food_FoodID",
                table: "Diet",
                column: "FoodID",
                principalTable: "Food",
                principalColumn: "FoodID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diet_Food_FoodID",
                table: "Diet");

            migrationBuilder.DropIndex(
                name: "IX_Diet_FoodID",
                table: "Diet");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "Diet");
        }
    }
}
