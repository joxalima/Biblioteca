using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaMVC.Migrations
{
    /// <inheritdoc />
    public partial class CriatTabelaEmprestimos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRetirada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntrega = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    AlunoRA = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LivroCodigo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Alunos_AlunoRA",
                        column: x => x.AlunoRA,
                        principalTable: "Alunos",
                        principalColumn: "RA");
                    table.ForeignKey(
                        name: "FK_Emprestimos_Livros_LivroCodigo",
                        column: x => x.LivroCodigo,
                        principalTable: "Livros",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_AlunoRA",
                table: "Emprestimos",
                column: "AlunoRA");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_LivroCodigo",
                table: "Emprestimos",
                column: "LivroCodigo");
        }

    }
}
