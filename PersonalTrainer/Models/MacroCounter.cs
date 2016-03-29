using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PersonalTrainer.Models
{
    public class MacroCounter
    {
        public double Weight { get; set; }

        public int Height { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string ActivityName { get; set; }

        public double ActivityMultiplier { get; set; }

        public double Protien { get; set; }

        public double Fat { get; set; }

        public double Carbs { get; set; }

        public double Fibre { get; set; }

        public double Water { get; set; }
    }
}