using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using PersonalTrainer.DAL;
using PersonalTrainer.Models;
using PagedList;

namespace PersonalTrainer.Controllers
{
    public class WorkoutController : Controller
    {
        private TrainingPlannerContext db = new TrainingPlannerContext();
      
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClientLookup(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "LName" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "RegistrationDate" : "Date";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var clients = from c in db.Clients
                          select c;
            if (!string.IsNullOrEmpty(searchString))
            {
                clients = clients.Where(c => c.LName.Contains(searchString)
                                             || c.FName.Contains(searchString));
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(clients.ToPagedList(pageNumber, pageSize));
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
          //  if (ModelState.IsValid)
          //  {
          //      if (!string.IsNullOrEmpty(parq.Name) && !string.IsNullOrEmpty(parq.Email))
          //      {
                    var workout = new Client();

                    
                    if (!string.IsNullOrEmpty(parq.Name))
                    {
                        string fullName = parq.Name;
                        char splitChar = ' ';
                        string[] afterSplit = fullName.Split(splitChar);
                        workout.FName = afterSplit[0];
                        workout.LName = afterSplit[1];
                    }

                    this.TempData["workout"] = workout;
                    if (db.Parqs != null)
                    {
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Parqs.Add(parq);
                        db.SaveChanges();
                    }
                    return RedirectToAction("Client");

                }
            // }
            ////if (string.IsNullOrEmpty(parq.Email) || string.IsNullOrEmpty(parq.Name))
            ////{
            ////    ViewBag.Message =
            ////        "Please make sure you have entered your full name and a correct and current email address. " +
            ////        "This is so we can send you a documented copy of the form for you to keep";
            ////}
            ////if (parq.ParqAgreement != true)
            ////{
            ////    ViewBag.MessageAgreement =
            ////        "Please tick the checkbox at the bottom of the page in order to continue";
            ////}
            // return View();
        // }

        //
        // GET: /Workout/Client
        [HttpGet]
        public ActionResult Client()
        {
            ModelState.Clear();

            var workoutModel = this.TempData["workout"] as Client ?? new Client();

            return View(workoutModel);
        }

        //
        // POST: /Workout/Client
        [HttpPost]
        public ActionResult Client(Client client)
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
            clientInfo.Gender = client.Gender == "Male" ? "Male" : "Female";

            var dateOfBirthToString = client.DateOfBirth.ToString(CultureInfo.CurrentCulture);

            clientInfo.DateOfBirth.ToString(dateOfBirthToString);

            clientInfo.Age = (today.Year - client.DateOfBirth.Year);
            client.Height = clientInfo.Height;
            client.Weight = clientInfo.Weight;
            client.BodyMass = clientInfo.BodyMass;
            client.GoalId = clientInfo.GoalId;
            client.AddInfo = clientInfo.AddInfo;
            client.EmergencyContact = clientInfo.EmergencyContact;
            client.EmergencyContactNumber = clientInfo.EmergencyContactNumber;
            clientInfo.RegistrationDate = today.Date;

            this.TempData["clientInfo"] = clientInfo;
            if (db.Clients != null)
            {
                db.SaveChanges();
            }
            else
            {
                db.Clients.Add(clientInfo);
                db.SaveChanges();
            }

            return RedirectToAction("MoreClient");
        }

        [HttpGet]
        public ActionResult MoreClient(MoreClientData moreClient)
        {
            ModelState.Clear();

            var clientdata = this.TempData["clientInfo"] as Client;

            moreClient.Height = clientdata.Height;
            moreClient.BodyWeight = clientdata.Weight;

            return View();
        }

        [HttpPost]
        public ActionResult MoreClient()
        {
            //if (!ModelState.IsValid)
            //{
            //    ViewBag.Message = "Please make sure all fields are completed";
            //    return View();
            //}
            
            var moreClientModel = this.TempData["Client"] as MoreClientData;

            var client = new MoreClientData();

            client.ClientId = moreClientModel.ClientId;
            
            db.SaveChanges();

            if (db.MoreClientDatas != null)
            {
                db.SaveChanges();
            }
            else
            {
                db.MoreClientDatas.Add(moreClientModel);
                db.SaveChanges();
            }

            return RedirectToAction("CheckDetails");
        }

        //
        // GET: /Workout/CheckDetails
        [HttpGet]
        public ActionResult CheckDetails()
        {
            ModelState.Clear();

            var clientInfo = this.TempData["clientInfo"] as Client;
            return View(clientInfo);
        }

        // POST: /Workout/CheckDetails
        [HttpPost]
        public ActionResult CheckDetails(FitnessTest test)
        {
            this.TempData["fitnessTest"] = FitnessTest();
            return RedirectToAction("FitnessTest");
        }

        // GET: /Workout/FitnessTest
        [HttpGet]
        public ActionResult FitnessTest()
        {
            var fitnessTest = new FitnessTest();
            fitnessTest.CardioNameList = new List<string>();

            ////using (myConnection)
            ////{
            ////    using (SqlCommand queryCardioCommand = new SqlCommand("SELECT ExerciseName FROM dbo.Exercise WHERE ExerciseId LIKE \'CA%\'"))
            ////    {
            ////        if (myConnection.State == ConnectionState.Open)
            ////        {
            ////            queryCardioCommand.Connection = myConnection;
            ////        }
            ////        else
            ////        {
            ////            myConnection.Open();
            ////            queryCardioCommand.Connection = myConnection;
            ////        }

            ////        try
            ////        {
            ////            SqlDataReader myReader = null;
            ////            myReader = queryCardioCommand.ExecuteReader();
            ////            while (myReader.Read())
            ////            {   
            ////                foreach (var item in myReader)
            ////                {
            ////                   fitnessTest.CardioNameList.Add(myReader["ExerciseName"].ToString());
            ////                }

            ////            }
            ////        }
            ////        catch (Exception)
            ////        {
            ////            throw;
            ////        }

            ////        myConnection.Close();

            ////    }
            ////}

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

            return RedirectToAction("Create");

        }

        [HttpGet]
        public ActionResult Create()
        {
            var clientInfo = this.TempData["clientInfo"] as Client;
            var testData = this.TempData["TestData"] as FitnessTest;


            //////map ExerciseToFocusTable
            ////using (SqlCommand getExerciseByFocusIdCommand = new SqlCommand(string.Format("SELECT FocusName FROM dbo.Focus WHERE FocusName LIKE '{0}'", clientInfo.Focus)))

            ////// get list of exercises from database
            ////// 
            ////using (SqlCommand queryCardioCommand = new SqlCommand(string.Format("SELECT * FROM dbo.Exercise WHERE ExerciseId LIKE '{0}'", getExerciseByFocusIdCommand)))
            ////{
            ////    if (myConnection.State == ConnectionState.Open)
            ////    {
            ////        queryCardioCommand.Connection = myConnection;
            ////    }
            ////    else
            ////    {
            ////        myConnection.Open();

            ////        queryCardioCommand.Connection = myConnection;
            ////    }

            ////    try
            ////    {
            ////        SqlDataReader myReader = null;
            ////        myReader = queryCardioCommand.ExecuteReader();
            ////        while (myReader.Read())
            ////        {
            ////            foreach (var item in myReader)
            ////            {
            ////                testData.CardioNameList.Add(myReader["ExerciseName"].ToString());
            ////            }

            ////        }
            ////    }
            ////    catch (Exception)
            ////    {
            ////        throw;
            ////    }

            ////    myConnection.Close();

            ////}
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(FitnessTest test, Client client)
        {
            return RedirectToAction("Begin", "Active");
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