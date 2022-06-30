using Newtonsoft.Json;
using System;

namespace Payapps.Api
{
    public class Claimline
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("contract_id")]
        public long? ContractId { get; set; }

        [JsonProperty("line_ref_code")]
        public string LineRefCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rate")]
        public long? Rate { get; set; }

        [JsonProperty("contract_line_type")]
        public string ContractLineType { get; set; }

        [JsonProperty("ret_excl_ind")]
        public bool? RetExclInd { get; set; }

        [JsonProperty("tax_exempt_ind")]
        public bool? TaxExemptInd { get; set; }

        [JsonProperty("approval_status")]
        public string ApprovalStatus { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("locked_ind")]
        public bool? LockedInd { get; set; }

        [JsonProperty("external_integration_key_primary")]
        public string ExternalIntegrationKeyPrimary { get; set; }

        [JsonProperty("qty")]
        public long? Qty { get; set; }

        [JsonProperty("lump_sum_ind")]
        public bool? LumpSumInd { get; set; }

        [JsonProperty("unit_type")]
        public string UnitType { get; set; }

        [JsonProperty("variable_budget_ind")]
        public bool? VariableBudgetInd { get; set; }

        [JsonProperty("discount_ind")]
        public bool? DiscountInd { get; set; }

        [JsonProperty("uid")]
        public Guid? Uid { get; set; }

        [JsonProperty("claimant_projected_rate")]
        public long? ClaimantProjectedRate { get; set; }

        [JsonProperty("claimant_projected_qty")]
        public long? ClaimantProjectedQty { get; set; }

        [JsonProperty("tax_rate")]
        public long? TaxRate { get; set; }

        [JsonProperty("claim_id")]
        public long? ClaimId { get; set; }

        [JsonProperty("contract_line_id")]
        public long? ContractLineId { get; set; }

        [JsonProperty("claim_amt")]
        public long? ClaimAmt { get; set; }

        [JsonProperty("claim_pct")]
        public double? ClaimPct { get; set; }

        [JsonProperty("approve_amt")]
        public long? ApproveAmt { get; set; }

        [JsonProperty("approve_pct")]
        public double? ApprovePct { get; set; }

        [JsonProperty("rate_at_claimed")]
        public long? RateAtClaimed { get; set; }

        [JsonProperty("rate_at_approved")]
        public long? RateAtApproved { get; set; }

        [JsonProperty("status_at_approved")]
        public string StatusAtApproved { get; set; }

        [JsonProperty("claim_qty")]
        public long? ClaimQty { get; set; }

        [JsonProperty("status_at_claimed")]
        public string StatusAtClaimed { get; set; }

        [JsonProperty("qty_at_claimed")]
        public long? QtyAtClaimed { get; set; }

        [JsonProperty("approve_qty")]
        public long? ApproveQty { get; set; }

        [JsonProperty("qty_at_approved")]
        public long? QtyAtApproved { get; set; }

        [JsonProperty("historical_ind")]
        public bool? HistoricalInd { get; set; }

        [JsonProperty("claim_status")]
        public string ClaimStatus { get; set; }

        [JsonProperty("claim_val_at_end")]
        public long? ClaimValAtEnd { get; set; }

        [JsonProperty("contract_line_created_at")]
        public DateTimeOffset? ContractLineCreatedAt { get; set; }

        [JsonProperty("claim_line_id")]
        public long? ClaimLineId { get; set; }

        [JsonProperty("approved_to_date")]
        public long? ApprovedToDate { get; set; }

        [JsonProperty("approved_to_date_qty")]
        public long? ApprovedToDateQty { get; set; }

        [JsonProperty("when_complete")]
        public long? WhenComplete { get; set; }

        [JsonProperty("total_activity_count")]
        public long? TotalActivityCount { get; set; }

        [JsonProperty("new_activity_count")]
        public long? NewActivityCount { get; set; }

        [JsonProperty("approve_val_at_end")]
        public long? ApproveValAtEnd { get; set; }

        [JsonProperty("this_claim_amt")]
        public long? ThisClaimAmt { get; set; }

        [JsonProperty("this_claim_qty")]
        public long? ThisClaimQty { get; set; }

        [JsonProperty("this_approve_amt")]
        public long? ThisApproveAmt { get; set; }

        [JsonProperty("this_approve_qty")]
        public long? ThisApproveQty { get; set; }

        [JsonProperty("this_claim_pct")]
        public double? ThisClaimPct { get; set; }

        [JsonProperty("this_approve_pct")]
        public double? ThisApprovePct { get; set; }

        [JsonProperty("locked_amount")]
        public bool? LockedAmount { get; set; }

        [JsonProperty("heading")]
        public string Heading { get; set; }
    }
}
