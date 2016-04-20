using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    public class FitnessTest
    {
        public FitnessTest()
        {
            this.WorkoutNameList = new List<string>();
            WorkoutNameList.Add("Squat");
            WorkoutNameList.Add("Deadlift");
            WorkoutNameList.Add("Bench Press");
            WorkoutNameList.Add("Overhead Press");

            this.Comments = string.Empty;
            this.ORM = 0;
            this.Reps = 0;
            this.TRM = 0;
            this.WeightLifted = 0;
        }

        [Display(Name = "Reps:")]
        public int Reps { get; set; }

        [Display(Name = "Weight(kg):")]
        public int WeightLifted { get; set; }

        public double ORM { get; set; }

        [Display(Name = "Workout Name:")]
        public List<string> WorkoutNameList { get; set; }

        [Display(Name = "Comments:")]
        public string Comments { get; set; }

        [Display(Name = "Three Rep Max:")]
        public double TRM { get; set; }
    }
}