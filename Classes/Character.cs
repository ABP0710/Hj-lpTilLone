using HjælpTilLone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpTilLone.Classes
{
    public abstract class Character : IHeal, IDie, IFight
    {
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
    }
}
