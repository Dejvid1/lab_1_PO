using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Severity Severity { get; set; }
        public decimal Cost { get; set; }

        public Ticket(int id, string description, Severity severity, decimal cost = 0m)
        {
            Id = id;
            Description = description;
            Severity = severity;
            Cost = cost;
        }
    }
}
public enum Severity
{
    Low,
    Medium,
    High
}