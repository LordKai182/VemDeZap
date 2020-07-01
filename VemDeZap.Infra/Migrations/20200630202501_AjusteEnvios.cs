using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VemDeZap.Infra.Migrations
{
    public partial class AjusteEnvios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Campanhas_CampanhaId",
                table: "Envios");

            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Contatos_ContatoId",
                table: "Envios");

            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Grupos_GrupoId",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_CampanhaId",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_ContatoId",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_GrupoId",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "CampanhaId",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "ContatoId",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Envios");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCampanha",
                table: "Envios",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdContatos",
                table: "Envios",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdGrupo",
                table: "Envios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IdCampanha",
                table: "Envios",
                column: "IdCampanha");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IdContatos",
                table: "Envios",
                column: "IdContatos");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IdGrupo",
                table: "Envios",
                column: "IdGrupo");

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Campanhas_IdCampanha",
                table: "Envios",
                column: "IdCampanha",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Contatos_IdContatos",
                table: "Envios",
                column: "IdContatos",
                principalTable: "Contatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Grupos_IdGrupo",
                table: "Envios",
                column: "IdGrupo",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Campanhas_IdCampanha",
                table: "Envios");

            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Contatos_IdContatos",
                table: "Envios");

            migrationBuilder.DropForeignKey(
                name: "FK_Envios_Grupos_IdGrupo",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_IdCampanha",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_IdContatos",
                table: "Envios");

            migrationBuilder.DropIndex(
                name: "IX_Envios_IdGrupo",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "IdCampanha",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "IdContatos",
                table: "Envios");

            migrationBuilder.DropColumn(
                name: "IdGrupo",
                table: "Envios");

            migrationBuilder.AddColumn<Guid>(
                name: "CampanhaId",
                table: "Envios",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ContatoId",
                table: "Envios",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GrupoId",
                table: "Envios",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Campanhas_CampanhaId",
                table: "Envios",
                column: "CampanhaId",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Contatos_ContatoId",
                table: "Envios",
                column: "ContatoId",
                principalTable: "Contatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envios_Grupos_GrupoId",
                table: "Envios",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
