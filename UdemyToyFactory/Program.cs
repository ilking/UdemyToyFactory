using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyCreator factory = null;

            Console.WriteLine("Creating new firetruck...");
            factory = new FiretruckCreator();
            factory.MakeToy();
            Console.WriteLine();

            Console.WriteLine("Creating new duck...");
            factory = new DuckCreator();
            factory.MakeToy();
            Console.WriteLine();

            Console.WriteLine("Creating new superman...");
            factory = new SupermanCreator();
            factory.MakeToy();
            Console.WriteLine();
        }
    }
}
