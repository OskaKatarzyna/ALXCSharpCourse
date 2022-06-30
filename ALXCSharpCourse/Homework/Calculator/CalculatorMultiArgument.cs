using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.Calculator
{
    public class CalculatorMultiArgument
    {
        public bool number1Bool;
        public bool signBool;
        public bool number2Bool;
        public bool equalBool;
        List<Element> elements = new List<Element>();



        public CalculatorMultiArgument()
        {
            number1Bool = true;
            signBool = false;
            number2Bool = false;
            equalBool = false;
            List<Element> elements = new List<Element>();
        }
        

        public void Run()
        {
            //List<Element> elements = new();
            ConsoleKeyInfo equal;
            ConsoleKeyInfo cki;
            Element element = new Element();
            Console.WriteLine("\nIt's yor calculator. What do You want to calc?");
            Console.WriteLine("Enter {x} {operation} {y} = or press q to escape.");
            do
            {
                //Console.Write("petla");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) 
                    break;
                if (number1Bool)
                {
                    element.TypeOfElement = TypeOfElement.NUMBER;
                    int x;
                    if (Int32.TryParse(cki.KeyChar.ToString(), out x))
                    {
                        element.Value = element.Value*10+x;
                    }
                    else
                    {
                        number1Bool = false;
                        signBool = true;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                        
                    }                      
                }  
                if (signBool)
                {
                    element.TypeOfElement = TypeOfElement.SIGN;
                    number2Bool = true;
                    signBool = false;
                    if (cki.KeyChar.ToString() == "+")
                    {
                        element.Sign=Sign.PLUS;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                        continue;
                    } else if (cki.KeyChar.ToString() == "-")
                    {
                        element.Sign = Sign.MINUS;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                        continue;
                    } else if (cki.KeyChar.ToString() == "*")
                    {
                        element.Sign = Sign.MULT;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                        continue;
                    }
                    else if (cki.KeyChar.ToString() == "/")
                    {
                        element.Sign = Sign.DIV;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                        continue;
                    }
                    if (cki.KeyChar.ToString() == "%")
                    {
                        element.Sign = Sign.MOD;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                        continue;
                    }
                    else
                    {
                        number2Bool = false;
                    }
                } 
                if (number2Bool)
                {
                    element.TypeOfElement = TypeOfElement.NUMBER;
                    int y;
                    if (Int32.TryParse(cki.KeyChar.ToString(), out y))
                    {
                        element.Value = element.Value * 10 + y;
                    }
                    else
                    {
                        number2Bool = false;
                        equalBool = true;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                    }
                }
                if (equalBool)
                {
                    if (cki.KeyChar.ToString() == "=")
                    {
                        element.TypeOfElement = TypeOfElement.EQUAL;
                        Element newElement = new Element();
                        newElement.Copy(element);
                        elements.Add(newElement);
                        element.Clear();
                        number1Bool = true;
                        signBool = false;
                        number2Bool = false;
                        equalBool = false;
                        foreach (Element elementAuxiliary in elements)
                            elementAuxiliary.Print();
                        Count();
                        elements.Clear();
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
                    element.Clear();
                }
            } while(true);
        }

        public double Count()
        {
            double count = 0;
            Element find = new Element();
            int index = elements.FindIndex(0, elements.Count-1, find.MultiplicationOrDivision);
            Console.WriteLine($"Mnożenie lub dzielenie na pozycji {index}");
            return 0;
        }
    }
}
