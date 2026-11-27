using System;
using System.Collections.Generic;
using System.Text;

namespace Allatmenhely.Model.Classes
{
    internal class HealthRecord
    {
        private int id;
        private DateTime date;
        private string type;
        private string performedBy;

        public HealthRecord(int id, DateTime date, string type, string performedBy)
        {
            this.id = id;
            this.date = date;
            this.type = type;
            this.performedBy = performedBy;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Type { get => type; set => type = value; }
        public string PerformedBy { get => performedBy; set => performedBy = value; }

        public string toString()
        {
            return $"ID: {id}, Date: {date.ToShortDateString()}, Type: {type}, Performed By: {performedBy}";
        }   
    }
}
