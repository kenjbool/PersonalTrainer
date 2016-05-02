using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class MoreClientData
    {

        public string BodyComposition { get; set; }


        // already collected in workout.cs
        public decimal BodyWeight { get; set; }

        public decimal BodyFatPercentage { get; set; }


        // already collected in workout.cs
        public decimal Height { get; set; }

        public int Waist { get; set; }

        public int Hips { get; set; }

        public int Chest { get; set; }

        public int Arm { get; set; }

        public int Thigh { get; set; }

        public string BloodPressure { get; set; }

        public decimal RestingHeartRate { get; set; }

        public string HeartRateZones { get; set; }

    }
}