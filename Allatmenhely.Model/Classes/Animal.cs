using Allatmenhely.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Allatmenhely.Model.Classes
{
    internal class Animal
    {
        private int id;
        private string name;
        private AnimalType animaltype;
        private string breed;
        private int age;
        private AnimalGender gender;
        private DateTime arrivalDate;
        private AnimalStatus status;
        private DateTime adoptionDate;
        private List<HealthRecord> healthRecords;

        public Animal(int id, string name, AnimalType animalType, string breed, int age, AnimalGender animalGender, DateTime arrivalDate, AnimalStatus status, DateTime adoptionDate, List<HealthRecord> healthRecords)
        {
            this.id = id;
            this.name = name;
            this.animaltype = animalType;
            this.breed = breed;
            this.age = age;
            this.gender = animalGender;
            this.arrivalDate = arrivalDate;
            this.status = status;
            this.adoptionDate = adoptionDate;
            this.healthRecords = healthRecords;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Breed { get => breed; set => breed = value; }
        public int Age { get => age; set => age = value; }
        public DateTime ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
        public DateTime AdoptionDate { get => adoptionDate; set => adoptionDate = value; }
        internal AnimalType Animaltype { get => animaltype; set => animaltype = value; }
        internal AnimalGender Gender { get => gender; set => gender = value; }
        internal AnimalStatus Status { get => status; set => status = value; }
        public List<HealthRecord> HealthRecords { get => healthRecords; set => healthRecords = value; }

        public string toString()
        {
            return $"ID: {id}, Name: {name}, Type: {Animaltype}, Breed: {breed}, Age: {age}, Gender: {gender}, Arrival Date: {arrivalDate.ToShortDateString()}, Status: {status}, Adoption Date: {(adoptionDate == DateTime.MinValue ? "N/A" : adoptionDate.ToShortDateString())}, Health Records: {healthRecords.Count}";
        }
    }
}
