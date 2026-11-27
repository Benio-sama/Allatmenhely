using Allatmenhely.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Allatmenhely.Model.Classes
{
    internal class Kennel
    {
        private int id;
        private AnimalType animaltype;
        private int capacity;
        private bool isActive;
        private List<Animal> animals;

        public Kennel(int id, AnimalType animaltype, int capacity, bool isActive, List<Animal> animals)
        {
            this.id = id;
            this.animaltype = animaltype;
            this.capacity = capacity;
            this.isActive = isActive;
            this.animals = animals;
        }

        public int Id { get => id; set => id = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        internal AnimalType Animaltype { get => animaltype; set => animaltype = value; }
        public List<Animal> Animals { get => animals; set => animals = value; }

        public string toString()
        {
            return $"ID: {id}, Type: {animaltype}, Capacity: {capacity}, Active: {isActive}, Animals: {animals.Count}";
        }
    }
}
