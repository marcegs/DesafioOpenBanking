using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class OpenBankingDbContextFactory : DesignTimeDbContextFactoryBase<OpenBankingDbContext>
{
    protected override OpenBankingDbContext CreateNewInstance(DbContextOptions<OpenBankingDbContext> options)
    {
        return new OpenBankingDbContext(options);
    }
}