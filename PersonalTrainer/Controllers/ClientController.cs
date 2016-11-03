using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using PersonalTrainer.DAL;
using PersonalTrainer.Models;
using PagedList;
using PersonalTrainer.ViewModel;

namespace PersonalTrainer.Controllers
{
    public class ClientController : Controller
    {
        private TrainingPlannerContext db = new TrainingPlannerContext();

        public ActionResult Index()
        {
            var clientId = Session["clientId"] as string;
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
            var loginName = new UserProfile().FullName;
            var parq = new Parq();


            if (loginName != null)
            {
                parq.Name = loginName;
            }

            return View(parq);
        }

        //
        // POST: /Workout/Parq
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ParQ(Parq parq)
        {
            int pass = 0;

            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(parq.Name) && !string.IsNullOrEmpty(parq.Email))
                {

                    var client = new ClientViewModel();

                    client.ClientId = !string.IsNullOrEmpty(TempData["clientId"] as string)
                        ? (string) TempData["clientId"]
                        : DateTime.Today.ToString("Mddhhmmss");

                    if (!string.IsNullOrEmpty(parq.Name))
                    {
                        var fullName = parq.Name;
                        const char splitChar = ' ';
                        var afterSplit = fullName.Split(splitChar);
                        client.FName = afterSplit[0];
                        client.LName = afterSplit[1];
                    }

                    this.Session["myModel"] = client;

                    if (db.Parqs != null)
                    {
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Parqs?.Add(parq);
                        db.SaveChanges();
                    }
                    return RedirectToAction("Client");

                }
            }
            if (string.IsNullOrEmpty(parq.Email) || string.IsNullOrEmpty(parq.Name))
            {
                pass++;
                ViewBag.Message =
                    "Please make sure you have entered your full name and a correct and current email address. " +
                    "This is so we can send you a documented copy of the form for you to keep";
            }
            if (parq.ParqAgreement != true)
            {
                pass++;
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

            var clientViewModel = new ClientViewModel();

            var mainModel = this.Session["myModel"] as Client ?? new Client();

            clientViewModel.FName = mainModel.FName;
            clientViewModel.LName = mainModel.LName;
            clientViewModel.Gender = mainModel.Gender;
            clientViewModel.DateOfBirth = mainModel.DateOfBirth;
            clientViewModel.AddressLine1 = mainModel.AddressLine1;
            clientViewModel.AddressLine2 = mainModel.AddressLine2;
            clientViewModel.Postcode = mainModel.Postcode;
            clientViewModel.Phone = mainModel.Phone;
            clientViewModel.Email = mainModel.Email;

            // if(GoalDictionary._dictionary.ContainsKey(clientViewModel.GoalId))

            return View();
        }

        //
        // POST: /Workout/Client
        [HttpPost]
        public ActionResult Client(ClientViewModel clientViewModel)
        {
            int pass = 0;
            if (!ModelState.IsValid)
            {
                pass++;
                ViewBag.Pass = pass;
                ViewBag.Message = "Please complete all fields before continuing";
                return View();
            }
            if (pass == 0)
            {
                ModelState.Clear();
            }
            var today = DateTime.Today;
            var clientInfo = clientViewModel;
            clientViewModel.FName = clientInfo.FName;
            clientViewModel.LName = clientInfo.LName;
            clientInfo.Gender = clientViewModel.Gender == "Male" ? "Male" : "Female";

            var dateOfBirthToString = clientViewModel.DateOfBirth.ToString(CultureInfo.CurrentCulture);

            clientInfo.DateOfBirth.ToString(dateOfBirthToString);

            clientInfo.Age = (today.Year - clientViewModel.DateOfBirth.Year);
            // clientViewModel.GoalId = clientInfo.GoalId;
            clientViewModel.AddInfo = clientInfo.AddInfo;
            clientViewModel.EmergencyContact = clientInfo.EmergencyContact;
            clientViewModel.EmergencyContactNumber = clientInfo.EmergencyContactNumber;

            this.Session["myModel"] = clientInfo;
            if (db.Clients != null)
            {
                db.SaveChanges();
            }
            else
            {
                db.Clients.Add(clientViewModel);
                db.SaveChanges();
            }

            return RedirectToAction("MoreClient");
        }

        [HttpGet]
        public ActionResult MoreClient(Client client)
        {
            ModelState.Clear();

            var clientdata = this.TempData["clientInfo"] as Client;

            return View(clientdata);
        }

        [HttpPost]
        public ActionResult MoreClient()
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Please make sure all fields are completed";
                return View();
            }
            var clientData = new Client();
            this.TempData["clientInfo"] = clientData;

            if(clientData.Height!=0M || clientData.Weight!=0M)
            { 
                clientData.BodyMass = BodyMass(clientData);
            }

            db.SaveChanges();

            // this.TempData["clientInfo"] = clientData;

            //if (db.Clients != null)
            //{
            //    db.SaveChanges();
            //}
            //else
            //{
            //    db.Clients.Add();
            //    db.SaveChanges();
            //}

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
            var clientInfo = this.TempData["clientInfo"] as Client;


            var fitnessTest = new FitnessTest();
            fitnessTest.CardioNameList = new List<string>();
            fitnessTest.ClientId = clientInfo.ClientId;

            if (db.FitnessTests != null)
            {
                db.SaveChanges();
            }
            else
            {
                db.FitnessTests.Add(fitnessTest);
                db.SaveChanges();
            }

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

        public decimal BodyMass(Client client)
        {
            var weightDec = 00.00M;
            var heightDec = 00.00M;

            if (client.Weight != 0 || client.Height != 0)
            {
                weightDec = client.Weight;
                heightDec = client.Height;
            }

            var bodyMass = weightDec / heightDec * heightDec;

            return bodyMass;
        }

    }
}