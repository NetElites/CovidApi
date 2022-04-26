using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApi.Persistence.Migrations
{
    public partial class AddDbContext1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "statistics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "statistics",
                columns: table => new
                {
                    StatisticsiD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Death = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Improvement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suffering = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statistics", x => x.StatisticsiD);
                });
        }
    }
}
