using MySql.Data.Entity;
using System.Data.Entity;

namespace PCRM.Database.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PcrmContext : DbContext
    {
        public PcrmContext() : base("mysqlCon")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                        .HasMany<Project>(e => e.Projects)
                        .WithMany(p => p.Employees)
                        .Map(pe =>
                        {
                            pe.MapLeftKey("employee_idfs");
                            pe.MapRightKey("project_idfs");
                            pe.ToTable("projectemployee");
                        });
        }
    }
}
