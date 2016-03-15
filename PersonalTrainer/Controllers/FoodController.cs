using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalTrainer.Models;

namespace PersonalTrainer.Controllers
{
    public class FoodController : Controller
    {
        //
        // GET: /Food/

        public ActionResult MacroCounter(MacroCounter counter)
        {
            var weightCalc = counter.Weight * 10;
            var heightCalc = counter.Height * 6.25;
            var ageCalc = counter.Age * 5;

            var totalCalc = 0.0;
            if (counter.Gender == male)
            {
                totalCalc = (weightCalc + heightCalc - ageCalc) + 5;
            }
            else
            {
                totalCalc = (weightCalc + heightCalc - ageCalc) - 161;
            }
            

            var activity = counter.ActivityMultiplier;

            switch (counter.ActivityName)
            {
                case "Sedentary (Little or no exercise, desk job)":
                    activity = 1.2;
                    break;
                case "Lightly active (light exercise/sports 1-3 days/week)":
                    activity = 1.4;
                    break;
                case "Moderately Active (moderate exercise/sports 3-5 days/week)":
                    activity = 1.6;
                    break;
                case "Very active= (Hard exercise/sports 6-7 days per/week)":
                    activity = 1.8;
                    break;
                case "Extremely active (Very hard daily exercise/sports & physical job or twice a day training)":
                    activity = 2.0;
                    break;
            }

            var activityCounter = totalCalc * activity;

            return View();
        }

    }
}
