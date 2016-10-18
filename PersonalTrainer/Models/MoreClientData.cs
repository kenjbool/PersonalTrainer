using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class MoreClientData
    {
        [Key]
        public int ClientId { get; set; }
        
        [Display(Name = "Body Composition")]
        public string BodyComposition { get; set; }

        [Display(Name ="Body Weight")]
        public decimal BodyWeight { get; set; }

        [Display(Name = "Body Fat %")]
        public double BodyFatPercentage { get; set; }

        [Display(Name = "Height")]
        public decimal Height { get; set; }

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