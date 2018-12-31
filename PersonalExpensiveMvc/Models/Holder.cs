using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalExpensiveMvc.Models
{
    public class Holder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Card> Cards { get; set; } = new List<Card>();

        public Holder()
        {
        }

        public Holder(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddCard(Card card)
        {
        }

        public void RemoveCard(Card card)
        {
        }
    }
}
