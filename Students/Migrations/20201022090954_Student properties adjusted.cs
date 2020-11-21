using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Students.Migrations
{
    public partial class Studentpropertiesadjusted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClasseClassseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClasseClassseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClasseClassseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassseId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClaasseLevel",
                table: "Classes");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "BrothersInSchool",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrothersNumber",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasseId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyStatus",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOrphan",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentFirstName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentLasttName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentPhone",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ParentProfession",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClasseId",
                table: "Classes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ClasseLevel",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClasseId",
                table: "Students",
                column: "ClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClasseId",
                table: "Students",
                column: "ClasseId",
                principalTable: "Classes",
                principalColumn: "ClasseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClasseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClasseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BrothersInSchool",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BrothersNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FamilyStatus",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsOrphan",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentFirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentLasttName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentPhone",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentProfession",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClasseLevel",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClasseClassseId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassseId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ClaasseLevel",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "ClassseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClasseClassseId",
                table: "Students",
                column: "ClasseClassseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClasseClassseId",
                table: "Students",
                column: "ClasseClassseId",
                principalTable: "Classes",
                principalColumn: "ClassseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
