using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class ApiDiscoveryEndpointConfiguration : IEntityTypeConfiguration<ApiDiscoveryEndpoint>
{
    public void Configure(EntityTypeBuilder<ApiDiscoveryEndpoint> builder)
    {
        builder.HasKey(a => a.ApiDiscoveryEndpointId);
        builder.HasOne(a => a.ApiResource).WithMany(b => b.ApiDiscoveryEndpoints).HasForeignKey(a => a.ApiResourceId);
    }
}
