using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TipoQuartoDiscrimination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_reserva",
                table: "tb_reserva");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_quarto",
                table: "tb_quarto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_ocupacao",
                table: "tb_ocupacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_faturamento",
                table: "tb_faturamento");

            migrationBuilder.DropColumn(
                name: "quarto_tipo",
                table: "tb_quarto");

            migrationBuilder.RenameTable(
                name: "tb_reserva",
                newName: "Reserva");

            migrationBuilder.RenameTable(
                name: "tb_quarto",
                newName: "Quarto");

            migrationBuilder.RenameTable(
                name: "tb_ocupacao",
                newName: "RelatorioOcupacao");

            migrationBuilder.RenameTable(
                name: "tb_faturamento",
                newName: "RelatorioFaturamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reserva",
                table: "Reserva",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quarto",
                table: "Quarto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelatorioOcupacao",
                table: "RelatorioOcupacao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelatorioFaturamento",
                table: "RelatorioFaturamento",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reserva",
                table: "Reserva");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelatorioOcupacao",
                table: "RelatorioOcupacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelatorioFaturamento",
                table: "RelatorioFaturamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quarto",
                table: "Quarto");

            migrationBuilder.RenameTable(
                name: "Reserva",
                newName: "tb_reserva");

            migrationBuilder.RenameTable(
                name: "RelatorioOcupacao",
                newName: "tb_ocupacao");

            migrationBuilder.RenameTable(
                name: "RelatorioFaturamento",
                newName: "tb_faturamento");

            migrationBuilder.RenameTable(
                name: "Quarto",
                newName: "tb_quarto");

            migrationBuilder.AddColumn<string>(
                name: "quarto_tipo",
                table: "tb_quarto",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_reserva",
                table: "tb_reserva",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_ocupacao",
                table: "tb_ocupacao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_faturamento",
                table: "tb_faturamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_quarto",
                table: "tb_quarto",
                column: "Id");
        }
    }
}
