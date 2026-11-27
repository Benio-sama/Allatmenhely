using System;
using System.Collections.Generic;
using System.Text;

namespace Allatmenhely.Model.Classes
{
    internal class Sector
    {
        private int id;
        private string name;
        private bool isActive;
        private List<Kennel> kennels;

        public Sector(int id, string name, bool isActive, List<Kennel> kennels)
        {
            this.id = id;
            this.name = name;
            this.isActive = isActive;
            this.kennels = kennels;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public List<Kennel> Kennels { get => kennels; set => kennels = value; }

        public string toString()
        {
            return $"ID: {id}, Name: {name}, Active: {isActive}, Kennels: {kennels.Count}";
        }
    }
}
