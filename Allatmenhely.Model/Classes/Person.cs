using System;
using System.Collections.Generic;
using System.Text;

namespace Allatmenhely.Model.Classes
{
    internal abstract class Person
    {
        protected int id;
        protected string name;

        protected Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public string toString()
        {
            return $"ID: {id}, Name: {name}";
        }
    }
}
