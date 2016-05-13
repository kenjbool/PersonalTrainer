using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PersonalTrainer.Models;

namespace PersonalTrainer.DAL
{
    public class TrainingPlannerInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<TrainingPlannerContext>
    {
        protected override void Seed(TrainingPlannerContext context)
        {
            var clients = new List<Client>
            {
            };
            clients.ForEach(w => context.Clients.Add(w));
            context.SaveChanges();

            var fitnesstests = new List<FitnessTest>
            {
            };
            fitnesstests.ForEach(f => context.FitnessTests.Add(f));
            context.SaveChanges();

            var routines = new List<Routine>
            {
            };
            routines.ForEach(r => context.Routines.Add(r));
            context.SaveChanges();

            var exercises = new List<Exercise>
            {
            };
            exercises.ForEach(e => context.Exercises.Add(e));
        }
    }
}