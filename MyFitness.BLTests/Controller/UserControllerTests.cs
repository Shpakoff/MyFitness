using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        
        [TestMethod()]
        public void SetNewUserDateTest()
        {
            //Arrange
            Random rnd = new Random();
            var userName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Now.AddYears(-18);
            var weight = rnd.Next(1,200);
            var heigth = rnd.Next(1,250);
            var gender = "man";
            var controller = new UserController(userName);
            //Act

            controller.SetNewUserDate(gender, birthDate, weight, heigth);
            var controller2 = new UserController(userName);
            //Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(birthDate, controller2.CurrentUser.BirthData);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(heigth, controller2.CurrentUser.Height);

        }

        [TestMethod()]
        public void SaveTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();

            //Act
            var controller = new UserController(userName);
            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}