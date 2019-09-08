using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello! It's game !Questionare!. Would you like to start (type yes)? ");
            var answer = Console.ReadLine();
            if ((answer == "yes") | (answer == "Yes"))
            {
                var G = new Game();
                G.Run(); 
            }
            else
            {
                Console.WriteLine("Ok! We come back soon! Press any key for exit");
                Console.ReadKey();

            }
            

        }
    }
}
