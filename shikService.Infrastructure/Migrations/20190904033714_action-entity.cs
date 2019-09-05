using Microsoft.EntityFrameworkCore.Migrations;

namespace shikService.Infrastructure.Migrations
{
    public partial class actionentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actionEntity",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    With = table.Column<string>(nullable: true),
                    userEntityId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actionEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_actionEntity_userEntitys_userEntityId",
                        column: x => x.userEntityId,
                        principalTable: "userEntitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_actionEntity_userEntityId",
                table: "actionEntity",
                column: "userEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actionEntity");
        }
    }
}
