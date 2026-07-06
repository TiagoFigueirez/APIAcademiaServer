using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIAcademia.Migrations
{
    /// <inheritdoc />
    public partial class removeSenhaFunc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Funcionarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
