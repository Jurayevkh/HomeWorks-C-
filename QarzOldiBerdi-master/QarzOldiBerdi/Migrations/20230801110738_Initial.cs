using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace QarzOldiBerdi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "qarzBeruvchi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    QarzOluvchiId = table.Column<int>(type: "integer", nullable: false),
                    Muddat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qarzBeruvchi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qarzdor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qarzdor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qarz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    qarzBeruvchiId = table.Column<int>(type: "integer", nullable: false),
                    qarzOluvchiId = table.Column<int>(type: "integer", nullable: false),
                    qarzdorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qarz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qarz_qarzBeruvchi_qarzBeruvchiId",
                        column: x => x.qarzBeruvchiId,
                        principalTable: "qarzBeruvchi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_qarz_qarz_qarzOluvchiId",
                        column: x => x.qarzOluvchiId,
                        principalTable: "qarz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_qarz_qarzdor_qarzdorId",
                        column: x => x.qarzdorId,
                        principalTable: "qarzdor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_qarz_qarzBeruvchiId",
                table: "qarz",
                column: "qarzBeruvchiId");

            migrationBuilder.CreateIndex(
                name: "IX_qarz_qarzdorId",
                table: "qarz",
                column: "qarzdorId");

            migrationBuilder.CreateIndex(
                name: "IX_qarz_qarzOluvchiId",
                table: "qarz",
                column: "qarzOluvchiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "qarz");

            migrationBuilder.DropTable(
                name: "qarzBeruvchi");

            migrationBuilder.DropTable(
                name: "qarzdor");
        }
    }
}
