using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IOpenBankingDbContext
{
    DbSet<ApiResource> ApiResources { get; }
    DbSet<ApiDiscoveryEndpoint> ApiDiscoveryEndpoints { get; }

    DbSet<AuthorisationServer> AuthorisationServers { get; }

    // DbSet<AuthorisationServerCertification> AuthorisationServerCertifications { get; }
    DbSet<Participant> Participants { get; }
    DbSet<OrgDomainClaim> OrgDomainClaims { get; }
    DbSet<OrgDomainRoleClaim> OrgDomainRoleClaims { get; }
    Task SaveChangesAsync(CancellationToken cancellationToken);
    void CreateDb();
    void DropDb();
}