using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class ConditionalsDemo
    {
        public static void Run()
        {
            int number = 15;

            /*if (number>15)
            {
                Console.WriteLine($"The number {number} is greater then 15");
            }
            else
            {
                Console.WriteLine($"The number {number} is smaller or equal then 15");
            }*/

            if (number > 15)
            {
                Console.WriteLine($"The number {number} is greater then 15");
            }
            else if (number == 15)
            {
                Console.WriteLine($"The number {number} is equal to 15");
            }
            else if (number == 3)
            {
                Console.WriteLine($"The number {number} is equal to 3");
            }
            else
            {
                Console.WriteLine($"The number {number} is smaller then 15");
            }
        }

        public static void RunNumberApp()
        {
            Console.Write("Number app\nEnter number ");
            int number;
            bool succeded = Int32.TryParse(Console.ReadLine(), out number);
            //int number = Convert.ToInt32(Console.ReadLine());
            if (succeded)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Number {number} is even");
                }
                else
                {
                    Console.WriteLine($"Number {number} is odd");
                }
            }
            else
            {
                Console.WriteLine("The given imput is ot a number");
            }
        }
    }
}
