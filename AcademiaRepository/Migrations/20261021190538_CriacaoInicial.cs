using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AcademiaRepository.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StatusMatricula = table.Column<bool>(type: "boolean", nullable: false),
                    CPF = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Divisao",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisao", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Exercicio",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GrupoMuscular = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicio", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Treino",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DataInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataFim = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AlunoID = table.Column<int>(type: "integer", nullable: false),
                    DivisaoID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treino", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Treino_Aluno_AlunoID",
                        column: x => x.AlunoID,
                        principalTable: "Aluno",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treino_Divisao_DivisaoID",
                        column: x => x.DivisaoID,
                        principalTable: "Divisao",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemTreino",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TreinoID = table.Column<int>(type: "integer", nullable: false),
                    ExercicioID = table.Column<int>(type: "integer", nullable: false),
                    Series = table.Column<int>(type: "integer", nullable: false),
                    Repeticoes = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CargaRecomendada = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTreino", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemTreino_Exercicio_ExercicioID",
                        column: x => x.ExercicioID,
                        principalTable: "Exercicio",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTreino_Treino_TreinoID",
                        column: x => x.TreinoID,
                        principalTable: "Treino",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemTreino_ExercicioID",
                table: "ItemTreino",
                column: "ExercicioID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTreino_TreinoID",
                table: "ItemTreino",
                column: "TreinoID");

            migrationBuilder.CreateIndex(
                name: "IX_Treino_AlunoID",
                table: "Treino",
                column: "AlunoID");

            migrationBuilder.CreateIndex(
                name: "IX_Treino_DivisaoID",
                table: "Treino",
                column: "DivisaoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemTreino");

            migrationBuilder.DropTable(
                name: "Exercicio");

            migrationBuilder.DropTable(
                name: "Treino");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Divisao");
        }
    }
}
