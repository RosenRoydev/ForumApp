﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumApp.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Post identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Post Title"),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "Post Content")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                },
                comment: "All posts table");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
