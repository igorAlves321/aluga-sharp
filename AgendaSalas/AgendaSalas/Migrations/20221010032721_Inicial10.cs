using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaSalas.Migrations
{
    public partial class Inicial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Obgetos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Equipamento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "DisponibilidadeSala",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FazerContratacao = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.ReservaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_ReservaId",
                table: "Servicos",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Obgetos_ReservaId",
                table: "Obgetos",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamento_ReservaId",
                table: "Equipamento",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_DisponibilidadeSala_ReservaId",
                table: "DisponibilidadeSala",
                column: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DisponibilidadeSala_Reserva_ReservaId",
                table: "DisponibilidadeSala",
                column: "ReservaId",
                principalTable: "Reserva",
                principalColumn: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Reserva_ReservaId",
                table: "Equipamento",
                column: "ReservaId",
                principalTable: "Reserva",
                principalColumn: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obgetos_Reserva_ReservaId",
                table: "Obgetos",
                column: "ReservaId",
                principalTable: "Reserva",
                principalColumn: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Reserva_ReservaId",
                table: "Servicos",
                column: "ReservaId",
                principalTable: "Reserva",
                principalColumn: "ReservaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisponibilidadeSala_Reserva_ReservaId",
                table: "DisponibilidadeSala");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Reserva_ReservaId",
                table: "Equipamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Obgetos_Reserva_ReservaId",
                table: "Obgetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Reserva_ReservaId",
                table: "Servicos");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_ReservaId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Obgetos_ReservaId",
                table: "Obgetos");

            migrationBuilder.DropIndex(
                name: "IX_Equipamento_ReservaId",
                table: "Equipamento");

            migrationBuilder.DropIndex(
                name: "IX_DisponibilidadeSala_ReservaId",
                table: "DisponibilidadeSala");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Obgetos");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Equipamento");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "DisponibilidadeSala");
        }
    }
}
