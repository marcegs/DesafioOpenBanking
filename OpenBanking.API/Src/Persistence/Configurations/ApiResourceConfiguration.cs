using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class ApiResourceConfiguration : IEntityTypeConfiguration<ApiResource>
{
    public void Configure(EntityTypeBuilder<ApiResource> builder)
    {
        builder.HasKey(a => a.ApiResourceId);

        builder.Ignore(a => a.ApiCertificationUri);
        builder.Ignore(a => a.CertificationStatus);
        builder.Ignore(a => a.CertificationStartDate);
        builder.Ignore(a => a.CertificationExpirationDate);

        builder.HasMany(a => a.ApiDiscoveryEndpoints).WithOne(b => b.ApiResource);
        builder.HasOne(a => a.AuthorisationServer).WithMany(b => b.ApiResources)
            .HasForeignKey(a => a.AuthorisationServerId);
    }
}