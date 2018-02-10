using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AvanisHerbalSalon.Data.Migrations
{
    public partial class service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HairCare",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "MassageCare",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "NailsCare",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "SkinCare",
                table: "Services");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmEmail",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Services",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_CategoryId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ConfirmEmail",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "HairCare",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MassageCare",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NailsCare",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkinCare",
                table: "Services",
                nullable: true);
        }
    }
}
