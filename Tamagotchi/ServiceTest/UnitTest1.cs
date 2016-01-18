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
        public void EatTest()
        {
            //Arrange
            tamagotchi.Sleep = 100;
            tamagotchi.Alive = false;
            //Act
            IAction i = new Eat();
            //    "eat" = i.Act(tamagotchi);
            //Assert
            Assert.AreEqual(false, tamagotchi.Alive);
        }

        [TestMethod]
        public void SlaapTekortTest()
        {
            //Arrange
            tamagotchi.Sleep = 100;
            tamagotchi.Alive = false;
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
            tamagotchi.Crazy = true;
            //Act
            ISpelregel i = new Crazy();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(100, tamagotchi.Health);
        }

        [TestMethod]
        public void HongerTest()
        {
            //Arrange
            tamagotchi.Hunger = 100;
            tamagotchi.Alive = false;
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
            Assert.AreEqual(0, tamagotchi.Health);
        }
        [TestMethod]
        public void MunchiesTest()
        {
            //Arrange
            tamagotchi.Boredom = 100;
            tamagotchi.Munchies = true;
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
            tamagotchi.TopAtleet = true;
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
            tamagotchi.Sleep = 100;
            //Act
            ISpelregel i = new Vermoeidheid();
            tamagotchi = i.ExecuteSpelregel(tamagotchi);
            //Assert
            Assert.AreEqual(100, tamagotchi.Sleep);
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
