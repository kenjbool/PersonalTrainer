using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    public class Create
    {
        [Required]
        [Display(Name="Number Of Days a week they aim to train:")]
        public string NumberOfDays { get; set; }

        [Display(Name = "Day:")]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        [Display(Name="Focus Area(s):")]
        public string Focus { get; set; }

        [Required]
        [Display(Name = "Exercise Name:")]
        public string ExerciseName { get; set; }

        [Required]
        [Display(Name = "Reps:")]
        public int Reps { get; set; }

        [Required]
        [Display(Name = "Sets:")]
        public int Sets { get; set; }

        [Display(Name = "Rest Required?")]
        public bool RestAfter { get; set; }

        public bool? IsCardio { get; set; }




    }
}