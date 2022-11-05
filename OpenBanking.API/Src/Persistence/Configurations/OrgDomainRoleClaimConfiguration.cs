using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class OrgDomainRoleClaimConfiguration : IEntityTypeConfiguration<OrgDomainRoleClaim>
{
    public void Configure(EntityTypeBuilder<OrgDomainRoleClaim> builder)
    {
        builder.HasKey(a => a.OrgDomainRoleClaimId);

        builder.Ignore(a => a.Authorisations);

        builder.HasOne(a => a.Participant).WithMany(b => b.OrgDomainRoleClaims).HasForeignKey(a => a.ParticipantId);
    }
}