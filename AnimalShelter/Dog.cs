using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    [Serializable]
    public class Dog : Animal
    {
        /// <summary>
        /// The date of the last walk of the dog. Contains null if unknown.
        /// </summary>
        private SimpleDate lastWalkDate;

        public SimpleDate LastWalkDate
        {
            get { return lastWalkDate; }
            set
            {
                if (value != null)
                {
                    lastWalkDate = value;
                }
                else if (value == null) throw new ArgumentNullException();
            }
        }

        public override decimal Price
        {
            get
            {
                if (ChipRegistrationNumber < 50000)
                {
                    return 200.00m;
                }
                else
                {
                     return 350.00m;
                }              
            }           
        }


        /// <summary>
        /// Creates a dog.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        /// <param name="lastWalkDate">The date of the last walk with the dog or null if unknown.</param>
        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, SimpleDate lwd) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            // TODO: Modify the constructor. Make sure it initializes all properties of the class.
            if (chipRegistrationNumber >= 0 && dateOfBirth != null && name != null && name != "" && lwd != null)
            {
                LastWalkDate = lwd;
            }
            else throw new ArgumentException("vul de juiste waardes in!");
        }

        /// <summary>
        /// Retrieve information about this dog
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Dog: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <LastWalkDate>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 LastWalkDate will be "unknown" if unknown or the date of the last doggywalk otherwise.
        /// </returns>
        /// 


        public override string ToString()
        {
            // TODO: Put your own code here to make the method return the string specified in the
            // method description.
            return "Dog: " + base.ToString() + ", " + LastWalkDate + ".";
        }
    }
}
