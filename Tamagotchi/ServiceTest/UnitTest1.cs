using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi_WCF;
//using Moq;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace ServiceTest
{
    [TestClass]
    public class UnitTest1
    {

        Tamagotchi Henk = new Tamagotchi{
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
            };
        Tamagotchi Jan = new Tamagotchi
        {
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
        };

        private Tamagotchi swagger;

        public void Init()
        {
            swagger = new Tamagotchi();
        }

        
       
        [TestMethod]
        public void ChooseTamagotchiTest()
        {
            //Arrange
            //string name = "Jan";

            //Act
            //Tamagotchi tmg = this.MockTamagotchi.ChooseTamagotchi(name);
            
            //Assert
            //Assert.AreEqual(tmg, Jan);
        }

        [TestMethod]
        public void GetTamagotchiTest()
        {

        }

        [TestMethod]
        public void SlaapTekortTest()
        {
            

        }

        [TestMethod]
        public void CreateTamagotchiTest()
        {
            //Arrange
            //string name = "Henk";
            //Tamagotchi tmg;
            //Act
            //tmg = mocktamagotchi.CreateTamagotchi(name);
            //Assert
            //Assert.IsNotNull(tmg);
        }

        [TestMethod]
        public void PerformActionTest()
        {
            //Arrange
            //string actie = "sleep";
            //string result;
            //Tamagotchi tmgtest = GetTamagotchi();

            //Act
            //result = service.PerformAction(actie, tmgtest);

            //Assert
            //Assert.AreEqual(result, "Je Tamagotchi is aan het slapen. Dit duurt 2 uur.");
        }

 
    }
}
