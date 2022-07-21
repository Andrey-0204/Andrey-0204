using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine(rand.Next(0,99));
        }
    }
}
