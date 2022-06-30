using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payapps.Api;

namespace MAD.DataWarehouse.Payapps.Database
{
    internal class PayappDtoEntityTypeConfiguration : IEntityTypeConfiguration<PayappDto>
    {
        public void Configure(EntityTypeBuilder<PayappDto> builder)
        {
            builder.HasKey(y => y.Id);

            builder.OwnsMany(y => y.Materialitems, cfg =>
            {
                cfg.Property(y => y.AdditionalProperties).HasJsonConversion();

                cfg.OwnsMany(y => y.Nodes, cfg =>
                {
                    cfg.WithOwner().HasForeignKey("PayappDtoId", "MateriallinesSectionDtoId");

                    cfg.Property(y => y.AdditionalProperties).HasJsonConversion();

                    cfg.OwnsMany(y => y.Nodes, cfg =>
                    {
                        cfg.WithOwner().HasForeignKey("PayappDtoId", "MateriallinesSectionDtoId", "MateriallinesHeadingDtoId");
                        cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                    });
                });
            });

            builder.OwnsMany(y => y.Lineitems, cfg =>
            {
                cfg.OwnsMany(y => y.Nodes, cfg =>
                {
                    cfg.ToTable("ClaimlineSectionDtoNode");

                    cfg.WithOwner().HasForeignKey("PayappDtoId", "ClaimlineSectionDtoId");
                    cfg.Property(y => y.AdditionalProperties).HasJsonConversion();

                    cfg.OwnsOne(y => y.Claimline);
                    cfg.OwnsMany(y => y.Nodes, cfg =>
                    {
                        cfg.WithOwner().HasForeignKey("PayappDtoId", "ClaimlineSectionDtoId", "ClaimlineSectionDtoNodeId");

                        cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                        cfg.OwnsOne(y => y.Claimline);
                    });
                });

                cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
            });

            builder.OwnsOne(y => y.Summary, cfg =>
            {
                cfg.OwnsOne(y => y.This_claim, cfg =>
                {
                    cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                });

                cfg.Property(y => y.AdditionalProperties).HasJsonConversion().IsRequired();
            });

            builder.OwnsOne(y => y.Pln, cfg =>
            {
                cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                cfg.Property(y => y.Adjustments).HasJsonConversion();
            });

            builder.OwnsMany(y => y.Action_history, cfg =>
            {
                cfg.Property(y => y.AdditionalProperties).HasJsonConversion();
                cfg.Property(y => y.Action).HasJsonConversion();
            });

            builder.Property(y => y.Contraitems).HasJsonConversion();
            builder.Property(y => y.Variationitems).HasJsonConversion();

            builder.Property(y => y.My_role).HasConversion<string>();
            builder.Property(y => y.AdditionalProperties).HasJsonConversion();
        }
    }
}
