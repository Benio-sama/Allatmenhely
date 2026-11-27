using System;
using System.Collections.Generic;
using System.Text;

namespace Allatmenhely.Model.Classes
{
    internal class Adopter : Person
    {
        private string email;
        private string phone;

        public Adopter(int id, string name, string email, string phone) : base(id, name)
        {
            this.email = email;
            this.phone = phone;
        }

        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        public new string toString()
        {
            return $"{base.toString()}, Email: {email}, Phone: {phone}";
        }
    }
}
