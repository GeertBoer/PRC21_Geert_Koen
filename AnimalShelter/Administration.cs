﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace AnimalShelter
{
    [Serializable]
    public class Administration
    {
        public List<Animal> Animals { get; private set; }
/* SERIAL KAK
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Animals", this.Animals);
        }

        public Administration(SerializationInfo info, StreamingContext context)
        {
            Animals = (List<Animal>)info.GetValue("Animals", Animals.GetType());
        }
*/
        public Administration()
        {
            Animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {         
            if(animal != null)
            {
                Animals.Add(animal);
                return true;
            }
            return false;  
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            if (chipRegistrationNumber >= 0)
            {
                foreach (Animal a in Animals)
                {
                    if (a.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        Animals.Remove(a);
                        return true;
                    }
                }
            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in Animals)
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
            if (name != null)
            {
                foreach (Animal a in Animals)
                {
                    if (a.Name == name)
                    {
                        return a;
                    }
                }
            }
            return null;
        }

        public bool CheckChipNrIsAvailable(int nr)
        {
            if (nr < 0) return false;

            foreach (Animal a in Animals)
            {
                if (a.ChipRegistrationNumber == nr)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddOrRemoveReservation(int chipNr)
        {
            Animal animal = FindAnimal(chipNr);
            Animals.Remove(animal);
            if (animal.IsReserved == true)
            {
                animal.IsReserved = false;
            }
            else animal.IsReserved = true;

            Animals.Add(animal);
        }

        public void Save(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            
            using (Stream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, Animals);
            }
        }

        public void Load(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                Animals = (List<Animal>)formatter.Deserialize(stream);
            }
        }

        public void Export(string fileName)
        {
            using (TextWriter textWriter = new StreamWriter(fileName))
            {
                foreach (Animal animal in Animals)
                {
                    textWriter.WriteLine(animal.ToString());
                }
                
            }
            
        }
    }
}
