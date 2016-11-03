using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalTrainer.Controllers;

namespace PersonTrainerTests.TestControllers
{
    [TestClass]
    public class WorkoutControllerTest
    {
        [TestMethod]
        public void TestWorkoutView()
        {
            var controller = new ClientController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }




}
