using Microsoft.EntityFrameworkCore.Migrations;

namespace VesterrCFDatabase.Migrations
{
    public partial class AddedPortfolioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteEntrance_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance");

            migrationBuilder.DropIndex(
                name: "IX_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance");

            migrationBuilder.DropColumn(
                name: "SiteEntrancessId",
                table: "SiteEntrance");

            migrationBuilder.CreateTable(
                name: "PortfolioCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioCardCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioCardId = table.Column<int>(nullable: false),
                    PortfolioCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioCardCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioCardCategories_PortfolioCards_PortfolioCardId",
                        column: x => x.PortfolioCardId,
                        principalTable: "PortfolioCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortfolioCardCategories_PortfolioCategories_PortfolioCategoryId",
                        column: x => x.PortfolioCategoryId,
                        principalTable: "PortfolioCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioCardCategories_PortfolioCardId",
                table: "PortfolioCardCategories",
                column: "PortfolioCardId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioCardCategories_PortfolioCategoryId",
                table: "PortfolioCardCategories",
                column: "PortfolioCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioCardCategories");

            migrationBuilder.DropTable(
                name: "PortfolioCards");

            migrationBuilder.DropTable(
                name: "PortfolioCategories");

            migrationBuilder.AddColumn<int>(
                name: "SiteEntrancessId",
                table: "SiteEntrance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance",
                column: "SiteEntrancessId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteEntrance_SiteEntrance_SiteEntrancessId",
                table: "SiteEntrance",
                column: "SiteEntrancessId",
                principalTable: "SiteEntrance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
