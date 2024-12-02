using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Inheritance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vista",
                table: "Quarto",
                newName: "TemVistaParaOMar");

            migrationBuilder.UpdateData(
                table: "Quarto",
                keyColumn: "Numero",
                keyValue: null,
                column: "Numero",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Quarto",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "TemVistaParaOMar",
                table: "Quarto",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true,
                oldDefaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TemVistaParaOMar",
                table: "Quarto",
                newName: "Vista");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Quarto",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "Vista",
                table: "Quarto",
                type: "tinyint(1)",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);
        }
    }
}
