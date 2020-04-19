using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int cant = 0, num = 0, sum = 0;

            //Requesting data from the user
            Console.Write(" Enter the number of numbers to be processed: ");
            cant = Convert.ToInt32(Console.ReadLine());

            //Calculated
            for (int i = 0; i < cant; i++)
            { 
                Console.Write(" Enter the one number: ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            //Showing results
            Console.Write(" The sum of all numbers is: {0}", sum);

            Console.ReadKey();
        }
    }
}
