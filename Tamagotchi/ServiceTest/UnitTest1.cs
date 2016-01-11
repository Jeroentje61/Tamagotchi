using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi_WCF;
using Moq;
using System.Data.Entity;
using System.Collections.Generic;

namespace ServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
           
            //mock tamagotchis aanmaken
            IList<Tamagotchi> tamagotchis = new List<Tamagotchi>
            {
                new Tamagotchi {
                Naam = "Henk",
                Hunger = 0,
                Sleep = 0,
                Boredom = 0,
                Health = 0,
                LastAcces = DateTime.MinValue,
                AccesGranted = DateTime.MinValue,
                Alive = true,
                Crazy = false,
                Munchies = false,
                TopAtleet = true
            },
            new Tamagotchi {
                Naam = "Jan",
                Hunger = 0,
                Sleep = 0,
                Boredom = 0,
                Health = 0,
                LastAcces = DateTime.MinValue,
                AccesGranted = DateTime.MinValue,
                Alive = true,
                Crazy = false,
                Munchies = false,
                TopAtleet = true
            }
            };
            // interface mocken
            Mock<ITamagotchiService> mocktamagotchi = new Mock<ITamagotchiService>();

            //Deze schijt regel!!!!@@@@@@@@@
            //mocktamagotchi.Setup(mr => mr.GetTamagotchis()).Returns(tamagotchis);


        }
        
       
        
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
            //tmg = mocktamagotchi.CreateTamagotchi(name);
            //Assert
           // Assert.IsNotNull(tmg);
        }

        [TestMethod]
        public void PerformActionTest()
        {
            //Arrange
            string actie = "sleep";
            string result;
            Tamagotchi tmgtest = GetTamagotchi();

            //Act
            //result = service.PerformAction(actie, tmgtest);

            //Assert
            //Assert.AreEqual(result, "Je Tamagotchi is aan het slapen. Dit duurt 2 uur.");
        }

        public void ChooseTamagotchiTest()
        {

        }
    }
}
