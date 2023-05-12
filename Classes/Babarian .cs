using HjælpTilLone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpTilLone.Classes
{
    public class Babarian : Character, IBash, ICleave, ISlash
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }
        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}
