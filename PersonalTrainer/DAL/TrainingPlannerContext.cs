using PersonalTrainer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PersonalTrainer.DAL
{
    public class TrainingPlannerContext : DbContext
    {
        public TrainingPlannerContext() : base("TrainingPlannerContext")
        {
        }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<FitnessTest> FitnessTests { get; set; }
        public DbSet<Routine> Routines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}