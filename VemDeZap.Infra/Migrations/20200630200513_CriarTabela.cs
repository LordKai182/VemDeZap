using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VemDeZap.Infra.Migrations
{
    public partial class CriarTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PrimeiroNome = table.Column<string>(maxLength: 100, nullable: false),
                    UltimoNome = table.Column<string>(maxLength: 100, nullable: false),
                    Senha = table.Column<string>(maxLength: 36, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campanhas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanhas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campanhas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Nicho = table.Column<int>(nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contatos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Nicho = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CampanhaId = table.Column<Guid>(nullable: true),
                    GrupoId = table.Column<Guid>(nullable: true),
                    ContatoId = table.Column<Guid>(nullable: true),
                    Enviado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Envios_Campanhas_CampanhaId",
                        column: x => x.CampanhaId,
                        principalTable: "Campanhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Envios_Contatos_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Envios_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campanhas_UsuarioId",
                table: "Campanhas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_IdUsuario",
                table: "Contatos",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_CampanhaId",
                table: "Envios",
                column: "CampanhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_ContatoId",
                table: "Envios",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_GrupoId",
                table: "Envios",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_IdUsuario",
                table: "Grupos",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Envios");

            migrationBuilder.DropTable(
                name: "Campanhas");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
