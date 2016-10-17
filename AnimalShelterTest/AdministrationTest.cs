using System;
using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AnimalShelterTest
{
    [TestClass]
    public class AdministrationTest
    {
        SimpleDate date = new SimpleDate(12, 12, 1999);
        [TestMethod]

        public void AddNewCatTest()
        {
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
            Administration a = new Administration();
            bool succes = a.Add(c);
            Assert.AreEqual(true, succes);
        }

        [TestMethod]
        public void AddNewCatWhichIsNullTest()
        {
            Cat c = null;
            Administration a = new Administration();
            bool succes = a.Add(c);
            Assert.AreEqual(false, succes);
        }

        [TestMethod]
        public void RemoveExistingCatTest()
        {
            Cat c = new Cat(38, date, "Ryan", "Killed Harambae");
            Administration a = new Administration();
            a.Add(c);
            bool succes = a.RemoveAnimal(c.ChipRegistrationNumber);
            Assert.AreEqual(true, succes);
        }

        [TestMethod]
        public void RemoveNotExistingCatTest()
        {
            Administration a = new Administration();
            bool succes = a.RemoveAnimal(38);
            Assert.AreEqual(false, succes);
        }

        [TestMethod]
        public void FindExistingAnimalTestString()
        {
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
            Administration a = new Administration();
            a.Add(c);

            Cat catToFind = a.FindAnimal("Ryan") as Cat;
            Assert.AreEqual(c, catToFind);
        }

        [TestMethod]
        public void FindNotExistingAnimalTestString()
        {
            Administration a = new Administration();

            Cat catToFind = a.FindAnimal("BushDid9/11") as Cat;
            Assert.AreEqual(null, catToFind);
        }

        [TestMethod]
        public void FindNullAnimalTestString()
        {
            Administration a = new Administration();

            Cat catToFind = a.FindAnimal(null) as Cat;
            Assert.AreEqual(null, catToFind);
        }

        [TestMethod]
        public void FindExistingAnimalTestInt()
        {
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
            Administration a = new Administration();
            a.Add(c);

            Cat catToFind = a.FindAnimal(38) as Cat;
            Assert.AreEqual(c, catToFind);
        }

        [TestMethod]
        public void FindNotExistingAnimalTestInt()
        {
            Administration a = new Administration();

            Cat catToFind = a.FindAnimal(38383838) as Cat;
            Assert.AreEqual(null, catToFind);
        }

        [TestMethod]
        public void CheckForAvailableChipNrWhichIsNotAvailable()
        {
            Administration a = new Administration();
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
            a.Add(c);

            bool available = a.CheckChipNrIsAvailable(38);
            Assert.AreEqual(false, available);
        }

        [TestMethod]
        public void CheckForAvailableChipNrWhichIsAvailable()
        {
            Administration a = new Administration();
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
            a.Add(c);

            bool available = a.CheckChipNrIsAvailable(40);
            Assert.AreEqual(true, available);
        }

        [TestMethod]
        public void CheckForAvailableChipNrWhichIsNegative()
        {
            Administration a = new Administration();
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
            a.Add(c);
            string result = Path.GetTempFileName();
            a.Save(result);
            bool exists = a.CheckChipNrIsAvailable(-100);
            Assert.AreEqual(false, exists);
        }
    }
}
