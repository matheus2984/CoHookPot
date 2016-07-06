using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoHookPot
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoPot = new AutoPot();
            autoPot.AutoPotThread();
            Console.ReadKey();
        }
    }
}
