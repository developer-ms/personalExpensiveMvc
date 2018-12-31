using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalExpensiveMvc.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Holder Holder { get; set; }

        public Card(int id, string number, Holder holder)
        {
            Id = id;
            Number = number;
            Holder = holder;
        }
    }
}
