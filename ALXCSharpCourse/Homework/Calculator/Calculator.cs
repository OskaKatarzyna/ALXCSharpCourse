using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.Calculator
{
    public class Calculator
    {
        public double X { get; set; }
        public double Y { get; set; }  
        public double Result{ get; set; }
        public Sign Sign { get; set; }

        public Calculator(double x, double y, double result, Sign sign)
        {
            X = x;
            Y = y;
            Result = result;
            Sign = sign;
        }

        /*public Calculator()
        {
            Console.WriteLine("It's yor calculator. What do You want to calc?");
            bool succeded = Double.TryParse(Console.ReadLine(), out X);
            if (succeded)
            {
                succeded = Double.TryParse(Console.ReadLine(), out X);
                //Console.ReadKey
            }
            else 
            {
                Console.WriteLine("You entered an incorrect operation");
            }
        }*/
    }
}
