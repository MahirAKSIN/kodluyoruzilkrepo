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
                    BootcampId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BootcampName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BootcampContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BootcampInfos", x => x.BootcampId);
                });

            migrationBuilder.CreateTable(
                name: "EducatorInfos",
                columns: table => new
                {
                    EducatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducatorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducatorSurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducatorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducatorInfos", x => x.EducatorId);
                });

            migrationBuilder.CreateTable(
                name: "AdminInfos",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BootcampInfoId = table.Column<int>(type: "int", nullable: false),
                    EducatorInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminInfos", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_AdminInfos_BootcampInfos_BootcampInfoId",
                        column: x => x.BootcampInfoId,
                        principalTable: "BootcampInfos",
                        principalColumn: "BootcampId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminInfos_EducatorInfos_EducatorInfoId",
                        column: x => x.EducatorInfoId,
                        principalTable: "EducatorInfos",
                        principalColumn: "EducatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BootcampInfos",
                columns: new[] { "BootcampId", "BootcampContent", "BootcampName" },
                values: new object[,]
                {
                    { 1, ".Net Eğitimi", "Arvato Bootcamp" },
                    { 2, "React Eğitimi", "Kodluyoruz Bootcamp" }
                });

            migrationBuilder.InsertData(
                table: "EducatorInfos",
                columns: new[] { "EducatorId", "EducatorEmail", "EducatorName", "EducatorSurName" },
                values: new object[,]
                {
                    { 1, "inceSerkan@gmail.com", "Serkan", "Ince" },
                    { 2, "guzel@gmail.com", "Zeynep", "Guzel" }
                });

            migrationBuilder.InsertData(
                table: "AdminInfos",
                columns: new[] { "AdminId", "AdminEmail", "AdminName", "BootcampInfoId", "EducatorInfoId" },
                values: new object[] { 1, "mahir@hotmail.com", "Mahir", 1, 1 });

            migrationBuilder.InsertData(
                table: "AdminInfos",
                columns: new[] { "AdminId", "AdminEmail", "AdminName", "BootcampInfoId", "EducatorInfoId" },
                values: new object[] { 2, "ince@hotmail.com", "Serkan", 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AdminInfos_BootcampInfoId",
                table: "AdminInfos",
                column: "BootcampInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminInfos_EducatorInfoId",
                table: "AdminInfos",
                column: "EducatorInfoId");
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
