using Microsoft.EntityFrameworkCore;
using OsRs.Tools.WebApi.Models;

namespace OsRs.Tools.WebApi.Context
{
  public class ExchangeContext : DbContext
  {
    public ExchangeContext(DbContextOptions<ExchangeContext> options)
      : base(options)
    {
    }

    public DbSet<ExchangeItem> ExchangeItems { get; set; }
  }
}
