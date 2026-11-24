using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymManagmentSystem.Context
{
    public class GymDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDb; Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region DBSet
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Plain> Plains { get; set; }
        public DbSet<Session> Sessions { get; set; }
        #endregion
    }
}
