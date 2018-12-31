using PersonalExpensiveMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalExpensiveMvc.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public InvoiceStatus Status { get; set; }
        public Card Card { get; set; }
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();


        public Invoice(int id, InvoiceStatus status, Card card)
        {
            Id = id;
            Status = status;
            Card = card;
        }

        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }

        public void RemoveExpense(Expense expense)
        {
            Expenses.Remove(expense);
        }

        public double TotalInvoice(DateTime dateOpen, DateTime dateClosed)
        {
            return 0.0;
        }

    }
}
