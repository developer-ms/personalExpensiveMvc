using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalExpensiveMvc.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public Invoice Invoice { get; set; }

        public Expense(int id, string description, double value, DateTime date, Invoice invoice)
        {
            Id = id;
            Description = description;
            Value = value;
            Date = date;
            Invoice = invoice;
        }
    }
}
