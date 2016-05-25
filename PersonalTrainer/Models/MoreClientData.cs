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
        
        public string BodyComposition { get; set; }


        // already collected in workout.cs
        public double BodyWeight { get; set; }

        public double BodyFatPercentage { get; set; }


        // already collected in workout.cs
        public double Height { get; set; }

        public int Waist { get; set; }

        public int Hips { get; set; }

        public int Chest { get; set; }

        public int Arm { get; set; }

        public int Thigh { get; set; }

        public int BloodPressureSystolic { get; set; }

        public int BloodPressureDiastolic { get; set; }

        public decimal RestingHeartRate { get; set; }

        public decimal HeartRateZone1 { get; set; }

        public decimal HeartRateZone2 { get; set; }

        public decimal HeartRateZone3 { get; set; }

    }
}