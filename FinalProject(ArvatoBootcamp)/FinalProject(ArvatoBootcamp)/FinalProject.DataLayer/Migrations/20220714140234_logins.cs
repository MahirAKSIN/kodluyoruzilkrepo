using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.DataLayer.Migrations
{
    public partial class logins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passwored = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mytable",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    adult = table.Column<string>(type: "varchar(126)", unicode: false, maxLength: 126, nullable: false),
                    belongs_to_collection = table.Column<string>(type: "varchar(184)", unicode: false, maxLength: 184, nullable: true),
                    budget = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: false),
                    genres = table.Column<string>(type: "varchar(264)", unicode: false, maxLength: 264, nullable: false),
                    homepage = table.Column<string>(type: "varchar(242)", unicode: false, maxLength: 242, nullable: true),
                    imdb_id = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    original_language = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    original_title = table.Column<string>(type: "varchar(109)", unicode: false, maxLength: 109, nullable: false),
                    overview = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    popularity = table.Column<string>(type: "varchar(21)", unicode: false, maxLength: 21, nullable: true),
                    poster_path = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true),
                    production_companies = table.Column<string>(type: "varchar(1252)", unicode: false, maxLength: 1252, nullable: true),
                    production_countries = table.Column<string>(type: "varchar(1039)", unicode: false, maxLength: 1039, nullable: true),
                    release_date = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    revenue = table.Column<int>(type: "int", nullable: true),
                    runtime = table.Column<decimal>(type: "numeric(6,1)", nullable: true),
                    spoken_languages = table.Column<string>(type: "varchar(765)", unicode: false, maxLength: 765, nullable: true),
                    status = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    tagline = table.Column<string>(type: "varchar(297)", unicode: false, maxLength: 297, nullable: true),
                    title = table.Column<string>(type: "varchar(105)", unicode: false, maxLength: 105, nullable: true),
                    video = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    vote_average = table.Column<decimal>(type: "numeric(4,1)", nullable: true),
                    vote_count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mytable", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "mytable");
        }
    }
}
