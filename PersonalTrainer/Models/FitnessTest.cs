using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    public class FitnessTest
    {
        [Display(Name = "Reps:")]
        public int Reps { get; set; }

        [Display(Name = "Weight(kg):")]
        public int WeightLifted { get; set; }

        public double ORM { get; set; }

        public List<string> WorkoutNameList = new List<string>()
        {
            "Squat",
            "Deadlift",
            "Bench",
            "Overhead Press",
        }; 

        public string WorkoutName { get; set; }

        public string Comments { get; set; }

        [Display(Name = "Three Rep Max:")]
        public double TRM { get; set; }


    }
}