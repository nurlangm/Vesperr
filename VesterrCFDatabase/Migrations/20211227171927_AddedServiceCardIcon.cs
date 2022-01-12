using Microsoft.EntityFrameworkCore.Migrations;

namespace VesterrCFDatabase.Migrations
{
    public partial class AddedServiceCardIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteEntrancessId",
                table: "SiteEntrance",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ServiceCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceIcons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(nullable: true),
                    ServiceCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceIcons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceIcons_ServiceCards_ServiceCardId",
                        column: x => x.ServiceCardId,
                        principalTable: "ServiceCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance",
                column: "SiteEntrancessId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceIcons_ServiceCardId",
                table: "ServiceIcons",
                column: "ServiceCardId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteEntrance_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance",
                column: "SiteEntrancessId",
                principalTable: "SiteEntrance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteEntrance_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance");

            migrationBuilder.DropTable(
                name: "ServiceIcons");

            migrationBuilder.DropTable(
                name: "ServiceCards");

            migrationBuilder.DropIndex(
                name: "IX_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance");

            migrationBuilder.DropColumn(
                name: "SiteEntrancessId",
                table: "SiteEntrance");
        }
    }
}
