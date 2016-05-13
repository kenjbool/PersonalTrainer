using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalTrainer.Models
{
    public class Exercise
    {
        public Exercise()
        {
            this.DaysList = new List<string>();
            DaysList.Add("Monday");
            DaysList.Add("Tuesday");
            DaysList.Add("Wednesday");
            DaysList.Add("Thursday");
            DaysList.Add("Friday");
            DaysList.Add("Saturday");
            DaysList.Add("Sunday");
        }

        public int ClientId { get; set; }


        public int RoutineId { get; set; }

        [Key]
        public int ExerciseId { get; set; }

        public int NumberOfDays { get; set; }

        public List<string> DaysList { get; set; }

        public string Day { get; set; }

        public string WorkoutType { get; set; }

        public bool? Cardio { get; set; }

        public string ExerciseName { get; set; }

        public int Set { get; set; }

        public int Reps { get; set; }
    }

}