using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAD.DataWarehouse.Payapps.Migrations
{
    public partial class AddTable_PayappsDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayappDto",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    Summary_This_claim_Original_works = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Contra_charges = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Materials = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Variations_approved = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Variations_on_account = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Variations_rejected = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Revised_works = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Revised_works_and_voa = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Discount = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Discounted_total = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Retention_withheld = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Retention_released = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Cash_retention = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Cash_retention_tax = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Net_claim_excl_tax = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Financeable_tax = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Tax = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Net_claim_incl_tax = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_Discount_coefficient = table.Column<double>(type: "float", nullable: true),
                    Summary_This_claim_AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary_AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contract_id = table.Column<double>(type: "float", nullable: true),
                    Organisation_id = table.Column<double>(type: "float", nullable: true),
                    Claim_seq_no = table.Column<double>(type: "float", nullable: true),
                    Claim_ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claim_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    My_role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claim_as_at_start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claim_as_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Submitted_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approval_due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Variation_negotiation_enabled = table.Column<bool>(type: "bit", nullable: true),
                    Claimant_invoice_ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retention_calc = table.Column<double>(type: "float", nullable: true),
                    Retention_calc_at_approved = table.Column<double>(type: "float", nullable: true),
                    Retention_release_ind = table.Column<bool>(type: "bit", nullable: true),
                    Retention_applied = table.Column<double>(type: "float", nullable: true),
                    Retention_withheld_override = table.Column<double>(type: "float", nullable: true),
                    Retention_excl_release_this_claim = table.Column<double>(type: "float", nullable: true),
                    Retention_this_claim = table.Column<double>(type: "float", nullable: true),
                    Retention_release_requested = table.Column<double>(type: "float", nullable: true),
                    Retention_released = table.Column<double>(type: "float", nullable: true),
                    Retention_released_mod_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retention_withheld_mod_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Labour_claimed_to_date = table.Column<double>(type: "float", nullable: true),
                    Labour_approved_to_date = table.Column<double>(type: "float", nullable: true),
                    Labour_claimed_this_claim = table.Column<double>(type: "float", nullable: true),
                    Labour_approved_this_claim = table.Column<double>(type: "float", nullable: true),
                    Labour_previous_approved = table.Column<double>(type: "float", nullable: true),
                    Labour_mod_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Days_to_approve = table.Column<double>(type: "float", nullable: true),
                    Claim_limit_reached = table.Column<bool>(type: "bit", nullable: true),
                    Pay_per_claim_credits = table.Column<double>(type: "float", nullable: true),
                    Acknowledge_instructions = table.Column<bool>(type: "bit", nullable: true),
                    Contraitems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Variationitems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tax_rate = table.Column<double>(type: "float", nullable: true),
                    Pln_Id = table.Column<double>(type: "float", nullable: true),
                    Pln_Eligible = table.Column<bool>(type: "bit", nullable: true),
                    Pln_Approved_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pln_Deleted_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pln_Adjustments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pln_AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total_works = table.Column<double>(type: "float", nullable: true),
                    Total_approved_to_date = table.Column<double>(type: "float", nullable: true),
                    Total_this_claim = table.Column<double>(type: "float", nullable: true),
                    Total_claimed = table.Column<double>(type: "float", nullable: true),
                    Total_approved = table.Column<double>(type: "float", nullable: true),
                    Total_claimed_orig = table.Column<double>(type: "float", nullable: true),
                    Total_claimed_var = table.Column<double>(type: "float", nullable: true),
                    Total_approved_orig = table.Column<double>(type: "float", nullable: true),
                    Total_approved_var = table.Column<double>(type: "float", nullable: true),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayappDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClaimlineSectionDto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PayappDtoId = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimlineSectionDto", x => new { x.PayappDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_ClaimlineSectionDto_PayappDto_PayappDtoId",
                        column: x => x.PayappDtoId,
                        principalTable: "PayappDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MateriallinesSectionDto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PayappDtoId = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line_ref_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriallinesSectionDto", x => new { x.PayappDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_MateriallinesSectionDto_PayappDto_PayappDtoId",
                        column: x => x.PayappDtoId,
                        principalTable: "PayappDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayappActionHistoryDto",
                columns: table => new
                {
                    PayappDtoId = table.Column<double>(type: "float", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<double>(type: "float", nullable: false),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayappActionHistoryDto", x => new { x.PayappDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_PayappActionHistoryDto_PayappDto_PayappDtoId",
                        column: x => x.PayappDtoId,
                        principalTable: "PayappDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClaimlineSectionDtoNode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PayappDtoId = table.Column<double>(type: "float", nullable: false),
                    ClaimlineSectionDtoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line_ref_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_Id = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_LineRefCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_Rate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractLineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_RetExclInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_TaxExemptInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Claimline_LockedInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_ExternalIntegrationKeyPrimary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_Qty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_LumpSumInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_UnitType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_VariableBudgetInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_DiscountInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Claimline_ClaimantProjectedRate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimantProjectedQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_TaxRate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractLineId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimPct = table.Column<double>(type: "float", nullable: true),
                    Claimline_ApproveAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApprovePct = table.Column<double>(type: "float", nullable: true),
                    Claimline_RateAtClaimed = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_RateAtApproved = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_StatusAtApproved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_ClaimQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_StatusAtClaimed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_QtyAtClaimed = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApproveQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_QtyAtApproved = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_HistoricalInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_ClaimStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_ClaimValAtEnd = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractLineCreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Claimline_ClaimLineId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApprovedToDate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApprovedToDateQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_WhenComplete = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_TotalActivityCount = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_NewActivityCount = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApproveValAtEnd = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisClaimAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisClaimQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisApproveAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisApproveQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisClaimPct = table.Column<double>(type: "float", nullable: true),
                    Claimline_ThisApprovePct = table.Column<double>(type: "float", nullable: true),
                    Claimline_LockedAmount = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_Heading = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimlineSectionDtoNode", x => new { x.PayappDtoId, x.ClaimlineSectionDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_ClaimlineSectionDtoNode_ClaimlineSectionDto_PayappDtoId_ClaimlineSectionDtoId",
                        columns: x => new { x.PayappDtoId, x.ClaimlineSectionDtoId },
                        principalTable: "ClaimlineSectionDto",
                        principalColumns: new[] { "PayappDtoId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MateriallinesHeadingDto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PayappDtoId = table.Column<double>(type: "float", nullable: false),
                    MateriallinesSectionDtoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line_ref_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriallinesHeadingDto", x => new { x.PayappDtoId, x.MateriallinesSectionDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_MateriallinesHeadingDto_MateriallinesSectionDto_PayappDtoId_MateriallinesSectionDtoId",
                        columns: x => new { x.PayappDtoId, x.MateriallinesSectionDtoId },
                        principalTable: "MateriallinesSectionDto",
                        principalColumns: new[] { "PayappDtoId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClaimlinesLineDto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PayappDtoId = table.Column<double>(type: "float", nullable: false),
                    ClaimlineSectionDtoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimlineSectionDtoNodeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Claimline_Id = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_LineRefCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_Rate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractLineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_RetExclInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_TaxExemptInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Claimline_LockedInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_ExternalIntegrationKeyPrimary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_Qty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_LumpSumInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_UnitType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_VariableBudgetInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_DiscountInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Claimline_ClaimantProjectedRate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimantProjectedQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_TaxRate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractLineId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ClaimPct = table.Column<double>(type: "float", nullable: true),
                    Claimline_ApproveAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApprovePct = table.Column<double>(type: "float", nullable: true),
                    Claimline_RateAtClaimed = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_RateAtApproved = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_StatusAtApproved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_ClaimQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_StatusAtClaimed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_QtyAtClaimed = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApproveQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_QtyAtApproved = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_HistoricalInd = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_ClaimStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claimline_ClaimValAtEnd = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ContractLineCreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Claimline_ClaimLineId = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApprovedToDate = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApprovedToDateQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_WhenComplete = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_TotalActivityCount = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_NewActivityCount = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ApproveValAtEnd = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisClaimAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisClaimQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisApproveAmt = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisApproveQty = table.Column<long>(type: "bigint", nullable: true),
                    Claimline_ThisClaimPct = table.Column<double>(type: "float", nullable: true),
                    Claimline_ThisApprovePct = table.Column<double>(type: "float", nullable: true),
                    Claimline_LockedAmount = table.Column<bool>(type: "bit", nullable: true),
                    Claimline_Heading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimlinesLineDto", x => new { x.PayappDtoId, x.ClaimlineSectionDtoId, x.ClaimlineSectionDtoNodeId, x.Id });
                    table.ForeignKey(
                        name: "FK_ClaimlinesLineDto_ClaimlineSectionDtoNode_PayappDtoId_ClaimlineSectionDtoId_ClaimlineSectionDtoNodeId",
                        columns: x => new { x.PayappDtoId, x.ClaimlineSectionDtoId, x.ClaimlineSectionDtoNodeId },
                        principalTable: "ClaimlineSectionDtoNode",
                        principalColumns: new[] { "PayappDtoId", "ClaimlineSectionDtoId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MateriallinesLineDto",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    PayappDtoId = table.Column<double>(type: "float", nullable: false),
                    MateriallinesSectionDtoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MateriallinesHeadingDtoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_by_organisation = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line_ref_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty_at_claimed = table.Column<double>(type: "float", nullable: false),
                    Rate_at_claimed = table.Column<double>(type: "float", nullable: false),
                    Qty_at_approved = table.Column<double>(type: "float", nullable: false),
                    Rate_at_approved = table.Column<double>(type: "float", nullable: false),
                    Prev_approved = table.Column<double>(type: "float", nullable: false),
                    Modification_reason = table.Column<double>(type: "float", nullable: false),
                    Modification_reason_comment = table.Column<double>(type: "float", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deleted_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total_activity_count = table.Column<double>(type: "float", nullable: false),
                    New_activity_count = table.Column<double>(type: "float", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriallinesLineDto", x => new { x.PayappDtoId, x.MateriallinesSectionDtoId, x.MateriallinesHeadingDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_MateriallinesLineDto_MateriallinesHeadingDto_PayappDtoId_MateriallinesSectionDtoId_MateriallinesHeadingDtoId",
                        columns: x => new { x.PayappDtoId, x.MateriallinesSectionDtoId, x.MateriallinesHeadingDtoId },
                        principalTable: "MateriallinesHeadingDto",
                        principalColumns: new[] { "PayappDtoId", "MateriallinesSectionDtoId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClaimlinesLineDto");

            migrationBuilder.DropTable(
                name: "MateriallinesLineDto");

            migrationBuilder.DropTable(
                name: "PayappActionHistoryDto");

            migrationBuilder.DropTable(
                name: "ClaimlineSectionDtoNode");

            migrationBuilder.DropTable(
                name: "MateriallinesHeadingDto");

            migrationBuilder.DropTable(
                name: "ClaimlineSectionDto");

            migrationBuilder.DropTable(
                name: "MateriallinesSectionDto");

            migrationBuilder.DropTable(
                name: "PayappDto");
        }
    }
}
