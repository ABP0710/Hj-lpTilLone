﻿using HjælpTilLone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpTilLone.Classes
{
    public class Knight : Character, IBash, ICleave, IRaiseShield, IShieldGlare, ISlash
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }
        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}
