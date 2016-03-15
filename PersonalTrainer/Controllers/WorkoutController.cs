using System.Web.Mvc;
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
            return View();
        }

        //
        // POST: /Workout/Parq
        [HttpPost]
        public ActionResult ParQ(Parq parq)
        {
            if (!ModelState.IsValid && (parq.AddInfo != null))
            {
                return View("ParQ");
            }
            else
            {
                return View("Client");
            }
        }

        //
        // POST: /Workout/Client
        [HttpPost]
        public ActionResult Client(Workout client)
        {
            var clientInfo = client;
            client.FName = clientInfo.FName;
            client.LName = clientInfo.LName;
            client.Gender = clientInfo.Gender;
            client.DateOfBirth = clientInfo.DateOfBirth;
            client.Age = clientInfo.ClientAge();
            client.Height = clientInfo.Height;
            client.Weight = clientInfo.Weight;
            client.BodyMass = clientInfo.BodyMass;
            client.Goal = clientInfo.Goal;
            client.AddInfo = clientInfo.AddInfo;

            return View("CheckDetails", clientInfo);
        }

        //
        // GET: /Workout/CheckDetails
        [HttpGet]
        public ActionResult CheckDetails(Workout clientInfo, string name)
        {
            name = string.Empty;
            return View(clientInfo);
        }

        // POST: /Workout/CheckDetails
        [HttpPost]
        public ActionResult CheckDetails(Workout clientInfo)
        {
            return View("MakePlan", clientInfo);
        }

        public ActionResult Create(WorkoutController workout)
        {
            return View(workout);
        }

        //
        // GET: /Workout/Client
        [HttpGet]
        public ViewResult Client()
        {
            var client = new Workout();
            return View();
        }
    }
}