using Microsoft.EntityFrameworkCore.Migrations;

namespace Crisis.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    FactionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Areas_Factions_FactionName",
                        column: x => x.FactionName,
                        principalTable: "Factions",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    FactionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Ranks_Factions_FactionName",
                        column: x => x.FactionName,
                        principalTable: "Factions",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    FactionName = table.Column<string>(nullable: true),
                    AreaName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Rooms_Areas_AreaName",
                        column: x => x.AreaName,
                        principalTable: "Areas",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_Factions_FactionName",
                        column: x => x.FactionName,
                        principalTable: "Factions",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Ready = table.Column<bool>(nullable: false),
                    RankName = table.Column<string>(nullable: true),
                    RoomName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Characters_Ranks_RankName",
                        column: x => x.RankName,
                        principalTable: "Ranks",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Rooms_RoomName",
                        column: x => x.RoomName,
                        principalTable: "Rooms",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_FactionName",
                table: "Areas",
                column: "FactionName");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RankName",
                table: "Characters",
                column: "RankName");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RoomName",
                table: "Characters",
                column: "RoomName");

            migrationBuilder.CreateIndex(
                name: "IX_Ranks_FactionName",
                table: "Ranks",
                column: "FactionName");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_AreaName",
                table: "Rooms",
                column: "AreaName");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_FactionName",
                table: "Rooms",
                column: "FactionName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Factions");
        }
    }
}
