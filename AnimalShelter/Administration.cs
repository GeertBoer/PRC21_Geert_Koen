﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        private List<Animal> animals; 

        public Administration()
        {
            animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {         
            if(animal != null)
            {
                animals.Add(animal);
                return true;
            }
            return false;  
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in animals)
            {
                if (a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animals.Remove(a);                    
                    return true;
                }
            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in animals)
            {
                if(a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return a;
                }
            }
            return null;
        }

        public Animal FindAnimal(string name)
        {
            foreach (Animal a in animals)
            {
                if (a.Name == name)
                {
                    return a;
                }
            }
            return null;
        }

        public bool CheckChipNrIsAvailable(int nr)
        {
            if (nr < 0) return false;

            foreach (Animal a in animals)
            {
                if (a.ChipRegistrationNumber == nr)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
