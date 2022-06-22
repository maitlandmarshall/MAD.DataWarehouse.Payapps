using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAD.DataWarehouse.Payapps.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectDto",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    Address_Address_line_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Address_line_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permissions_AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claim_cycle_Fortnightly_start_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Claim_cycle_Reminder_days_pre_due_date = table.Column<double>(type: "float", nullable: false),
                    Claim_cycle_Period_end_from_due_date = table.Column<double>(type: "float", nullable: false),
                    Claim_cycle_Reminder_schedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Claim_cycle_Reminder_day_of_month = table.Column<double>(type: "float", nullable: false),
                    Claim_cycle_Period_end_day_of_month = table.Column<double>(type: "float", nullable: false),
                    Claim_cycle_Claim_due_day_of_month = table.Column<double>(type: "float", nullable: false),
                    Claim_cycle_AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tax_rate = table.Column<double>(type: "float", nullable: false),
                    Project_ref = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commencement_date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Completion_date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    External_integration_key_primary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    External_integration_key_secondary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enforce_approval_seq_ind = table.Column<bool>(type: "bit", nullable: false),
                    Authority_limits_enabled_ind = table.Column<bool>(type: "bit", nullable: false),
                    Multiapproval_ind = table.Column<bool>(type: "bit", nullable: false),
                    Deleted_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectCategoryDto",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    ProjectDtoId = table.Column<double>(type: "float", nullable: false),
                    Project_category_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contract_count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCategoryDto", x => new { x.ProjectDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_ProjectCategoryDto_ProjectDto_ProjectDtoId",
                        column: x => x.ProjectDtoId,
                        principalTable: "ProjectDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectClaimScheduleDto",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    ProjectDtoId = table.Column<double>(type: "float", nullable: false),
                    Due_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reminder_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectClaimScheduleDto", x => new { x.ProjectDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_ProjectClaimScheduleDto_ProjectDto_ProjectDtoId",
                        column: x => x.ProjectDtoId,
                        principalTable: "ProjectDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUsersDto",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    ProjectDtoId = table.Column<double>(type: "float", nullable: false),
                    ProjectCategoryDtoId = table.Column<double>(type: "float", nullable: false),
                    Permissions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sequence = table.Column<double>(type: "float", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUsersDto", x => new { x.ProjectDtoId, x.ProjectCategoryDtoId, x.Id });
                    table.ForeignKey(
                        name: "FK_ProjectUsersDto_ProjectCategoryDto_ProjectDtoId_ProjectCategoryDtoId",
                        columns: x => new { x.ProjectDtoId, x.ProjectCategoryDtoId },
                        principalTable: "ProjectCategoryDto",
                        principalColumns: new[] { "ProjectDtoId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectClaimScheduleDto");

            migrationBuilder.DropTable(
                name: "ProjectUsersDto");

            migrationBuilder.DropTable(
                name: "ProjectCategoryDto");

            migrationBuilder.DropTable(
                name: "ProjectDto");
        }
    }
}
