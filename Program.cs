using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Bioskop bioskop;  
            bioskop = new Endgame();
            bioskop.film();

            Console.WriteLine();
            bioskop = new Justice();
            bioskop.film();

            Console.WriteLine();
            bioskop = new Avenger();
            bioskop.film();

            Console.ReadKey();
        }
    }
}
