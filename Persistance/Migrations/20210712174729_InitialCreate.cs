using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offenders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ORI = table.Column<string>(type: "ORI", nullable: true),
                    NIC = table.Column<string>(type: "NIC", nullable: true),
                    NAM = table.Column<string>(type: "NAM", nullable: true),
                    SEX = table.Column<string>(type: "SEX", nullable: true),
                    RAC = table.Column<string>(type: "RAC", nullable: true),
                    ETN = table.Column<string>(type: "ETN", nullable: true),
                    POB = table.Column<string>(type: "POB", nullable: true),
                    DOB = table.Column<string>(type: "DOB", nullable: true),
                    ORD = table.Column<string>(type: "ORD", nullable: true),
                    ERD = table.Column<string>(type: "ERD", nullable: true),
                    SXP = table.Column<string>(type: "SXP", nullable: true),
                    HGT = table.Column<string>(type: "HGT", nullable: true),
                    WGT = table.Column<string>(type: "WGT", nullable: true),
                    EYE = table.Column<string>(type: "EYE", nullable: true),
                    HAI = table.Column<string>(type: "HAI", nullable: true),
                    FBI = table.Column<string>(type: "FBI", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offenders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Offenders");
        }
    }
}
