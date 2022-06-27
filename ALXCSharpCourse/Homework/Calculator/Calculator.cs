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

        public Calculator()
        {
            /*Console.WriteLine("It's yor calculator. What do You want to calc?");
            Console.WriteLine("Press q to escape.");
            bool succeded = Double.TryParse(Console.ReadLine(), out X);
            if (succeded)
            {
                succeded = Double.TryParse(Console.ReadLine(), out X);
                //Console.ReadKey
            }
            else 
            {
                Console.WriteLine("You entered an incorrect operation");
            }*/
        }
        

        public void Run()
        {
            //ConsoleKeyInfo number1List = new List<ConsoleKeyInfo>();
            //ConsoleKeyInfo number2;
            ConsoleKeyInfo equal;
            ConsoleKeyInfo cki;
            int number1 = 0;
            int number2 = 0;
            bool number1Bool = true;
            bool signBool = false;
            bool number2Bool = false;
            bool equalBool = false;
            Console.WriteLine("\nIt's yor calculator. What do You want to calc?");
            Console.WriteLine("Enter {x} {operation} {y} = or press q to escape.");
            do
            {

                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) 
                    break;
                if (number1Bool)
                {
                    int x;
                    if (Int32.TryParse(cki.KeyChar.ToString(), out x))
                        number1 = number1 * 10 + x;
                    else
                    {
                        number1Bool=false;
                        signBool=true;
                    }                      
                }  
                if (signBool)
                {
                    Console.Write("sign");
                    if (cki.KeyChar.ToString() == "+")
                    {
                        number2Bool = true;
                        signBool = false;
                        break;
                        //Console.Write("+");

                    }
                    else
                    {
                        signBool = false;
                    }
                } 
                if (number2Bool)
                {
                    //Console.Write("n");
                    int x;
                    if (Int32.TryParse(cki.KeyChar.ToString(), out x))
                    {
                        number2 = number2 * 10 + x;
                        //Console.Write("s2");
                    }
                    else
                    {
                        number2Bool = false;
                    }
                }
                if (equalBool)
                {
                    if (cki.KeyChar.ToString() == "=")
                        Console.Write($" {number1 + number2}");
                    else
                        equalBool = false;
                }
                if(!(number2Bool || number1Bool || signBool || equalBool))
                {
                    Console.WriteLine("\nIncorrect operation format . Enter {x} {operation} {y} =");
                    Console.WriteLine($"\nnumber1 = {number1} number2 = {number2}");
                    Console.WriteLine($"number2Bool = {number2Bool} number1Bool = {number1Bool} signBool = {signBool} equalBool = {equalBool}");
                    number1Bool = true;
                    signBool = false;
                    number2Bool = false;
                    equalBool = false;
                    number1 = 0;
                    number2 = 0;
                }


                /*number2 = Console.ReadKey();
                if (number1.Key == ConsoleKey.Q)
                    break;
                equal = Console.ReadKey();
                if (equal.Key == ConsoleKey.Q)
                    break;
                else if(equal.Key != ConsoleKey.OemPlus)
                    Console.WriteLine("Incorrect operation format. Enter {x} {operatio} {y} =");*/

            } while(true);
            Console.WriteLine($"\nnumber1 = {number1} number2 = {number2}");



        }
    }
}
