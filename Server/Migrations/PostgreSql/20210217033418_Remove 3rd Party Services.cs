﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace nexRemote.Server.Migrations.PostgreSql
{
    public partial class Remove3rdPartyServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GithubUser",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "SponsorAmount",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "UnlockCode",
                table: "Organizations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GithubUser",
                table: "Organizations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SponsorAmount",
                table: "Organizations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "UnlockCode",
                table: "Organizations",
                type: "text",
                nullable: true);
        }
    }
}
