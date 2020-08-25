namespace SmartTest.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using SmartTest.DataAccess.Models;
    public class SmartTestContext : DbContext
    {
        public SmartTestContext(DbContextOptions<SmartTestContext> options) : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public class SmartTestContextFactory : IDesignTimeDbContextFactory<SmartTestContext>
        {
            public SmartTestContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<SmartTestContext>();
                optionsBuilder.UseSqlServer("Server=DESKTOP-I3JIDBL\\MSSQLSERVER1;Database=smartTestDb;Trusted_Connection=True;");

                return new SmartTestContext(optionsBuilder.Options);
            }
        }

    }
}
