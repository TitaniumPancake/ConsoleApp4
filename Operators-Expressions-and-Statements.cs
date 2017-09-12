using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b;

            // Assignment Operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //this operator just assigns a, in this case, numerical
            //value to the given symbol (x,y,a,b)

            // there are many mathmatical operators

            //addition operators
            x = 3 + 4;

            //subtraction operator
            x = 4 - 3;

            //Multiplication operator
            x = 10 * 5;

            //Divison Operator
            x = 10 / 5;

            
            //these operators just calculate numerical math
            //problems and then use the end result to define
            //the given symbol
            //There are many operators used to evaluate values...

            //equality operator
            if (x == y)
            {
            }

            //greater than operator
            if (x > y)
            {
            }

            //less than operator
            if (x < y)
            {
            }

            //greater than or eqaul to
            if (x >= y)
            {
            }

            // less than or equal to
            if (x <= y)
            {
            }



            //There are 2 conditional operators as well that can be used to expand / enhance an evaluation
            //... and they can be combined together multiple times.

            //conditional AND operator
            if ((x > y) && (a > b))
            {
            }

            //conditional OR operator
            if ((x > y) || (a > b))
            {
            }

            //these evaluate the input based on its numerical value and then react
            //based on that value
            //same goes for all above "if"operators
            //the code within the brackets is executed if the
            //input matches the criteria for that operator


            // Also, here's the in-line conditional operator
            string message = (x == 1) ? "Car" : "Boat";

            //member access and Method invocation
            Console.WriteLine("Hi");

            x + y;

        }
    }
}
