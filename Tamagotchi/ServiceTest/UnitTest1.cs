using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi_WCF;
using Moq;
using System.Data.Entity;

namespace ServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        
        Service service = new Service();
        
        public Tamagotchi GetTamagotchi()
        {
            Tamagotchi tmgtest = new Tamagotchi()
            {
                Naam = "Henk",
                Hunger = 0,
                Sleep = 0,
                Boredom = 0,
                Health = 0,
                LastAcces = DateTime.MinValue,
                AccesGranted = DateTime.MinValue
            };
            return tmgtest;
        }

        [TestMethod]
        public void GetTamagotchiTest()
        {
        }

        [TestMethod]
        public void CreateTamagotchiTest()
        {
            //Arrange
            
            string name = "BlaBla";
            Tamagotchi tmg;
            //Act
            tmg = service.CreateTamagotchi(name);
            //Assert
            Assert.IsNotNull(tmg);
        }

        [TestMethod]
        public void PerformActionTest()
        {
            //Arrange
            string actie = "sleep";
            string result;
            Tamagotchi tmgtest = GetTamagotchi();

            //Act
            result = service.PerformAction(actie, tmgtest);

            //Assert
            Assert.AreEqual(result, "Je Tamagotchi is aan het slapen. Dit duurt 2 uur.");
        }

        public void ChooseTamagotchiTest()
        {

        }
    }
}
