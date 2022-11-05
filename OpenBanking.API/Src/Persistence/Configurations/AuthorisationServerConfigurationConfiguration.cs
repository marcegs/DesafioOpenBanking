using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class AuthorisationServerConfiguration : IEntityTypeConfiguration<AuthorisationServer>
{
    public void Configure(EntityTypeBuilder<AuthorisationServer> builder)
    {
        builder.HasKey(a => a.AuthorisationServerId);

        builder.HasMany(a => a.ApiResources).WithOne(b => b.AuthorisationServer);
        builder.HasOne(a => a.Participant).WithMany(a => a.AuthorisationServers).HasForeignKey(a => a.ParticipantId);

        // builder.Ignore(a => a.AuthorisationServerCertifications);
        builder.Ignore(a => a.AutoRegistrationNotificationWebhook);
        builder.Ignore(a => a.NotificationWebhookAddedDate);
        builder.Ignore(a => a.Issuer);
        builder.Ignore(a => a.ParentAuthorisationServerId);
        builder.Ignore(a => a.DeprecatedDate);
        builder.Ignore(a => a.RetirementDate);
        builder.Ignore(a => a.SupersededByAuthorisationServerId);
    }
}