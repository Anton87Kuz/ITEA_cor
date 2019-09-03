using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            double var_x; // declaration of variable -- argument of functions

            Console.WriteLine("Evaluation of function y=sqrt(x^2+x-8) at point x.");
            Console.Write("Input x = ");

            var temp_var = Console.ReadLine();// reading input value and checking it correctness 
            while (!double.TryParse(temp_var, out var_x))
            {
                Console.Write("Uncorrect input! Try again! \nInput x = ");
                temp_var = Console.ReadLine();
            }

            var temp_value = var_x * var_x + var_x - 8; //evaluation of expression under square root, it must be bigger or equal to zero

            if (temp_value < 0) //checking of expression under root being below zero
            {
                Console.WriteLine("Function undefined at this value of x! Negative value under square root.");
            }
            else
            {
                Console.WriteLine("y = " + Math.Sqrt(temp_value));
            }
            //  evaluation of another function
            Console.WriteLine("Evaluation of function y=sin(x)+(7x+4)/(3x+6) at point x.");
            Console.Write("Input x = ");

            temp_var = Console.ReadLine();
            while (!double.TryParse(temp_var, out var_x))
            {
                Console.Write("Uncorrect input! Try again! \nInput x = ");
                temp_var = Console.ReadLine();
            }


            temp_value = 3 * var_x + 6; //evalution of expression in denominator, it must be nonzero
            if (temp_value == 0)// checking is denominator different from zero
            {
                Console.WriteLine("Division by zero!");
            }
            else
            {
                var var_y = (7 * var_x + 4) / temp_value + Math.Sin(var_x);
                Console.WriteLine("y = " + var_y);
            }

            Console.ReadKey();

        }
    }
}
