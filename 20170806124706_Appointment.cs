using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AvanisHerbalSalon.Data.Migrations
{
    public partial class Appointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_HairCare_FemaleHairCutId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_HairCare_MaleHairCutId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_FemaleHairCutId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_MaleHairCutId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "FemaleHairCutId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "MaleHairCutId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "HairCare");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.AddColumn<string>(
                name: "HairCare",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HairCare",
                table: "Services");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.CreateTable(
                name: "HairCare",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCare", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "FemaleHairCutId",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaleHairCutId",
                table: "Services",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_FemaleHairCutId",
                table: "Services",
                column: "FemaleHairCutId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_MaleHairCutId",
                table: "Services",
                column: "MaleHairCutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_HairCare_FemaleHairCutId",
                table: "Services",
                column: "FemaleHairCutId",
                principalTable: "HairCare",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_HairCare_MaleHairCutId",
                table: "Services",
                column: "MaleHairCutId",
                principalTable: "HairCare",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
