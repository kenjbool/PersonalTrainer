using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PersonalTrainer.Models;
using PersonalTrainer.ViewModel;

namespace PersonalTrainer.DAL
{
    public class TrainingPlannerInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<TrainingPlannerContext>
    {
        protected override void Seed(TrainingPlannerContext context)
        {
            var clients = new List<ClientViewModel>
            {
                new ClientViewModel() { ClientId = 12134525, FName = "Ken", LName = "Bool", DateOfBirth = DateTime.Parse("13/02/1982"), Email = "aaa@aa.com", Gender = "Male", AddressLine1 = "12 The Street", AddressLine2 = "Norwich", Postcode = "NR1 1AA", Phone = "01234567890", Age = 34, EmergencyContact = "Mr Sponge", EmergencyContactNumber = "01234567890", GoalId = "Lose weight", AddInfo = "bhjbjhb", RegistrationDate = DateTime.Parse("13/05/2016")},
                new ClientViewModel() { ClientId = 25160526, FName = "Test", LName = "Bool", DateOfBirth = DateTime.Parse("13/02/1982"), Email = "kenjbool@gmail.com", Gender = "Male", AddressLine1 = "26, lenthall Close", AddressLine2 = "Norwich", Postcode = "NR7 0UU", Phone = "01234567890", Age =34, EmergencyContact = "Mr Sponge", EmergencyContactNumber = "01234567890", GoalId = "Tone up, slim down", AddInfo = "jnuipnionpiojmniom", RegistrationDate = DateTime.Parse("13/05/2016")}
            };
            clients.ForEach(x => context.Clients.Add(x));
            context.SaveChanges();

            var fitnesstests = new List<FitnessTest>
            {
                new FitnessTest {ClientId = "12134525", ExerciseName = "Squat", WeightLifted = 60, Reps = 10, ORM = 90.45, TRM = 86.45, Comments = "fatigued"},
                new FitnessTest {ClientId = "12134525", ExerciseName = "Pull ups", WeightLifted = 20, Reps = 10, ORM = 33.25, TRM = 26.45, Comments = "strong back"},
                new FitnessTest {ClientId = "25160526", ExerciseName = "Squat", WeightLifted = 60, Reps = 10, ORM = 90.45, TRM = 86.45, Comments = "fatigued"},
                new FitnessTest {ClientId = "25160526", ExerciseName = "Pull ups", WeightLifted = 20, Reps = 10, ORM = 33.25, TRM = 26.45, Comments = "strong back"},
            };
            fitnesstests.ForEach(f => context.FitnessTests.Add(f));
            context.SaveChanges();

            var routines = new List<Routine>
            {
                new Routine {ClientId = "12134525", RoutineId = 1}
            };
            routines.ForEach(r => context.Routines.Add(r));
            context.SaveChanges();

            var exercises = new List<Exercise>
            {
                new Exercise {ClientId = "12134525", Day = "Monday", RoutineId = 1, }
            };
            exercises.ForEach(e => context.Exercises.Add(e));
        }
    }
}