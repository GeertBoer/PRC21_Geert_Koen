using System;
using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
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
        public void FindExistingAnimalTest()
        {
            Cat c = new Cat(38, date, "Ryan", "Zit altijd in de ballenbak met een kater");
            Administration a = new Administration();
            a.Add(c);

            Cat catToFind = a.FindAnimal(38) as Cat;
            Assert.AreEqual(c, catToFind);
        }

        [TestMethod]
        public void FindNotExistingAnimalTest()
        {
            Administration a = new Administration();

            Cat catToFind = a.FindAnimal(38) as Cat;
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

            bool exists = a.CheckChipNrIsAvailable(-100);
            Assert.AreEqual(false, exists);
        }
    }
}
