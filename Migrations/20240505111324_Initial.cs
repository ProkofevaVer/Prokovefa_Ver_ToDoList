using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prokovefa_Ver_ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_task", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deletetask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskID = table.Column<int>(type: "int", nullable: false),
                    dateTimev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deletetask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deletetask_task_taskID",
                        column: x => x.taskID,
                        principalTable: "task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deletetask_taskID",
                table: "Deletetask",
                column: "taskID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deletetask");

            migrationBuilder.DropTable(
                name: "task");
        }
    }
}
