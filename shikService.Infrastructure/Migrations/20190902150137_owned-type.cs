using Microsoft.EntityFrameworkCore.Migrations;

namespace shikService.Infrastructure.Migrations
{
    public partial class ownedtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userEntitys",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Pw = table.Column<string>(nullable: true),
                    Detail_Name = table.Column<string>(nullable: true),
                    Detail_Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userEntitys", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userEntitys");
        }
    }
}
