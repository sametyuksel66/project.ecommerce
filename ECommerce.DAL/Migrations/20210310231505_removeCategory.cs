using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DAL.Migrations
{
    public partial class removeCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ParentCategory_ParentCategoryId1",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "ParentCategory");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentCategoryId1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId1",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId1",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ParentCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId1",
                table: "Categories",
                column: "ParentCategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ParentCategory_ParentCategoryId1",
                table: "Categories",
                column: "ParentCategoryId1",
                principalTable: "ParentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
