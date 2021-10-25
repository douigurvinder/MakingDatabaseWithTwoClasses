using Microsoft.EntityFrameworkCore.Migrations;

namespace MakingDatabaseWithTwoClasses.Server.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cass1Set",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Whatsapp_Phone_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cass1Set", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Class2Set",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Whatsapp_Phone_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class2Set", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cass1Set");

            migrationBuilder.DropTable(
                name: "Class2Set");
        }
    }
}
