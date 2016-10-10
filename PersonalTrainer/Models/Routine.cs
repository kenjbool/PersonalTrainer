using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class Routine
    {
        public string ClientId { get; set; }

        [Key]
        public int RoutineId { get; set; }

        public ICollection<Exercise> Exercises { get; set; }
    }
}