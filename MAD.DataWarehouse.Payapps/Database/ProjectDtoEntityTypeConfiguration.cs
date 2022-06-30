using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using Payapps.Api;
using System.Collections.Generic;

namespace MAD.DataWarehouse.Payapps.Database
{
    internal class ProjectDtoEntityTypeConfiguration : IEntityTypeConfiguration<ProjectDto>
    {
        public void Configure(EntityTypeBuilder<ProjectDto> builder)
        {
            builder.Property(y => y.AdditionalProperties).HasJsonConversion();

            builder.OwnsOne(y => y.Address, cfg =>
            {
                cfg.WithOwner().HasForeignKey("ProjectDtoId");

                cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
            });

            builder.OwnsOne(y => y.Permissions, cfg =>
            {
                cfg.WithOwner().HasForeignKey("ProjectDtoId");

                cfg.Property(y => y.AdditionalProperties).HasJsonConversion();

                cfg.OwnsMany(y => y.Project_categories, cfg =>
                {
                    cfg.WithOwner().HasForeignKey("ProjectDtoId");

                    cfg.Property(y => y.AdditionalProperties).HasJsonConversion();

                    cfg.OwnsMany(y => y.Users, cfg =>
                    {
                        cfg.WithOwner().HasForeignKey("ProjectDtoId", "ProjectCategoryDtoId");

                        cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                        cfg.Property(y => y.Permissions).HasJsonConversion();
                    });
                });
            });

            builder.OwnsOne(y => y.Claim_cycle, cfg =>
            {
                cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                cfg.Property(y => y.Reminder_schedule).HasEnumToStringConversion();
                cfg.Property(y => y.Fortnightly_start_date).HasJsonConversion();

                cfg.OwnsMany(y => y.Claim_schedules, cfg =>
                {
                    cfg.WithOwner().HasForeignKey("ProjectDtoId");

                    cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                });
            });
        }
    }
}
