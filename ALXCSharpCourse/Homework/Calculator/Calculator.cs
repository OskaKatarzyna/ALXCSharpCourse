using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.Calculator
{
    public class Calculator
    {
        public bool number1Bool;
        public bool signBool;
        public bool number2Bool;
        public bool equalBool;
        public Operation operation;

        public Calculator()
        {
            number1Bool = true;
            signBool = false;
            number2Bool = false;
            equalBool = false;
            operation = new Operation();
    }
        

        public void Run()
        {
            ConsoleKeyInfo equal;
            ConsoleKeyInfo cki;
            Console.WriteLine("\nIt's yor calculator. What do You want to calc?");
            Console.WriteLine("Enter {x} {operation} {y} = or press q to escape.");
            Console.WriteLine($"\nnumber1 = {operation.X} number2 = {operation.Y}");
            do
            {
                //Console.Write("petla");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) 
                    break;
                if (number1Bool)
                {
                    int x;
                    if (Int32.TryParse(cki.KeyChar.ToString(), out x))
                    {
                        operation.X = operation.X * 10 + x;
                    }
                    else
                    {
                        number1Bool = false;
                        signBool = true;
                    }                      
                }  
                if (signBool)
                {
                    number2Bool = true;
                    signBool = false;
                    if (cki.KeyChar.ToString() == "+")
                    {
                        operation.Sign = Sign.PLUS;
                        continue;
                    } else if (cki.KeyChar.ToString() == "-")
                    {
                        operation.Sign = Sign.MINUS;
                        continue;
                    } else if (cki.KeyChar.ToString() == "*")
                    {
                        operation.Sign = Sign.MULT;
                        continue;
                    }
                    else if (cki.KeyChar.ToString() == "/")
                    {
                        operation.Sign = Sign.DIV;
                        continue;
                    }
                    if (cki.KeyChar.ToString() == "%")
                    {
                        operation.Sign = Sign.MOD;
                        continue;
                    }

                    else
                    {
                        number2Bool = false;
                    }
                } 
                if (number2Bool)
                {
                    int y;
                    if (Int32.TryParse(cki.KeyChar.ToString(), out y))
                    {
                        operation.Y = operation.Y * 10 + y;
                    }
                    else
                    {
                        number2Bool = false;
                        equalBool = true;
                    }
                }
                if (equalBool)
                {
                    if (cki.KeyChar.ToString() == "=")
                    {
                        switch (operation.Sign)
                        {
                            case Sign.PLUS:
                                operation.Result = operation.X + operation.Y;
                                break;
                            case Sign.MINUS:
                                operation.Result = operation.X - operation.Y;
                                break;
                            case Sign.MULT:
                                operation.Result = operation.X * operation.Y;
                                break;
                            case Sign.DIV:
                                operation.Result = operation.X / operation.Y;
                                break;
                            case Sign.MOD:
                                operation.Result = operation.X % operation.Y;
                                break;
                        }
                        Console.Write($"{operation.Result}\n");
                        //Console.WriteLine($"\nnumber1 = {operation.X} number2 = {operation.Y}");
                        number1Bool = true;
                        signBool = false;
                        number2Bool = false;
                        equalBool = false;
                        operation.X = 0;
                        operation.Y = 0;
                        operation.Result = 0;
                    }
                    else
                        equalBool = false;
                }
                if(!(number2Bool || number1Bool || signBool || equalBool))
                {
                    Console.WriteLine("\nIncorrect operation format . Enter {x} {operation} {y} =");
                    number1Bool = true;
                    signBool = false;
                    number2Bool = false;
                    equalBool = false;
                    operation.X = 0;
                    operation.Y = 0;
                    operation.Result = 0;
                }
            } while(true);
        }
    }
}
