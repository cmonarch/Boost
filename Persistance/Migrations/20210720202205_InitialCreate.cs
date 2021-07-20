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
                    ORI = table.Column<string>(type: "TEXT", nullable: true),
                    NIC = table.Column<string>(type: "TEXT", nullable: true),
                    NAM = table.Column<string>(type: "TEXT", nullable: true),
                    SEX = table.Column<string>(type: "TEXT", nullable: true),
                    RAC = table.Column<string>(type: "TEXT", nullable: true),
                    ETN = table.Column<string>(type: "TEXT", nullable: true),
                    POB = table.Column<string>(type: "TEXT", nullable: true),
                    DOB = table.Column<string>(type: "TEXT", nullable: true),
                    ORD = table.Column<string>(type: "TEXT", nullable: true),
                    ERD = table.Column<string>(type: "TEXT", nullable: true),
                    SXP = table.Column<string>(type: "TEXT", nullable: true),
                    HGT = table.Column<string>(type: "TEXT", nullable: true),
                    WGT = table.Column<string>(type: "TEXT", nullable: true),
                    EYE = table.Column<string>(type: "TEXT", nullable: true),
                    HAI = table.Column<string>(type: "TEXT", nullable: true),
                    FBI = table.Column<string>(type: "TEXT", nullable: true),
                    SKN = table.Column<string>(type: "TEXT", nullable: true),
                    SMT = table.Column<string>(type: "TEXT", nullable: true),
                    FPC = table.Column<string>(type: "TEXT", nullable: true),
                    MNU = table.Column<string>(type: "TEXT", nullable: true),
                    SOC = table.Column<string>(type: "TEXT", nullable: true),
                    OLN = table.Column<string>(type: "TEXT", nullable: true),
                    OLS = table.Column<string>(type: "TEXT", nullable: true),
                    OLY = table.Column<string>(type: "TEXT", nullable: true),
                    CRR = table.Column<string>(type: "TEXT", nullable: true),
                    CON = table.Column<string>(type: "TEXT", nullable: true),
                    TIR = table.Column<string>(type: "TEXT", nullable: true),
                    JUV = table.Column<string>(type: "TEXT", nullable: true),
                    PLC = table.Column<string>(type: "TEXT", nullable: true),
                    AOV = table.Column<string>(type: "TEXT", nullable: true),
                    SOV = table.Column<string>(type: "TEXT", nullable: true),
                    ROV = table.Column<string>(type: "TEXT", nullable: true),
                    OCA = table.Column<string>(type: "TEXT", nullable: true),
                    SID = table.Column<string>(type: "TEXT", nullable: true),
                    LKI = table.Column<string>(type: "TEXT", nullable: true),
                    LKA = table.Column<string>(type: "TEXT", nullable: true),
                    MIS = table.Column<string>(type: "TEXT", nullable: true),
                    LIC = table.Column<string>(type: "TEXT", nullable: true),
                    LIS = table.Column<string>(type: "TEXT", nullable: true),
                    LIY = table.Column<string>(type: "TEXT", nullable: true),
                    LIT = table.Column<string>(type: "TEXT", nullable: true),
                    VIN = table.Column<string>(type: "TEXT", nullable: true),
                    VYR = table.Column<string>(type: "TEXT", nullable: true),
                    VMA = table.Column<string>(type: "TEXT", nullable: true),
                    VMO = table.Column<string>(type: "TEXT", nullable: true),
                    VST = table.Column<string>(type: "TEXT", nullable: true),
                    VCO = table.Column<string>(type: "TEXT", nullable: true),
                    VOW = table.Column<string>(type: "TEXT", nullable: true),
                    OFS = table.Column<string>(type: "TEXT", nullable: true),
                    CMC = table.Column<string>(type: "TEXT", nullable: true),
                    DNA = table.Column<string>(type: "TEXT", nullable: true),
                    DLO = table.Column<string>(type: "TEXT", nullable: true),
                    CTZ = table.Column<string>(type: "TEXT", nullable: true),
                    ADD = table.Column<string>(type: "TEXT", nullable: true),
                    BDA = table.Column<string>(type: "TEXT", nullable: true),
                    EDA = table.Column<string>(type: "TEXT", nullable: true),
                    SNU = table.Column<string>(type: "TEXT", nullable: true),
                    SNA = table.Column<string>(type: "TEXT", nullable: true),
                    CTY = table.Column<string>(type: "TEXT", nullable: true),
                    COU = table.Column<string>(type: "TEXT", nullable: true),
                    STA = table.Column<string>(type: "TEXT", nullable: true),
                    ZIP = table.Column<string>(type: "TEXT", nullable: true),
                    TNO = table.Column<string>(type: "TEXT", nullable: true),
                    TNT = table.Column<string>(type: "TEXT", nullable: true),
                    EML = table.Column<string>(type: "TEXT", nullable: true),
                    IID = table.Column<string>(type: "TEXT", nullable: true),
                    SHN = table.Column<string>(type: "TEXT", nullable: true),
                    EMP = table.Column<string>(type: "TEXT", nullable: true),
                    OCP = table.Column<string>(type: "TEXT", nullable: true),
                    PLN = table.Column<string>(type: "TEXT", nullable: true),
                    PLT = table.Column<string>(type: "TEXT", nullable: true),
                    REG = table.Column<string>(type: "TEXT", nullable: true),
                    RES = table.Column<string>(type: "TEXT", nullable: true),
                    REY = table.Column<string>(type: "TEXT", nullable: true),
                    BHN = table.Column<string>(type: "TEXT", nullable: true),
                    BYR = table.Column<string>(type: "TEXT", nullable: true),
                    BMA = table.Column<string>(type: "TEXT", nullable: true),
                    BTY = table.Column<string>(type: "TEXT", nullable: true),
                    BMO = table.Column<string>(type: "TEXT", nullable: true),
                    BCO = table.Column<string>(type: "TEXT", nullable: true),
                    BLE = table.Column<string>(type: "TEXT", nullable: true),
                    PRO = table.Column<string>(type: "TEXT", nullable: true),
                    HUL = table.Column<string>(type: "TEXT", nullable: true),
                    HSP = table.Column<string>(type: "TEXT", nullable: true),
                    HPT = table.Column<string>(type: "TEXT", nullable: true),
                    BNM = table.Column<string>(type: "TEXT", nullable: true),
                    CGD = table.Column<string>(type: "TEXT", nullable: true),
                    AKA01 = table.Column<string>(type: "TEXT", nullable: true),
                    AKA02 = table.Column<string>(type: "TEXT", nullable: true),
                    AKA03 = table.Column<string>(type: "TEXT", nullable: true),
                    AKA04 = table.Column<string>(type: "TEXT", nullable: true),
                    AKA05 = table.Column<string>(type: "TEXT", nullable: true),
                    AKA06 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offenders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offenders");
        }
    }
}
