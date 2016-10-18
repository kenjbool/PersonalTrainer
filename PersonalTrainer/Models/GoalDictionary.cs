using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class GoalDictionary
    {
        public static Dictionary<Enum, string> _dictionary = new Dictionary<Enum, string>
        {
            {Goal.ToneUp, "Tone Up"},
            {Goal.LoseWeight, "Shed some pounds"},
            {Goal.BuildMuscle, "I wanna be Arnie!"},
            {Goal.LookGoodNaked, "I wanna look realll good naked!"},
            {Goal.GoalSpecific, "I'm aiming for a specific event"}
        };
    }
}