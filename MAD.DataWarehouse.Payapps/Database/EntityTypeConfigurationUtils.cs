using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System;

namespace MAD.DataWarehouse.Payapps.Database
{
    internal static class EntityTypeConfigurationExtensions
    {
        public static PropertyBuilder<TProperty> HasJsonConversion<TProperty>(this PropertyBuilder<TProperty> propertyBuilder)
        {
            return propertyBuilder.HasConversion(
                y => JsonConvert.SerializeObject(y),
                y => JsonConvert.DeserializeObject<TProperty>(y));
        }

        public static PropertyBuilder<TProperty> HasEnumToStringConversion<TProperty>(this PropertyBuilder<TProperty> propertyBuilder) where TProperty : struct
        {
            return propertyBuilder.HasConversion(new EnumToStringConverter<TProperty>());
        }
    }
}
