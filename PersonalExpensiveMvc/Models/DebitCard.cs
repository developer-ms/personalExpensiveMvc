using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalExpensiveMvc.Models
{
    public class DebitCard : Card
    {
        public DebitCard(int id, string number, Holder holder) : base(id, number, holder)
        {
        }
    }
}
