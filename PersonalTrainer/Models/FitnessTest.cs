using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace PersonalTrainer.Models
{
    public class FitnessTest
    {
        public FitnessTest()
        {
            string[] workoutList = new string[]
            {
            "Squat",
            "Deadlift",
            "Bench Press",
            "Overhead Press"
            };

            string[] cardioList = new string[]
            {
                "Burpees",

            };
        }

        public int ClientNum { get; set; }

        [Key]
        public string ClientId { get; set; }

        [Display(Name = "Reps:")]
        public int Reps { get; set; }

        [Display(Name = "Weight(kg):")]
        public int WeightLifted { get; set; }

        [Display(Name = "Three Rep Max:")]
        public double ORM { get; set; }

        [Display(Name = "Workout Name:")]
        public List<string> WorkoutNameList { get; set; }

        [Display(Name = "Exercise Name:")]
        public List<string> CardioNameList { get; set; }

        public string ExerciseName { get; set; }

        public TimeSpan Time { get; set; }

        [Display(Name = "Comments:")]
        public string Comments { get; set; }

        [Display(Name = "Three Rep Max:")]
        public double TRM { get; set; }

    }
}