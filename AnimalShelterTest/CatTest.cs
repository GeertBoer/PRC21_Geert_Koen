using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTest
{
    [TestClass]
    public class CatTest
    {
        SimpleDate date = new SimpleDate(12, 12, 1999);
        [TestMethod]
        public void NullBadHabitsMeansNoBadHabits()
        {
            Cat cat = new Cat(38, date, "Henk", null);
            Assert.AreEqual("", cat.BadHabits);
        }

        [TestMethod]
        public void ToStringCheck()
        {
            Cat cat = new Cat(38, date, "Henk", "flopt 'em kooi");
            Assert.AreEqual("Cat: 38, 12-12-1999, Henk, not reserved, flopt 'em kooi.", cat.ToString());
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Cat cat = new Cat(38, date, "Henk", "flopt 'em kooi");
            Assert.AreEqual(38, cat.ChipRegistrationNumber);
            Assert.AreEqual(date, cat.DateOfBirth);
            Assert.AreEqual("Henk", cat.Name);
            Assert.AreEqual("flopt 'em kooi", cat.BadHabits);
        }

        [TestMethod]
        public void PriceTestWhenBadHabitsAreNormal()
        {
            Cat cat = new Cat(38, date, "Henk", "flopt 'em kooi");
            Assert.AreEqual(46, cat.Price);
        }

        [TestMethod]
        public void PriceTestWhenBadHabitsAreEmpty()
        {
            Cat cat = new Cat(38, date, "Henk", "");
            Assert.AreEqual(60, cat.Price);
        }

        [TestMethod]
        public void PriceTestWhenBadHabitsAreExtremelyLong()
        {
            Cat cat = new Cat(38, date, "Henk", "flopt 'em kooiewfkjbweifbkjnkfjcnfwnedcikjenwkfnilearjvblueshbfvluhbeufvhbaerluvbluaerkooiewfkjbweifbkjnkfjcnfwnedcikjenwkfnilearjvblueshbfvluhbeufvhbaerluvbluaer");
            Assert.AreEqual(0, cat.Price);
        }
    }
}

