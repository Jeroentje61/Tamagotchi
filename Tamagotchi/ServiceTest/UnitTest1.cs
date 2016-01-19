using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi_WCF;
using Moq;
using System.Data.Entity;
using System.Collections.Generic;
using Tamagotchi_WCF.Spelregels;
using Tamagotchi_WCF.Actions;

namespace ServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        
        private Tamagotchi_WCF.Tamagotchi tamagotchi;
        private Tamagotchi_WCF.TmgContext tmgcontext;

       [TestInitialize]
        public void Init()
        {
            tmgcontext = new TmgContext();
            tamagotchi = new Tamagotchi();
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
        public void HugTest()
        {
            //Arrange
            String message;
            //Act
            IAction i = new Hug();
            Tamagotchi tmg = new Tamagotchi();
              message = i.Act(tamagotchi, out tmg);
            //Assert
              Assert.AreEqual("Je Tamagotchi is aan het knuffelen. Dit duurt 60 seconden.", message);
        }
        [TestMethod]
        public void PlayTest()
        {
            //Arrange
            String message;
            //Act
            IAction i = new Play(); 
            Tamagotchi tmg = new Tamagotchi();
            message = i.Act(tamagotchi, out tmg);
            //Assert
            Assert.AreEqual("Je Tamagotchi is aan het spelen. Dit duurt 30 seconden.", message);
        }
        [TestMethod]
        public void SleepTest()
        {
            //Arrange
            String message;
            //Act
            IAction i = new Sleep();
            Tamagotchi tmg = new Tamagotchi();
            message = i.Act(tamagotchi, out tmg);
            //Assert
            Assert.AreEqual("Je Tamagotchi is aan het slapen. Dit duurt 2 uur.", message);
        }
        [TestMethod]
        public void WorkoutTest()
        {
            //Arrange
            String message;
            //Act
            IAction i = new Workout();
            Tamagotchi tmg = new Tamagotchi();
            message = i.Act(tamagotchi, out tmg);
            //Assert
            Assert.AreEqual("Je Tamagotchi doet een workout. Dit duurt 60 seconden.", message);
        }

        [TestMethod]
        public void EatTest()
        {
            //Arrange
            String message;
            //Act
            IAction i = new Eat();
            Tamagotchi tmg = new Tamagotchi();
            message = i.Act(tamagotchi, out tmg);
            //Assert
            Assert.AreEqual("Je Tamagotchi is aan het eten. Dit duurt 30 seconden.", message);
        }

        [TestMethod]
        public void SlaapTekortTest()
        {
            //Arrange
            tamagotchi.Sleep = 100;
            //Act
            ISpelregel i = new Slaaptekort();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(false, tamagotchi.Alive);
        }
        [TestMethod]
        public void CrazyTest()
        {
            //Arrange
            tamagotchi.Health = 100;
            //Act
            ISpelregel i = new Crazy();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(true, tamagotchi.Crazy);
        }
        [TestMethod]
        public void CrazyFalseTest()
        {
            //Arrange
            tamagotchi.Health = 50;
            //Act
            ISpelregel i = new Crazy();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(false, tamagotchi.Crazy);
        }

        [TestMethod]
        public void HongerTest()
        {
            //Arrange
            tamagotchi.Hunger = 100;
            //Act
            ISpelregel i = new Honger();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(false, tamagotchi.Alive);
        }
        [TestMethod]
        public void IsolatieTest()
        {
            //Arrange
            tamagotchi.Health = 100;
            //Act
            ISpelregel i = new Isolatie();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(100, tamagotchi.Health);
        }
        [TestMethod]
        public void MunchiesTest()
        {
            //Arrange
            tamagotchi.Boredom = 100;
            //Act
            ISpelregel i = new Munchies();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(true, tamagotchi.Munchies);
        }
        [TestMethod]
        public void TopatleetTest()
        {
            //Arrange
            tamagotchi.Health = 0;
            //Act
            ISpelregel i = new Topatleet();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(true, tamagotchi.TopAtleet);
        }
        [TestMethod]
        public void VermoeidheidTest()
        {
            //Arrange
            tamagotchi.Sleep = 50;
            tamagotchi.LastAcces = DateTime.Now.AddHours(-2);
            //Act
            ISpelregel i = new Vermoeidheid();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(60, tamagotchi.Sleep);
        }
        [TestMethod]
        public void VervelingTest()
        {
            //Arrange
            tamagotchi.Boredom = 100;
            //Act
            ISpelregel i = new Verveling();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(100, tamagotchi.Boredom);
        }
    }
}
