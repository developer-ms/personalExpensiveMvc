using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalExpensiveMvc.Models
{
    public class CreditCard : Card
    {
        public DateTime DueDate { get; set; }
        public double Limit { get; set; }


        public CreditCard(DateTime dueDate, double limit, int id, string number , Holder holder) : base(id, number, holder)
        {
            DueDate = dueDate;
            Limit = limit;
        }
    }
}
