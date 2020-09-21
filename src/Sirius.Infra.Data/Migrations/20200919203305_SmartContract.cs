using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sirius.Infra.Data.Migrations
{
    public partial class SmartContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SmartContracts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TerminationCondition = table.Column<string>(nullable: true),
                    ConclusionCondition = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    AuthKey = table.Column<string>(nullable: true),
                    CodePayment = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    ReasonTermination = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Inactived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartContracts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmartContracts");
        }
    }
}
