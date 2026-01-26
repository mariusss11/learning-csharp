using Microsoft.EntityFrameworkCore;

namespace QuizzApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public static AppDbContext CreateDefault()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=ep-lively-forest-agu2lnle-pooler.c-2.eu-central-1.aws.neon.tech;" +
                "Database=neondb;" +
                "Username=neondb_owner;" +
                "Password=npg_o97TEUyJuhHV;" +
                "SSL Mode=VerifyFull;" +
                "Channel Binding=Require;"
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }


}
