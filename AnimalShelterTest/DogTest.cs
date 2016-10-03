using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTest
{
    [TestClass]
    public class DogTest
    {
        SimpleDate date = new SimpleDate(12, 12, 1999);
        [TestMethod]
        public void LastWalkDateTest()
        {
            Dog d = new Dog(38, date, "hundje", date);
            d.LastWalkDate = date;
            Assert.AreEqual(date, d.LastWalkDate);
        }

        [TestMethod]
        public void CheckPriceWhenChipNrIsLowerThan50000()
        {
            Dog d = new Dog(1, date, "hundje", date);
            Assert.AreEqual(200.00m, d.Price);
        }

        [TestMethod]
        public void checkPriceWhenChipNrIs50000()
        {
            Dog d = new Dog(50000, date, "hundje", date);
            Assert.AreEqual(350.00m, d.Price);
        }

        [TestMethod]
        public void checkPriceWhenChipNrIsZero()
        {
            Dog d = new Dog(0, date, "hundje", date);
            Assert.AreEqual(200.00m, d.Price);
        }
    }
}
