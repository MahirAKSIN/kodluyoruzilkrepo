using Microsoft.EntityFrameworkCore.Migrations;

namespace PatikaApp.DataLayer.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BootcampInfos",
                columns: table => new
                {
                    BootcampId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BootcampName = table.Column<string>(type: "TEXT", nullable: true),
                    BootcampContent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BootcampInfos", x => x.BootcampId);
                });

            migrationBuilder.CreateTable(
                name: "EducatorInfos",
                columns: table => new
                {
                    EducatorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EducatorName = table.Column<string>(type: "TEXT", nullable: true),
                    EducatorSurName = table.Column<string>(type: "TEXT", nullable: true),
                    EducatorEmail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducatorInfos", x => x.EducatorId);
                });

            migrationBuilder.CreateTable(
                name: "AdminInfos",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdminName = table.Column<string>(type: "TEXT", nullable: true),
                    AdminEmail = table.Column<string>(type: "TEXT", nullable: true),
                    BootcampId = table.Column<int>(type: "INTEGER", nullable: false),
                    EducatorId = table.Column<int>(type: "INTEGER", nullable: false),
                    BootcampInfoBootcampId = table.Column<int>(type: "INTEGER", nullable: true),
                    EducatorInfoEducatorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminInfos", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_AdminInfos_BootcampInfos_BootcampInfoBootcampId",
                        column: x => x.BootcampInfoBootcampId,
                        principalTable: "BootcampInfos",
                        principalColumn: "BootcampId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminInfos_EducatorInfos_EducatorInfoEducatorId",
                        column: x => x.EducatorInfoEducatorId,
                        principalTable: "EducatorInfos",
                        principalColumn: "EducatorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AdminInfos",
                columns: new[] { "AdminId", "AdminEmail", "AdminName", "BootcampId", "BootcampInfoBootcampId", "EducatorId", "EducatorInfoEducatorId" },
                values: new object[] { 1, "mahir@hotmail.com", "Mahir", 1, null, 1, null });

            migrationBuilder.InsertData(
                table: "AdminInfos",
                columns: new[] { "AdminId", "AdminEmail", "AdminName", "BootcampId", "BootcampInfoBootcampId", "EducatorId", "EducatorInfoEducatorId" },
                values: new object[] { 2, "ince@hotmail.com", "Serkan", 2, null, 2, null });

            migrationBuilder.InsertData(
                table: "BootcampInfos",
                columns: new[] { "BootcampId", "BootcampContent", "BootcampName" },
                values: new object[] { 1, ".Net Eğitimi", "Arvato Bootcamp" });

            migrationBuilder.InsertData(
                table: "BootcampInfos",
                columns: new[] { "BootcampId", "BootcampContent", "BootcampName" },
                values: new object[] { 2, "React Eğitimi", "Kodluyoruz Bootcamp" });

            migrationBuilder.InsertData(
                table: "EducatorInfos",
                columns: new[] { "EducatorId", "EducatorEmail", "EducatorName", "EducatorSurName" },
                values: new object[] { 1, "inceSerkan@gmail.com", "Serkan", "Ince" });

            migrationBuilder.InsertData(
                table: "EducatorInfos",
                columns: new[] { "EducatorId", "EducatorEmail", "EducatorName", "EducatorSurName" },
                values: new object[] { 2, "guzel@gmail.com", "Zeynep", "Guzel" });

            migrationBuilder.CreateIndex(
                name: "IX_AdminInfos_BootcampInfoBootcampId",
                table: "AdminInfos",
                column: "BootcampInfoBootcampId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminInfos_EducatorInfoEducatorId",
                table: "AdminInfos",
                column: "EducatorInfoEducatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminInfos");

            migrationBuilder.DropTable(
                name: "BootcampInfos");

            migrationBuilder.DropTable(
                name: "EducatorInfos");
        }
    }
}
