using Microsoft.EntityFrameworkCore.Migrations;

namespace MyInvoices.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customer_CustId",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDets",
                table: "InvoiceDets");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameTable(
                name: "InvoiceDets",
                newName: "InvoiceDet");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CustId",
                table: "Invoice",
                newName: "IX_Invoice_CustId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "InvId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDet",
                table: "InvoiceDet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Customer_CustId",
                table: "Invoice",
                column: "CustId",
                principalTable: "Customer",
                principalColumn: "CustId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Customer_CustId",
                table: "Invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDet",
                table: "InvoiceDet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "InvoiceDet",
                newName: "InvoiceDets");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_CustId",
                table: "Invoices",
                newName: "IX_Invoices_CustId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDets",
                table: "InvoiceDets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "InvId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customer_CustId",
                table: "Invoices",
                column: "CustId",
                principalTable: "Customer",
                principalColumn: "CustId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
