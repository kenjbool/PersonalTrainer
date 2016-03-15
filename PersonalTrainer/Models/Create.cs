using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    public class Create
    {
        [Required]
        [Display(Name="Number Of Days a week they aim to train:")]
        public string NumberOfDays { get; set; }

        [Required]
        [Display(Name="Focus Area(s)")]
        public string Focus { get; set; }
    }
}