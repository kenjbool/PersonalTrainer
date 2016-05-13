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
                new Client { ClientId = 1, FName = "Ken", LName = "Bool", DateOfBirth = DateTime.Parse("13/02/1982"), Weight = 75.20, Height = 170.50, Email = "aaa@aa.com", Gender = "Male", AddressLine1 = "12 The Street", AddressLine2 = "Norwich", Postcode = "NR1 1AA", Phone = "01234567890", Age = 34, BodyMass = "17.5", EmergencyContact = "Mr Sponge", EmergencyContactNumber = "01234567890", GoalId = "Lose weight", AddInfo = "bhjbjhb", SpecifiedGoal = false, GoalSpecificName = null, RegistrationDate = DateTime.Parse("13/05/2016")},
                new Client { ClientId = 1, FName = "Ken", LName = "Bool", DateOfBirth = DateTime.Parse("13/02/1982"), Weight = 75.20, Height = 170.50, Email = "kenjbool@gmail.com", Gender = "Male", AddressLine1 = "26, lenthall Close", AddressLine2 = "Norwich", Postcode = "NR7 0UU", Phone = "01234567890", Age =34, BodyMass = "17.5", EmergencyContact = "Mr Sponge", EmergencyContactNumber = "01234567890", GoalId = "Tone up, slim down", AddInfo = "jnuipnionpiojmniom", SpecifiedGoal = false, GoalSpecificName = null, RegistrationDate = DateTime.Parse("13/05/2016")}
            };
            clients.ForEach(w => context.Clients.Add(w));
            context.SaveChanges();

            var fitnesstests = new List<FitnessTest>
            {
                new FitnessTest {ClientId = 1, ExerciseName = "Squat", WeightLifted = 60, Reps = 10, ORM = 90.45, TRM = 86.45, Comments = "fatigued"},
                new FitnessTest {ClientId = 1, ExerciseName = "Pull ups", WeightLifted = 20, Reps = 10, ORM = 33.25, TRM = 26.45, Comments = "strong back"},
                new FitnessTest {ClientId = 2, ExerciseName = "Squat", WeightLifted = 60, Reps = 10, ORM = 90.45, TRM = 86.45, Comments = "fatigued"},
                new FitnessTest {ClientId = 2, ExerciseName = "Pull ups", WeightLifted = 20, Reps = 10, ORM = 33.25, TRM = 26.45, Comments = "strong back"},
            };
            fitnesstests.ForEach(f => context.FitnessTests.Add(f));
            context.SaveChanges();

            var routines = new List<Routine>
            {
                new Routine {ClientId = 1, RoutineId = 1}
            };
            routines.ForEach(r => context.Routines.Add(r));
            context.SaveChanges();

            var exercises = new List<Exercise>
            {
                new Exercise {ClientId = 1, Day = "Monday", RoutineId = 1, }
            };
            exercises.ForEach(e => context.Exercises.Add(e));
        }
    }
}