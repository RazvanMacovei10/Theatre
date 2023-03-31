﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateRegisterForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalSeats",
                table: "RegisterForms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSeats",
                table: "RegisterForms");
        }
    }
}
