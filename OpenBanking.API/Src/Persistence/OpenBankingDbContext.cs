using System.Diagnostics.CodeAnalysis;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class OpenBankingDbContext : DbContext, IOpenBankingDbContext
{
    public OpenBankingDbContext([NotNull] DbContextOptions options) : base(options)
    {
    }

    public DbSet<ApiResource> ApiResources { get; set; }
    public DbSet<ApiDiscoveryEndpoint> ApiDiscoveryEndpoints { get; set; }

    public DbSet<AuthorisationServer> AuthorisationServers { get; set; }

    // public DbSet<AuthorisationServerCertification> AuthorisationServerCertifications { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<OrgDomainClaim> OrgDomainClaims { get; set; }
    public DbSet<OrgDomainRoleClaim> OrgDomainRoleClaims { get; set; }

    public new async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await base.SaveChangesAsync(cancellationToken);
    }

    public void CreateDb()
    {
        base.Database.EnsureCreated();
    }

    public void DropDb()
    {
        base.Database.EnsureDeleted();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OpenBankingDbContext).Assembly);
    }
}