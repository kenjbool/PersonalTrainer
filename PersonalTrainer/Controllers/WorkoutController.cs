using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.Mvc;
using PersonalTrainer.Models;

namespace PersonalTrainer.Controllers
{
    public class WorkoutController : Controller
    {
        SqlConnection myConnection = new SqlConnection(@"user id=AppLogin; password=C0smopolitan1; server=LT035368\PT; trusted_Connection=yes; database=PersonalTrainer; connection timeout=30");
        // SqlConnection myConnection = new SqlConnection(@"user id=AppLogin; password=C0smopolitan1; server=LT035368\PT; trusted_Connection=yes; database=PersonalTrainer; connection timeout=30");

        public ActionResult Index()
        {
          try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
               throw new Exception("You have not connected to your database, please check the connection and try again", e);
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
        [ValidateAntiForgeryToken]
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
                        string parqCommand = string.Format("INSERT INTO ParqAnswers(AnswerOne, AnswerTwo, AnswerThree, AnswerFour, AnswerFive, AnswerSix, AnswerSeven, AnswerEight, AnswerNine, AnswerTen, AnswerEleven, AnswerTwelve, AnswerThirteen, AnswerFourteen, AnswerFifteen, AnswerSixteen," +
                                                           " AddInfoOne, AddInfoTwo, AddInfoThree, AddInfoFour, AddInfoFive, AddInfoSix, AddInfoSeven, AddInfoEight, AddInfoNine, AddInfoTen, AddInfoEleven, AddInfoTwelve, AddInfoThirteen, AddInfoFourteen, AddInfoFifteen, AddInfoSixteen)" +
                                             "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}'", 
                                             parq.AnswerOne, parq.AnswerTwo, parq.AnswerThree, parq.AnswerFour, parq.AnswerFive, parq.AnswerSix, parq.AnswerSeven, parq.AnswerEight, parq.AnswerNine, parq.AnswerTen, parq.AnswerEleven, parq.AnswerTwelve, parq.AnswerThirteen, parq.AnswerFourteen, parq.AnswerFifteen, parq.AnswerSixteen,
                                             parq.AddInfoOne, parq.AddInfoTwo, parq.AddInfoThree, parq.AddInfoFour, parq.AddInfoFive, parq.AddInfoSix, parq.AddInfoSeven, parq.AddInfoEight, parq.AddInfoNine, parq.AddInfoTen, parq.AddInfoEleven, parq.AddInfoTwelve, parq.AddInfoThirteen, parq.AddInfoFourteen, parq.AddInfoFifteen, parq.AddInfoSixteen);

                        

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

                    this.TempData["workout"] = workout;

                    return RedirectToAction("Client");

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
        public ActionResult Client()
        {
            ModelState.Clear();
            return View();
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

            var dateOfBirthToString = client.DateOfBirth.ToString(CultureInfo.CurrentCulture);

            var day = client.DateOfBirth.Day.ToString();

            var month = client.DateOfBirth.Month.ToString();
            var year = client.DateOfBirth.Year.ToString();

            var dateOfBirthFormat = string.Format(day + "/" + month + "/" + year);

            clientInfo.DateOfBirth.ToString(dateOfBirthFormat);

            clientInfo.Age = (today.Year - client.DateOfBirth.Year);
            client.Height = clientInfo.Height;
            client.Weight = clientInfo.Weight;
            client.BodyMass = clientInfo.BodyMass;
            client.Goal = clientInfo.Goal;
            client.AddInfo = clientInfo.AddInfo;

            clientInfo.RegistrationDate = today.Date;

            using (myConnection)
            {
                string clientCommand = string.Format("INSERT INTO dbo.Person(FirstName, LastName, Age, DateOfBirth, Height, Weight, Postcode, Address, Gender, EmailAddress, PhoneNumber, AddInfo, DateOfRegistration), " +
                                                     "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}'", clientInfo.FName, clientInfo.LName, clientInfo.Age, clientInfo.DateOfBirth, 
                                                     clientInfo.Height, clientInfo.Weight, clientInfo.Postcode, clientInfo.AddressLine1 + ", " + client.AddressLine2, clientInfo.Gender, clientInfo.Email, clientInfo.Phone, clientInfo.AddInfo, clientInfo.RegistrationDate);
                
                using (SqlCommand queryClientCommand = new SqlCommand(clientCommand))
                {
                    if (myConnection.State == ConnectionState.Open)
                    {
                        queryClientCommand.Connection = myConnection;
                    }
                    else
                    {
                        myConnection.Open();
                        queryClientCommand.Connection = myConnection;
                    }
                    myConnection.Close();
                }
            }

            this.TempData["clientInfo"] = clientInfo;

            return RedirectToAction("CheckDetails");
        }

        //
        // GET: /Workout/CheckDetails
        [HttpGet]
        public ActionResult CheckDetails()
        {
            var clientInfo = this.TempData["clientInfo"] as Workout;
            return View(clientInfo);
        }

        // POST: /Workout/CheckDetails
        [HttpPost]
        public ActionResult CheckDetails(FitnessTest test)
        {
            this.TempData["fitnessTest"] = FitnessTest();
            return View("FitnessTest");

        }

        // GET: /Workout/FitnessTest
        [HttpGet]
        public ActionResult FitnessTest()
        {
            var fitnessTest = this.TempData["fitnessTest"] as FitnessTest;

            if (fitnessTest != null && fitnessTest.ORM != 0)
            {
                fitnessTest.TRM = fitnessTest.ORM * 0.95f;
            }

            return View(fitnessTest);
        }

        [HttpPost]
        public ActionResult FitnessTest(FitnessTest test)
        {
            this.TempData["TestData"] = FitnessTest();
            test.ORM = OrmCalc(test);

            return View("Create");

        }

        public ActionResult Create()
        {
            // get list of exercises from database
            // 

            
            return View();
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