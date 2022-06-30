using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payapps.Api;

namespace MAD.DataWarehouse.Payapps.Database
{
    internal class PayappsListItemDtoEntityTypeConfiguration : IEntityTypeConfiguration<PayappsListItemDto>
    {
        public void Configure(EntityTypeBuilder<PayappsListItemDto> builder)
        {
            builder.HasKey(y => y.Claim_id);
            builder.Property(y => y.Counterparty_role).HasJsonConversion();
            builder.Property(y => y.AdditionalProperties).HasJsonConversion();
        }
    }
}
