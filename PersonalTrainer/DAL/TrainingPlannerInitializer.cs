using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PersonalTrainer.Models;

namespace PersonalTrainer.DAL
{
    public class TrainingPlannerInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<TrainingPlannerContext>
    {
        protected override void Seed(TrainingPlannerContext context)
        {
            var workouts = new List<Workout>
            {
                new Workout {FName = "Ken", LName = "Bool", DateOfBirth = DateTime.Parse("13/02/1982"), Weight =75.2M, Height =170.5M, Email = "kenjbool@gmail.com", Gender = "Male", Address = "26, lenthall Close", Postcode = "NR7 0UU", Phone = "01234567890", Age =34, BodyMass = "17.5", EmergencyContact = "01234567890", Goal = "Tone up, slim down"},
                new Workout {FName = "Jon", LName = "son", DateOfBirth = DateTime.Parse("13/02/1981"), Weight =75.2M, Height =170.5M, Email = "kenjbool@gmail.com", Gender = "Male", Address = "26, lenthall Close", Postcode = "NR3 2DU", Phone = "01234567890", Age =35, BodyMass = "17.5", EmergencyContact = "01234567890", Goal = "Tone up, slim down"},
                new Workout {FName = "Bob", LName = "Bob", DateOfBirth = DateTime.Parse("13/02/1975"), Weight =75.2M, Height =170.5M, Email = "kenjbool@gmail.com", Gender = "Male", Address = "26, lenthall Close", Postcode = "NR1 1AA", Phone = "01234567890", Age =36, BodyMass = "17.5", EmergencyContact = "01234567890", Goal = "Tone up, slim down"},
                new Workout {FName = "Fred", LName = "Rick", DateOfBirth = DateTime.Parse("13/02/1978"), Weight =75.2M, Height =170.5M, Email = "kenjbool@gmail.com", Gender = "Male", Address = "26, lenthall Close", Postcode = "NR2 2AA", Phone = "01234567890", Age =37, BodyMass = "17.5", EmergencyContact = "01234567890", Goal = "Tone up, slim down"} 

            };

            workouts.ForEach(w => context.Workouts.Add(w));
            context.SaveChanges();

            var fitnesstests = new List<FitnessTest>
            {
                new FitnessTest { ORM = 82.5, Reps = 20, WeightLifted = 50},
                new FitnessTest { ORM = 82.5, Reps = 20, WeightLifted = 50},
                new FitnessTest { ORM = 82.5, Reps = 20, WeightLifted = 50},
                new FitnessTest { ORM = 82.5, Reps = 20, WeightLifted = 50},
                new FitnessTest { ORM = 82.5, Reps = 20, WeightLifted = 50},
                new FitnessTest { ORM = 82.5, Reps = 20, WeightLifted = 50}
            };

            fitnesstests.ForEach(f => context.FitnessTests.Add(f));
            context.SaveChanges();

            var routines = new List<Routine>
            {
                new Routine {Day="Monday", ExerciseName = "burpees", WorkoutType = "Cardio"},
                new Routine {Day="Monday", ExerciseName = "Bench Press", WorkoutType = "Chest"},
                new Routine {Day="Monday", ExerciseName = "Leg Press", WorkoutType = "Legs"},
                new Routine {Day="Monday", ExerciseName = "Shoulder Press", WorkoutType = "Shoulders"},
                new Routine {Day="Monday", ExerciseName = "Weighted Squats", WorkoutType = "Legs"},
                new Routine {Day="Monday", ExerciseName = "Kettlebell swing", WorkoutType = "Core"},
                new Routine {Day="Monday", ExerciseName = "Pull ups (Close Arm)", WorkoutType = "Back"}
            };

            routines.ForEach(r => context.Routines.Add(r));
            context.SaveChanges();
        }
    }
}