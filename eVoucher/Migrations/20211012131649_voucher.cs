using Microsoft.EntityFrameworkCore.Migrations;

namespace eVoucher.Migrations
{
    public partial class voucher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefreshToken",
                table: "RefreshToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "discount",
                table: "PaymentMethods");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "RefreshToken",
                newName: "refreshtoken");

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "paymentmethods");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "users",
                newName: "updateddate");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "users",
                newName: "lastupdatedby");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "users",
                newName: "fullname");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "users",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "users",
                newName: "createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "refreshtoken",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "Token",
                table: "refreshtoken",
                newName: "token");

            migrationBuilder.RenameColumn(
                name: "RevokedByIp",
                table: "refreshtoken",
                newName: "revokedbyip");

            migrationBuilder.RenameColumn(
                name: "Revoked",
                table: "refreshtoken",
                newName: "revoked");

            migrationBuilder.RenameColumn(
                name: "ReplacedByToken",
                table: "refreshtoken",
                newName: "replacedbytoken");

            migrationBuilder.RenameColumn(
                name: "ReasonRevoked",
                table: "refreshtoken",
                newName: "reasonrevoked");

            migrationBuilder.RenameColumn(
                name: "Expires",
                table: "refreshtoken",
                newName: "expires");

            migrationBuilder.RenameColumn(
                name: "CreatedByIp",
                table: "refreshtoken",
                newName: "createdbyip");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "refreshtoken",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "refreshtoken",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshToken_UserId",
                table: "refreshtoken",
                newName: "ix_refreshtoken_userid");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "paymentmethods",
                newName: "updateddate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedBy",
                table: "paymentmethods",
                newName: "lastupdatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "paymentmethods",
                newName: "createddate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "paymentmethods",
                newName: "createdby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "paymentmethods",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_refreshtoken",
                table: "refreshtoken",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_paymentmethods",
                table: "paymentmethods",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_refreshtoken_users_userid",
                table: "refreshtoken",
                column: "userid",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_refreshtoken_users_userid",
                table: "refreshtoken");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_refreshtoken",
                table: "refreshtoken");

            migrationBuilder.DropPrimaryKey(
                name: "pk_paymentmethods",
                table: "paymentmethods");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "refreshtoken",
                newName: "RefreshToken");

            migrationBuilder.RenameTable(
                name: "paymentmethods",
                newName: "PaymentMethods");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "updateddate",
                table: "Users",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastupdatedby",
                table: "Users",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "fullname",
                table: "Users",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "Users",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "createdby",
                table: "Users",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "RefreshToken",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "token",
                table: "RefreshToken",
                newName: "Token");

            migrationBuilder.RenameColumn(
                name: "revokedbyip",
                table: "RefreshToken",
                newName: "RevokedByIp");

            migrationBuilder.RenameColumn(
                name: "revoked",
                table: "RefreshToken",
                newName: "Revoked");

            migrationBuilder.RenameColumn(
                name: "replacedbytoken",
                table: "RefreshToken",
                newName: "ReplacedByToken");

            migrationBuilder.RenameColumn(
                name: "reasonrevoked",
                table: "RefreshToken",
                newName: "ReasonRevoked");

            migrationBuilder.RenameColumn(
                name: "expires",
                table: "RefreshToken",
                newName: "Expires");

            migrationBuilder.RenameColumn(
                name: "createdbyip",
                table: "RefreshToken",
                newName: "CreatedByIp");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "RefreshToken",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "RefreshToken",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "ix_refreshtoken_userid",
                table: "RefreshToken",
                newName: "IX_RefreshToken_UserId");

            migrationBuilder.RenameColumn(
                name: "updateddate",
                table: "PaymentMethods",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "lastupdatedby",
                table: "PaymentMethods",
                newName: "LastUpdatedBy");

            migrationBuilder.RenameColumn(
                name: "createddate",
                table: "PaymentMethods",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "createdby",
                table: "PaymentMethods",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PaymentMethods",
                newName: "Id");

            migrationBuilder.AddColumn<float>(
                name: "discount",
                table: "PaymentMethods",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefreshToken",
                table: "RefreshToken",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshToken_Users_UserId",
                table: "RefreshToken",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
