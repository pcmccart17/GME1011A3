using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GME1011A3;

namespace HeroInheritance
{
    internal class Dragon : Minion
    {
        public Dragon(int health, int armour) : base(health, armour) { }
        
        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(4, 10);
        }

        public int Burn()
        {
            Console.WriteLine("**The dragon breathes fire!**");
            Random rng = new Random();
            return rng.Next(8, 16);
        }
      

    }
}
