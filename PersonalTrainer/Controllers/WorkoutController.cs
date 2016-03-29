using System;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PersonalTrainer.Models;

namespace PersonalTrainer.Controllers
{
    public class WorkoutController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Workout/Parq
        [HttpGet]
        public ActionResult ParQ()
        {
            ModelState.Clear();
            return View();
        }

        //
        // POST: /Workout/Parq
        [HttpPost]
        public ActionResult ParQ(Parq parq)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(parq.Name) && !string.IsNullOrEmpty(parq.Email))
                {
                    var workout = new Workout();

                    if (!string.IsNullOrEmpty(parq.Name))
                    {
                        string fullName = parq.Name;
                        char splitChar = ' ';
                        string[] afterSplit = fullName.Split(splitChar);
                        workout.FName = afterSplit[0];
                        workout.LName = afterSplit[1];
                    }

                    if (parq.answerOne == true)
                    {
                        parq.AddInfoOne = workout.AddInfoOne;
                    }
                    else
                    {
                        workout.AddInfoOne = "lalalalalalalala";
                    }

                    return RedirectToAction("Client", workout);

                }
            }
            if (string.IsNullOrEmpty(parq.Email) || string.IsNullOrEmpty(parq.Name))
            {
                ViewBag.Message =
                    "Please make sure you have entered your full name and a correct and current email address. " +
                    "This is so we can send you a documented copy of the form for you to keep";
            }
            if (parq.ParqAgreement != true)
            {
                ViewBag.MessageAgreement =
                    "Please tick the checkbox at the bottom of the page in order to continue";
            }
            return View();
        }

        //
        // GET: /Workout/Client
        [HttpGet]
        public ViewResult Client(Workout workout)
        {
            return View(workout);
        }

        //
        // POST: /Workout/Client
        [HttpPost]
        public ActionResult Client(Workout client, Parq parq)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Please complete all fields before continuing";
                return View();
            }
            var today = DateTime.Today;
            var clientInfo = client;
            client.FName = clientInfo.FName;
            client.LName = clientInfo.LName;
            if (client.Gender == "Male")
            {
                clientInfo.Gender = "Male";
            }
            else
            {
                clientInfo.Gender = "Female";
            }

            ////var dateOfBirthToString = client.DateOfBirth.ToString(CultureInfo.InvariantCulture);

            ////var day = string.Format(dateOfBirthToString).Substring(0, 2);
            ////var month = string.Format(dateOfBirthToString).Substring(3, 2);
            ////var year = string.Format(dateOfBirthToString).Substring(5, 4);

            ////var dateOfBirthFormat = string.Format(day + "/" + month + "/" + year);

            client.DateOfBirth = clientInfo.DateOfBirth;

            if (client.DateOfBirth != null)
            {
                clientInfo.Age = (today.Year - client.DateOfBirth.Year);
            }
            client.Height = clientInfo.Height;
            client.Weight = clientInfo.Weight;
            client.BodyMass = clientInfo.BodyMass;
            client.Goal = clientInfo.Goal;
            client.AddInfo = clientInfo.AddInfo;

            return RedirectToAction("CheckDetails", clientInfo);

        }

        //
        // GET: /Workout/CheckDetails
        [HttpGet]
        public ActionResult CheckDetails(Workout clientInfo)
        {

            return View("CheckDetails", clientInfo);
        }

        // POST: /Workout/CheckDetails
        [HttpPost]
        public ActionResult CheckDetails(FitnessTest test)
        {
            return View("FitnessTest");
        }

        // GET: /Workout/FitnessTest
        [HttpGet]
        public ActionResult FitnessTest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FitnessTest(FitnessTest test)
        {
            test.ORM = OrmCalc(test);

            return View("Create");

        }

        public ActionResult Create(WorkoutController workout)
        {
            return View(workout);
        }

        public double OrmCalc(FitnessTest test)
        {
            var repsX = (test.Reps * 0.33) + 1;
            var weightX = repsX * test.WeightLifted;

            test.ORM = weightX;

            return test.ORM;
        }

    }
}