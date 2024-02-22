using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_score_colomn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Blogs_Categories_CategoryID",
            //    table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "BlogScore",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.AlterColumn<int>(
            //    name: "CategoryID",
            //    table: "Blogs",
            //    type: "int",
            //    nullable: true,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Blogs_Categories_CategoryID",
            //    table: "Blogs",
            //    column: "CategoryID",
            //    principalTable: "Categories",
            //    principalColumn: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Blogs_Categories_CategoryID",
            //    table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogScore",
                table: "Comments");

            //migrationBuilder.AlterColumn<int>(
            //    name: "CategoryID",
            //    table: "Blogs",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Blogs_Categories_CategoryID",
            //    table: "Blogs",
            //    column: "CategoryID",
            //    principalTable: "Categories",
            //    principalColumn: "CategoryID",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
