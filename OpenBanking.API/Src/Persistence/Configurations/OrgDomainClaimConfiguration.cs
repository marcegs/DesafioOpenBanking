using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class OrgDomainClaimConfiguration : IEntityTypeConfiguration<OrgDomainClaim>
{
    public void Configure(EntityTypeBuilder<OrgDomainClaim> builder)
    {
        builder.HasKey(a => a.OrgDomainClaimId);

        builder.HasOne(a => a.Participant).WithMany(b => b.OrgDomainClaims).HasForeignKey(a => a.ParticipantId);
    }
}