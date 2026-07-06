using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIAcademia.Migrations
{
    /// <inheritdoc />
    public partial class tirarUnidadeObg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Usuarios",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Unidades",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Treinos",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Professores",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Manutencaoes",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Grupos",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Funcionarios",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "ExericiosTreino",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Exercicios",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Equipamentos",
                newName: "IsAtivo");

            migrationBuilder.RenameColumn(
                name: "IsAti",
                table: "Alunos",
                newName: "IsAtivo");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadeId",
                table: "Funcionarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Usuarios",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Unidades",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Treinos",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Professores",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Manutencaoes",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Grupos",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Funcionarios",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "ExericiosTreino",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Exercicios",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Equipamentos",
                newName: "IsAti");

            migrationBuilder.RenameColumn(
                name: "IsAtivo",
                table: "Alunos",
                newName: "IsAti");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadeId",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
