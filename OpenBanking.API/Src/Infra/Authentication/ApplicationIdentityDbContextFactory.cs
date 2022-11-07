using Microsoft.EntityFrameworkCore;

namespace Infra.Authentication;

public class ApplicationIdentityDbContextFactory : DesignTimeDbContextFactoryBase<ApplicationIdentityDbContext>
{
    protected override ApplicationIdentityDbContext CreateNewInstance(DbContextOptions<ApplicationIdentityDbContext> options)
    {
        return new ApplicationIdentityDbContext(options);
    }
}