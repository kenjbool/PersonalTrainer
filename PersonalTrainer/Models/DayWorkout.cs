using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class DayWorkout
    {
        [Key]
        public int ClientId { get; set; }


        public string DayOfWeek { get; set; }
        public string WarmUpName { get; set; }
        public int WarmUpTime { get; set; }
        public string Focus { get; set; }
        public string ExerciseName { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}