// <auto-generated />
using System;
using MAD.DataWarehouse.Payapps.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MAD.DataWarehouse.Payapps.Migrations
{
    [DbContext(typeof(PayappsDbContext))]
    [Migration("20220630010455_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Payapps.Api.ProjectDto", b =>
                {
                    b.Property<double>("Id")
                        .HasColumnType("float");

                    b.Property<string>("AdditionalProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Authority_limits_enabled_ind")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("Commencement_date")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("Completion_date")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("Deleted_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Enforce_approval_seq_ind")
                        .HasColumnType("bit");

                    b.Property<string>("External_integration_key_primary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("External_integration_key_secondary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Multiapproval_ind")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project_ref")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tax_rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ProjectDto");
                });

            modelBuilder.Entity("Payapps.Api.ProjectDto", b =>
                {
                    b.OwnsOne("Payapps.Api.ProjectAddressDto", "Address", b1 =>
                        {
                            b1.Property<double>("ProjectDtoId")
                                .HasColumnType("float");

                            b1.Property<string>("AdditionalProperties")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Address_line_1")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Address_line_2")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Postcode")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Province")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProjectDtoId");

                            b1.ToTable("ProjectDto");

                            b1.WithOwner()
                                .HasForeignKey("ProjectDtoId");
                        });

                    b.OwnsOne("Payapps.Api.ProjectClaimCycleDto", "Claim_cycle", b1 =>
                        {
                            b1.Property<double>("ProjectDtoId")
                                .HasColumnType("float");

                            b1.Property<string>("AdditionalProperties")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Claim_due_day_of_month")
                                .HasColumnType("float");

                            b1.Property<string>("Fortnightly_start_date")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Period_end_day_of_month")
                                .HasColumnType("float");

                            b1.Property<double?>("Period_end_from_due_date")
                                .HasColumnType("float");

                            b1.Property<double>("Reminder_day_of_month")
                                .HasColumnType("float");

                            b1.Property<double?>("Reminder_days_pre_due_date")
                                .HasColumnType("float");

                            b1.Property<string>("Reminder_schedule")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProjectDtoId");

                            b1.ToTable("ProjectDto");

                            b1.WithOwner()
                                .HasForeignKey("ProjectDtoId");

                            b1.OwnsMany("Payapps.Api.ProjectClaimScheduleDto", "Claim_schedules", b2 =>
                                {
                                    b2.Property<double>("ProjectDtoId")
                                        .HasColumnType("float");

                                    b2.Property<double>("Id")
                                        .HasColumnType("float");

                                    b2.Property<string>("AdditionalProperties")
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Due_date")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("End_date")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Reminder_date")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("ProjectDtoId", "Id");

                                    b2.ToTable("ProjectClaimScheduleDto");

                                    b2.WithOwner()
                                        .HasForeignKey("ProjectDtoId");
                                });

                            b1.Navigation("Claim_schedules");
                        });

                    b.OwnsOne("Payapps.Api.ProjectPermissionsDto", "Permissions", b1 =>
                        {
                            b1.Property<double>("ProjectDtoId")
                                .HasColumnType("float");

                            b1.Property<string>("AdditionalProperties")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProjectDtoId");

                            b1.ToTable("ProjectDto");

                            b1.WithOwner()
                                .HasForeignKey("ProjectDtoId");

                            b1.OwnsMany("Payapps.Api.ProjectCategoryDto", "Project_categories", b2 =>
                                {
                                    b2.Property<double>("ProjectDtoId")
                                        .HasColumnType("float");

                                    b2.Property<double?>("Id")
                                        .HasColumnType("float");

                                    b2.Property<string>("AdditionalProperties")
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Contract_count")
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Project_category_name")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("ProjectDtoId", "Id");

                                    b2.ToTable("ProjectCategoryDto");

                                    b2.WithOwner()
                                        .HasForeignKey("ProjectDtoId");

                                    b2.OwnsMany("Payapps.Api.ProjectUsersDto", "Users", b3 =>
                                        {
                                            b3.Property<double>("ProjectDtoId")
                                                .HasColumnType("float");

                                            b3.Property<double>("ProjectCategoryDtoId")
                                                .HasColumnType("float");

                                            b3.Property<double>("Id")
                                                .HasColumnType("float");

                                            b3.Property<string>("AdditionalProperties")
                                                .HasColumnType("nvarchar(max)");

                                            b3.Property<string>("First_name")
                                                .HasColumnType("nvarchar(max)");

                                            b3.Property<string>("Last_name")
                                                .HasColumnType("nvarchar(max)");

                                            b3.Property<string>("Permissions")
                                                .IsRequired()
                                                .HasColumnType("nvarchar(max)");

                                            b3.Property<double>("Sequence")
                                                .HasColumnType("float");

                                            b3.HasKey("ProjectDtoId", "ProjectCategoryDtoId", "Id");

                                            b3.ToTable("ProjectUsersDto");

                                            b3.WithOwner()
                                                .HasForeignKey("ProjectDtoId", "ProjectCategoryDtoId");
                                        });

                                    b2.Navigation("Users");
                                });

                            b1.Navigation("Project_categories");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Claim_cycle")
                        .IsRequired();

                    b.Navigation("Permissions")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
