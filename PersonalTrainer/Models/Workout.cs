using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalTrainer.Models
{
    public class Workout
    {
        [Required(ErrorMessage = "Please enter a first name")]
        [Display(Name = "First Name:")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name:")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Display(Name = "Age:")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        [Display(Name = "Gender:")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your Date of Birth")]
        [Display(Name = "Date Of Birth:")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid Phone number")]
        //// [RegularExpression("\b{5}[ ]{6}\b", ErrorMessage="Please enter a valid phone number in the format \"XXXXX XXXXXX\"")]
        [Display(Name = "Phone Number:")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your height in centimeters")]
        [Display(Name = "Height:")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Please enter your weight in kg's")]
        [Display(Name = "Weight:")]
        public decimal Weight { get; set; }

        [Display(Name = "Clients BMI:")]
        public string BodyMass { get; set; }

        [Required(ErrorMessage = "Please select a goal")]
        [Display(Name = "Goal:")]
        public string Goal{ get; set; }

        [Display(Name = "Additional Info:")]
        public string AddInfo { get; set; }

        public int ClientAge() 
        {
            var today = DateTime.Today;
            if (DateOfBirth != null)
            {
                var dateBorn = DateOfBirth;
            }
            var clientAge = (today.Year - DateOfBirth.Year);

            return clientAge;
        }
    }
}