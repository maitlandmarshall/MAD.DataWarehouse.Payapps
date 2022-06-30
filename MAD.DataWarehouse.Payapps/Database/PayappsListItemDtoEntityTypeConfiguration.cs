using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payapps.Api;

namespace MAD.DataWarehouse.Payapps.Database
{
    internal class PayappsListItemDtoEntityTypeConfiguration : IEntityTypeConfiguration<PayappsListItemDto>
    {
        public void Configure(EntityTypeBuilder<PayappsListItemDto> builder)
        {

        }
    }
}
