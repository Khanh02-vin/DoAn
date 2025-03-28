﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DangThanhTin.Data.Migrations
{
    /// <inheritdoc />
    public partial class sanpham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "SanPham",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Name = table.Column<string>(nullable: false),
                   Price = table.Column<double>(nullable: false),
                   Description = table.Column<string>(nullable: true),
                   ImageUrl = table.Column<string>(nullable: true),
                   TheLoaiId = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_SanPham", x => x.Id);
                   table.ForeignKey(
                       name: "FK_SanPham_TheLoai_TheLoaiId",
                       column: x => x.TheLoaiId,
                       principalTable: "TheLoai",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_TheLoaiId",
                table: "SanPham",
                column: "TheLoaiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "SanPham");
        }
    }
}
