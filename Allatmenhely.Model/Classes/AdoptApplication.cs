using Allatmenhely.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Allatmenhely.Model.Classes
{
    internal class AdoptApplication
    {
        private int id;
        private DateTime applicationDate;
        private ApplicationStatus status;
        private Adopter adopter;
        private Animal animal;

        public AdoptApplication(int id, DateTime applicationDate, ApplicationStatus status, Adopter adopter, Animal animal)
        {
            this.id = id;
            this.applicationDate = applicationDate;
            this.status = status;
            this.adopter = adopter;
            this.animal = animal;
        }

        public int Id { get => id; set => id = value; }
        public DateTime ApplicationDate { get => applicationDate; set => applicationDate = value; }
        internal ApplicationStatus Status { get => status; set => status = value; }
        internal Adopter Adopter { get => adopter; set => adopter = value; }
        internal Animal Animal { get => animal; set => animal = value; }

        public string toString()
        {
            return $"ID: {id}, Application Date: {applicationDate.ToShortDateString()}, Status: {status}, Adopter: {adopter.Name}, Animal: {animal.Name}";
        }
    }
}
