using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class Plan
    {
        public Plan()
        {
            this.DaysList = new List<string>();
            DaysList.Add("Monday");
            DaysList.Add("Tuesday");
            DaysList.Add("Wednesday");
            DaysList.Add("Thursday");
            DaysList.Add("Friday");
            DaysList.Add("Saturday");
            DaysList.Add("Sunday");

            this.WorkoutType = new List<string>();
            WorkoutType.Add("Cardio");
            WorkoutType.Add("Weight");
        }

        public int NumberOfDays { get; set; }

        public List<string> DaysList { get; set; }

        public bool? IsCardio { get; set; }
        
        public string Day { get; set; }

        public List<string> WorkoutType { get; set; }

        public bool? Cardio { get; set; }

#region exercise

        public string ExerciseName { get; set; }

        public double ExerciseWeight { get; set; }

        public int ExerciseReps { get; set; }

        public int ExerciseSets { get; set; }
#endregion

    }
}