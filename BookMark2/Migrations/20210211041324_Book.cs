using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace BookMark2.Migrations
{
    public partial class Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalBookMark",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookGenre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentChapters = table.Column<int>(type: "int", nullable: false),
                    CurrentPage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalBookMark", x => x.Id);
                });
            var sqlFile = Path.Combine(".\\DatabaseScripts", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalBookMark");
        }
    }
}
