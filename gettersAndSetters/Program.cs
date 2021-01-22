using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Johh Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // Movies can only have specific ratings: G, PG, PG-13, R, NR

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
