using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AracTescil.Migrations
{
    public partial class ApplyConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Markalar_MarkaId",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Modeller");

            migrationBuilder.RenameIndex(
                name: "IX_Model_MarkaId",
                table: "Modeller",
                newName: "IX_Modeller_MarkaId");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Modeller",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Markalar",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modeller",
                table: "Modeller",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modeller_Markalar_MarkaId",
                table: "Modeller",
                column: "MarkaId",
                principalTable: "Markalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modeller_Markalar_MarkaId",
                table: "Modeller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modeller",
                table: "Modeller");

            migrationBuilder.RenameTable(
                name: "Modeller",
                newName: "Model");

            migrationBuilder.RenameIndex(
                name: "IX_Modeller_MarkaId",
                table: "Model",
                newName: "IX_Model_MarkaId");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Model",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Markalar",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Markalar_MarkaId",
                table: "Model",
                column: "MarkaId",
                principalTable: "Markalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
