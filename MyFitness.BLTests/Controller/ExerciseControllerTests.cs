using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFitness.BL.Controller;
using MyFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.BL.Controller.Tests
{
    [TestClass()]
    public class ExerciseControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrage
            var userName = Guid.NewGuid().ToString();
            var activityName = Guid.NewGuid().ToString();
            var rnd = new Random();
            var userController = new UserController(userName);
            var exerciseController = new ExerciseController(userController.CurrentUser);
            var activity = new Activity(activityName, rnd.Next(10,50));


            //Act
            exerciseController.Add(activity, DateTime.Now, DateTime.Now.AddHours(1));

            //Assert
            Assert.AreEqual(activityName, exerciseController.Activities.First().Name);
        }
    }
}