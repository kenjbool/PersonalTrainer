using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalTrainer.ViewModel
{
    public class AddClientInfoViewModel
    {
        [Required(ErrorMessage = "Please enter your height in centimeters")]
        [Display(Name = "Height(cm):")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Please enter your weight in kg's")]
        [Display(Name = "Weight(kg):")]
        public decimal Weight { get; set; }

        [Display(Name = "Clients BMI:")]
        public decimal BodyMass { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Additional Info:")]
        public string AddInfo { get; set; }

        [Display(Name = "Body Composition")]
        public string BodyComposition { get; set; }

        [Display(Name = "Body Fat %")]
        public double BodyFatPercentage { get; set; }

        [Display(Name = "Waist")]
        public int Waist { get; set; }

        [Display(Name = "Hips")]
        public int Hips { get; set; }

        [Display(Name = "Chest")]
        public int Chest { get; set; }

        [Display(Name = "Arm")]
        public int Arm { get; set; }

        [Display(Name = "Thigh")]
        public int Thigh { get; set; }

        [Display(Name = "Systolic BP")]
        public int BloodPressureSystolic { get; set; }

        [Display(Name = "Diastolic BP")]
        public int BloodPressureDiastolic { get; set; }

        [Display(Name = "Resting HR")]
        public decimal RestingHeartRate { get; set; }

        [Display(Name = "HR Zone 1")]
        public decimal HeartRateZone1 { get; set; }

        [Display(Name = "HR Zone 2")]
        public decimal HeartRateZone2 { get; set; }

        [Display(Name = "HR Zone 3")]
        public decimal HeartRateZone3 { get; set; }
    }
}