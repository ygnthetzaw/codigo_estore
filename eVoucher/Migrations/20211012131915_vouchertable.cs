using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eVoucher.Migrations
{
    public partial class vouchertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "buytypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    typename = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createddate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    createdby = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastupdatedby = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_buytypes", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "discounttypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createddate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    createdby = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastupdatedby = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_discounttypes", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    expirydate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    imageurl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    amount = table.Column<int>(type: "int", nullable: false),
                    paymentmethodid = table.Column<int>(type: "int", nullable: false),
                    paymentmethoddiscount = table.Column<int>(type: "int", nullable: false),
                    discounttypeid = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    createdby = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastupdatedby = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vouchers", x => x.id);
                    table.ForeignKey(
                        name: "fk_vouchers_discounttypes_discounttypeid",
                        column: x => x.discounttypeid,
                        principalTable: "discounttypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vouchers_paymentmethods_paymentmethodid",
                        column: x => x.paymentmethodid,
                        principalTable: "paymentmethods",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_vouchers_discounttypeid",
                table: "vouchers",
                column: "discounttypeid");

            migrationBuilder.CreateIndex(
                name: "ix_vouchers_paymentmethodid",
                table: "vouchers",
                column: "paymentmethodid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "buytypes");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "discounttypes");
        }
    }
}
