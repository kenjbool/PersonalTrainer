using PersonalTrainer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web.UI;
using PersonalTrainer.ViewModel;

namespace PersonalTrainer.DAL
{
    public class TrainingPlannerContext : DbContext
    {
        public TrainingPlannerContext() : base("TrainingPlannerContext")
        {
        }

        public DbSet<Parq> Parqs { get; set; }
        public DbSet<ClientViewModel> Clients { get; set; }
        public DbSet<FitnessTest> FitnessTests { get; set; }
        public DbSet<Routine> Routines { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<DayWorkout> DayWorkouts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}