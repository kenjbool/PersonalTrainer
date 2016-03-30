using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Newtonsoft.Json.Serialization;

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

        [Required(ErrorMessage = "Please enter a valid postcode")]
        [Display (Name="Post code")]
        // [RegularExpression("^ (([gG][iI][rR] {0,}0[aA]{2})|((([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y]?[0 - 9][0 - 9]?)|(([a-pr-uwyzA-PR-UWYZ][0-9][a-hjkstuwA-HJKSTUW])|([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y][0-9][abehmnprv-yABEHMNPRV-Y]))) {0,}[0-9][abd-hjlnp-uw-zABD-HJLNP-UW-Z]{2}))$]", ErrorMessage = "Please enter a valid postcode" )]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Please enter house name/number")]
        [Display(Name="Please select your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Display(Name = "Age:")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        [Display(Name = "Gender:")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your Date of Birth")]
        [Display(Name = "Date Of Birth:")]
        [RegularExpression("/d{2}[/]/d{2}[/]/d{4}", ErrorMessage="Please enter a valid date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid Phone number")]
        [RegularExpression("\b{5}[ ]{6}\b", ErrorMessage="Please enter a valid phone number in the format \"XXXXX XXXXXX\"")]
        [Display(Name = "Phone Number:")]
        public string Phone { get; set; }

        [Display(Name = "Emergency Contact Number")]
        public string EmergencyContact { get; set; }

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

        public string AddInfoOne { get; set; }
        public string AddInfoTwo { get; set; }
        public string AddInfoThree { get; set; }
        public string AddInfoFour { get; set; }
        public string AddInfoFive { get; set; }
        public string AddInfoSix { get; set; }
        public string AddInfoSeven { get; set; }
        public string AddInfoEight { get; set; }
        public string AddInfoNine { get; set; }
        public string AddInfoTen { get; set; }
        public string AddInfoEleven { get; set; }
        public string AddInfoTwelve { get; set; }
        public string AddInfoThirteen { get; set; }
        public string AddInfoFourteen { get; set; }
        public string AddInfoFifteen { get; set; }
        public string AddInfoSixteen { get; set; }
    }
}