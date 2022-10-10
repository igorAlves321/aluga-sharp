using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaSalas.Migrations
{
    public partial class Inicial08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisponibilidadeSalaId",
                table: "Sala",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeriodoId",
                table: "Horario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DisponibilidadeSala",
                columns: table => new
                {
                    DisponibilidadeSalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisponibilidadeSala", x => x.DisponibilidadeSalaId);
                });

            migrationBuilder.CreateTable(
                name: "Periodo",
                columns: table => new
                {
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    estaAtiva = table.Column<bool>(type: "bit", nullable: true),
                    DisponibilidadeSalaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodo", x => x.PeriodoId);
                    table.ForeignKey(
                        name: "FK_Periodo_DisponibilidadeSala_DisponibilidadeSalaId",
                        column: x => x.DisponibilidadeSalaId,
                        principalTable: "DisponibilidadeSala",
                        principalColumn: "DisponibilidadeSalaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sala_DisponibilidadeSalaId",
                table: "Sala",
                column: "DisponibilidadeSalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_PeriodoId",
                table: "Horario",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_Periodo_DisponibilidadeSalaId",
                table: "Periodo",
                column: "DisponibilidadeSalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Periodo_PeriodoId",
                table: "Horario",
                column: "PeriodoId",
                principalTable: "Periodo",
                principalColumn: "PeriodoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sala_DisponibilidadeSala_DisponibilidadeSalaId",
                table: "Sala",
                column: "DisponibilidadeSalaId",
                principalTable: "DisponibilidadeSala",
                principalColumn: "DisponibilidadeSalaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Periodo_PeriodoId",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Sala_DisponibilidadeSala_DisponibilidadeSalaId",
                table: "Sala");

            migrationBuilder.DropTable(
                name: "Periodo");

            migrationBuilder.DropTable(
                name: "DisponibilidadeSala");

            migrationBuilder.DropIndex(
                name: "IX_Sala_DisponibilidadeSalaId",
                table: "Sala");

            migrationBuilder.DropIndex(
                name: "IX_Horario_PeriodoId",
                table: "Horario");

            migrationBuilder.DropColumn(
                name: "DisponibilidadeSalaId",
                table: "Sala");

            migrationBuilder.DropColumn(
                name: "PeriodoId",
                table: "Horario");
        }
    }
}
