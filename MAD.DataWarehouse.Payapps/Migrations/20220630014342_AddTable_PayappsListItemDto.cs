using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAD.DataWarehouse.Payapps.Migrations
{
    public partial class AddTable_PayappsListItemDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayappsListItemDto",
                columns: table => new
                {
                    Claim_id = table.Column<double>(type: "float", nullable: false),
                    External_integration_key_primary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Project_ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Project_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contract_id = table.Column<double>(type: "float", nullable: true),
                    Contract_ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contract_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vat_reverse_charge_ind = table.Column<bool>(type: "bit", nullable: true),
                    Counterparty_role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Counterparty_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claim_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claim_seq_no = table.Column<double>(type: "float", nullable: true),
                    Claimant_invoice_ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retention_to_date = table.Column<double>(type: "float", nullable: true),
                    Discount_calc = table.Column<double>(type: "float", nullable: true),
                    Discount_calc_at_approved = table.Column<double>(type: "float", nullable: true),
                    Labour_claimed_to_date = table.Column<double>(type: "float", nullable: true),
                    Labour_approved_to_date = table.Column<double>(type: "float", nullable: true),
                    Claim_as_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Submitted_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approval_due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment_due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Final_payment_due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lines_claimed = table.Column<double>(type: "float", nullable: true),
                    Lines_approved = table.Column<double>(type: "float", nullable: true),
                    Materials_claimed = table.Column<double>(type: "float", nullable: true),
                    Materials_approved = table.Column<double>(type: "float", nullable: true),
                    Contra_this_approve = table.Column<double>(type: "float", nullable: true),
                    Contra_approved = table.Column<double>(type: "float", nullable: true),
                    Tax_this_claim_submitted = table.Column<double>(type: "float", nullable: true),
                    Pln_is_draft = table.Column<bool>(type: "bit", nullable: true),
                    Pln_variance_this_claim = table.Column<double>(type: "float", nullable: true),
                    Pp_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lines_this_claim = table.Column<double>(type: "float", nullable: true),
                    Lines_this_approve = table.Column<double>(type: "float", nullable: true),
                    Discount_this_claim = table.Column<double>(type: "float", nullable: true),
                    Previous_discount = table.Column<double>(type: "float", nullable: true),
                    Retention_claimed_this_claim = table.Column<double>(type: "float", nullable: true),
                    Retention_approved_this_claim = table.Column<double>(type: "float", nullable: true),
                    Previous_retention = table.Column<double>(type: "float", nullable: true),
                    Variations_this_claim = table.Column<double>(type: "float", nullable: true),
                    Materials_this_claim = table.Column<double>(type: "float", nullable: true),
                    Materials_this_approve = table.Column<double>(type: "float", nullable: true),
                    Tax_this_claim_approved = table.Column<double>(type: "float", nullable: true),
                    Claimed = table.Column<double>(type: "float", nullable: true),
                    Assessed = table.Column<double>(type: "float", nullable: true),
                    Gross_approved = table.Column<double>(type: "float", nullable: true),
                    Non_labour_to_date = table.Column<double>(type: "float", nullable: true),
                    Net_approved_to_date = table.Column<double>(type: "float", nullable: true),
                    Previous_gross_approved = table.Column<double>(type: "float", nullable: true),
                    Previous_net_approved_to_date = table.Column<double>(type: "float", nullable: true),
                    Net_approved_before_taxes = table.Column<double>(type: "float", nullable: true),
                    Discounted_total_this_claim = table.Column<double>(type: "float", nullable: true),
                    Sc_total_projected_amount = table.Column<double>(type: "float", nullable: true),
                    Mc_total_projected_amount = table.Column<double>(type: "float", nullable: true),
                    Varations_this_approve = table.Column<double>(type: "float", nullable: true),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayappsListItemDto", x => x.Claim_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayappsListItemDto");
        }
    }
}
