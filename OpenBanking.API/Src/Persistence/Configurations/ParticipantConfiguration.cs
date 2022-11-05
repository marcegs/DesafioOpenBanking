using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
{
    public void Configure(EntityTypeBuilder<Participant> builder)
    {
        builder.HasKey(org => org.ParticipantId);
        builder.Ignore(org => org.Tag);
        builder.Ignore(org => org.Size);
        builder.HasMany(org => org.AuthorisationServers).WithOne(authServer => authServer.Participant);
        builder.HasMany(org => org.OrgDomainClaims).WithOne(orgDomClaim => orgDomClaim.Participant);
        builder.HasMany(org => org.OrgDomainRoleClaims).WithOne(OrgDomainRoleClaims => OrgDomainRoleClaims.Participant);
    }
}