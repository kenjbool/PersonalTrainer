using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PersonalTrainer.Models;

namespace PersonalTrainer.Controllers
{
    public class WorkoutController : Controller
    {
        SqlConnection myConnection = new SqlConnection(@"user id=AppLogin; password=C0smopolitan1; server=LT035368\PT; trusted_Connection=yes; database=PersonalTrainer; connection timeout=30");

        public ActionResult Index()
        {
          try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
               
            }

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

                    if (parq.AnswerOne == true)
                    {
                        parq.AddInfoOne = workout.AddInfoOne;
                    }
                    else
                    {
                        workout.AddInfoOne = "lalalalalalalala";
                    }

                    using (myConnection)
                    {
                        string parqCommand = "INSERT INTO ParqAnswers(AnswerOne, AnswerTwo, AnswerThree, AnswerFour, AnswerFive, AnswerSix, AnswerSeven, AnswerEight, AnswerNine, AnswerTen, AnswerEleven, AnswerTwelve, AnswerThirteen, AnswerFourteen, AnswerFifteen, AnswerSixteen, AddInfoOne, AddInfoTwo, AddInfoThree, AddInfoFour, AddInfoFive, AddInfoSix, AddInfoSeven, AddInfoEight, AddInfoNine, AddInfoTen, AddInfoEleven, AddInfoTwelve, AddInfoThirteen, AddInfoFourteen, AddInfoFifteen, AddInfoSixteen, AdditionalInfo) " +
                                             "VALUES(@parq.AnswerOne, @parq.AnswerTwo, @parq.AnswerThree, @parq.AnswerFour, @parq.AnswerFive, @parq.AnswerSix, @parq.AnswerSeven, @parq.AnswerEight, @parq.AnswerNine, @parq.AnswerTen, @parq.AnswerEleven, @parq.AnswerTwelve, @parq.AnswerThirteen, @parq.AnswerFourteen, @parq.AnswerFifteen, @parq.AnswerSixteen, @parq.AddInfoOne, @parq.AddInfoTwo, @parq.AddInfoThree, @parq.AddInfoFour, @parq.AddInfoFive, @parq.AddInfoSix, @parq.AddInfoSeven, @parq.AddInfoEight, @parq.AddInfoNine, @parq.AddInfoTen, @parq.AddInfoEleven, @parq.AddInfoTwelve, @parq.AddInfoThirteen, @parq.AddInfoFourteen, @parq.AddInfoFifteen, @parq.AddInfoSixteen, @parq.AdditionalInfo)";

                        using (SqlCommand queryParqCommand = new SqlCommand(parqCommand))
                        {
                            if (myConnection.State == ConnectionState.Open)
                            {
                                queryParqCommand.Connection = myConnection;
                            }
                            else
                            {
                                myConnection.Open();
                                queryParqCommand.Connection = myConnection;
                            }
                            myConnection.Close();
                        }
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
        public ActionResult Client(Workout workout)
        {
            ModelState.Clear();
            return View(workout);
        }

        //
        // POST: /Workout/Client
        [HttpPost]
        public ActionResult Client(Workout client, Parq parq)
        {
            //if (!ModelState.IsValid)
            //{
            //    ViewBag.Message = "Please complete all fields before continuing";
            //    return View();
            //}
            var today = DateTime.Today;
            var clientInfo = client;
            client.FName = clientInfo.FName;
            client.LName = clientInfo.LName;
            clientInfo.Gender = client.Gender == "Male" ? "Male" : "Female";

            var dateOfBirthToString = client.DateOfBirth.ToString(CultureInfo.InvariantCulture);

            var day = string.Format(dateOfBirthToString).Substring(0, 2);
            var month = string.Format(dateOfBirthToString).Substring(3, 2);
            var year = string.Format(dateOfBirthToString).Substring(5, 4);

            var dateOfBirthFormat = string.Format(day + "/" + month + "/" + year);

            clientInfo.DateOfBirth.ToString(dateOfBirthFormat);

            clientInfo.Age = (today.Year - client.DateOfBirth.Year);
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
            return View(clientInfo);
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
            var testModel = new FitnessTest();

            if (testModel.ORM != 0)
            {
                testModel.TRM = testModel.ORM * 0.95f;
            }

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