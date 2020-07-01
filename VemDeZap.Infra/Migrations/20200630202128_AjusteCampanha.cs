using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VemDeZap.Infra.Migrations
{
    public partial class AjusteCampanha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanhas_Usuarios_UsuarioId",
                table: "Campanhas");

            migrationBuilder.DropIndex(
                name: "IX_Campanhas_UsuarioId",
                table: "Campanhas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Campanhas");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanhas",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Campanhas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campanhas_IdUsuario",
                table: "Campanhas",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Campanhas_Usuarios_IdUsuario",
                table: "Campanhas",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campanhas_Usuarios_IdUsuario",
                table: "Campanhas");

            migrationBuilder.DropIndex(
                name: "IX_Campanhas_IdUsuario",
                table: "Campanhas");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Campanhas");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanhas",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Campanhas",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campanhas_UsuarioId",
                table: "Campanhas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campanhas_Usuarios_UsuarioId",
                table: "Campanhas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
