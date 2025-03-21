﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DangThanhTin.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "TheLoai",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identify", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TheLoai", x  => x.Id);
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TheLoai");
                
            }
        }
    }
