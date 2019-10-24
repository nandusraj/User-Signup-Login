using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserRegistration.Migrations.Course
{
    public partial class CourseMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartModels",
                columns: table => new
                {
                    cartid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ctype = table.Column<string>(type: "varchar(2)", nullable: false),
                    cname = table.Column<string>(type: "varchar(30)", nullable: false),
                    cprice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartModels", x => x.cartid);
                });

            migrationBuilder.CreateTable(
                name: "CourseModels",
                columns: table => new
                {
                    cid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "varchar(2)", nullable: false),
                    name = table.Column<string>(type: "varchar(30)", nullable: false),
                    duration = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModels", x => x.cid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartModels");

            migrationBuilder.DropTable(
                name: "CourseModels");
        }
    }
}
