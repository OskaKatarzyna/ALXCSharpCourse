﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.Calculator
{
    public class CalculatorMultiArgumentDouble
    {
        public bool NumberBool;
        public bool SignBool;
        public int DecimalPosition; // 0 for int;
        List<Element> Elements;
        Element CurrentElement;
        public double Result;

        public CalculatorMultiArgumentDouble()
        {
            NumberBool = true;
            SignBool = false;
            DecimalPosition = 0;
            Result = 0;
            Elements = new List<Element>(); 
            CurrentElement = new Element();
        }
        public void Run()
        {
            ConsoleKeyInfo cki;
            TellAboutYourself();
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) 
                    break;
                if (NumberBool)
                    ReadNumber(cki);
                if (SignBool && ReadSign(cki))
                    continue;
                if(!(NumberBool  || SignBool ))
                {
                    Console.WriteLine("\nIncorrect operation format");
                    NumberBool = true;
                    SignBool = false;
                    CurrentElement.Clear();
                    Elements.Clear();
                }
            } while(true);
        }
        public void ReadNumber(ConsoleKeyInfo cki)
        {
            int x;
            //minus before the first number
            if (Elements.Count == 0 && CurrentElement.TypeOfElement == TypeOfElement.NULL && cki.KeyChar.ToString() == "-")
            {
                CurrentElement.TypeOfElement = TypeOfElement.NUMBER;
                CurrentElement.Value = -1;
                AddCopyOfCurrentElementToElements();
                CurrentElement.TypeOfElement = TypeOfElement.SIGN;
                CurrentElement.Sign = Sign.MULT;
                AddCopyOfCurrentElementToElements();
            }
            else if (CurrentElement.TypeOfElement == TypeOfElement.NUMBER && DecimalPosition == 0 && cki.KeyChar.ToString() == ",") // the first occurrence of a comma
            {
                DecimalPosition = -1;
            }
            else if (Int32.TryParse(cki.KeyChar.ToString(), out x))
            {
                CurrentElement.TypeOfElement = TypeOfElement.NUMBER;
                if (DecimalPosition == 0)
                {
                    CurrentElement.Value = CurrentElement.Value * 10 + x;
                }
                else if(DecimalPosition <0)
                {
                    CurrentElement.Value = CurrentElement.Value + x * (Math.Pow(10, DecimalPosition));
                    DecimalPosition--;
                }
            }
            else
            {
                NumberBool = false;
                if (CurrentElement.TypeOfElement == TypeOfElement.NUMBER)
                {
                    SignBool = true;
                    AddCopyOfCurrentElementToElements();
                }
            }
        }
        public bool ReadSign(ConsoleKeyInfo cki)
        {
                 
            NumberBool = true;
            SignBool = false;
            DecimalPosition = 0;
            CurrentElement.TypeOfElement = TypeOfElement.SIGN;
            if (cki.KeyChar.ToString() == "+")
            {
                CurrentElement.Sign=Sign.PLUS;
                AddCopyOfCurrentElementToElements();
                return true;
            } else if (cki.KeyChar.ToString() == "-")
            {
                CurrentElement.Sign = Sign.MINUS;
                AddCopyOfCurrentElementToElements();        
                return true;
            } else if (cki.KeyChar.ToString() == "*")
            {
                CurrentElement.Sign = Sign.MULT;
                AddCopyOfCurrentElementToElements();
                return true;
            }
            else if (cki.KeyChar.ToString() == "/")
            {
                CurrentElement.Sign = Sign.DIV;
                AddCopyOfCurrentElementToElements();
                return true;
            }
            else if (cki.KeyChar.ToString() == "%")
            {
                CurrentElement.Sign = Sign.MOD;
                AddCopyOfCurrentElementToElements();
                return true;
             }
            else if (cki.KeyChar.ToString() == "=")
            {
                //currentElement.TypeOfElement = TypeOfElement.EQUAL;
                //AddCopyOfCurrentElementToElements();
                CurrentElement.TypeOfElement = TypeOfElement.NULL;
                NumberBool = true;
                SignBool = false;
                //PrintElements();
                if (Count())
                    Console.Write(Result);
                Console.WriteLine();
                //PrintElements();
                Elements.Clear();
                return true;
            }
            else
            {
                CurrentElement.TypeOfElement = TypeOfElement.NULL;
                NumberBool = false;
                return false;
            }
        }
        public bool Count()
        {
            bool succed = true;
            succed=CountMultipicationsAndDivisions();
            if (succed)
            {
                succed = CountAllFromLeft();
                Result = Elements[0].Value;
            }
            return succed;
        }
        public bool CountMultipicationsAndDivisions()
        {
            Element find = new Element();
            int index;
            bool succed = true;
            do
            {
                index = Elements.FindIndex(0, Elements.Count - 1, find.MultiplicationOrDivision);
                if (index < 0)
                    break;
                succed = MergeElementsArroundIndex(index);
            } while (index > 0 && succed);
            return succed; 
        }
        public bool CountAllFromLeft()
        {
            bool succed = true;
            double value;
            while(Elements.Count > 1)
            {
                succed = MergeElementsArroundIndex(1);
            }
            return succed;
        }
        public void AddCopyOfCurrentElementToElements()
        {
            Element newElement = new Element();
            newElement.Copy(CurrentElement);
            Elements.Add(newElement);
            CurrentElement.Clear();
        }
        public bool MergeElementsArroundIndex(int index)
        {
            double value;
            switch (Elements[index].Sign)
            {
                case Sign.PLUS:
                    {
                        value = Elements[index - 1].Value + Elements[index + 1].Value;
                        break;
                    }
                case Sign.MINUS:
                    {
                        value = Elements[index - 1].Value - Elements[index + 1].Value;
                        break;
                    }
                case Sign.MULT:
                    {
                        value = Elements[index - 1].Value * Elements[index + 1].Value;
                        break;
                    }
                case Sign.DIV:
                    {
                        if (Elements[index + 1].Value == 0)
                        {
                            Console.WriteLine("\nDon't divide by zero!");
                            return false;
                        }
                        else
                        {
                            value = Elements[index - 1].Value / Elements[index + 1].Value;
                        }
                        break;
                    }
                case Sign.MOD:
                    {
                        if (Elements[index + 1].Value == 0)
                        {
                            Console.WriteLine("\nDon't divide by zero!");
                            return false;
                        }
                        else
                        {
                            value = Elements[index - 1].Value % Elements[index + 1].Value;
                        }
                        break;
                    }
                default:
                    return false;
            }
            Elements.RemoveAt(index + 1);
            Elements.RemoveAt(index);
            Elements[index - 1].Value = value;
            Elements[index - 1].TypeOfElement = TypeOfElement.NUMBER;
            return true;
        }
        public void PrintElements()
        {
            Console.WriteLine("\n---------------------------------");
            foreach (Element elementAuxiliary in Elements)
                elementAuxiliary.Print();
            Console.WriteLine("\n---------------------------------");
        }
        public void PrintSimplyElements()
        {
            foreach (Element elementAuxiliary in Elements)
                elementAuxiliary.PrintSimply();
        }
        public void PrintAll()
        {
            
            Console.WriteLine("*********************************************");
            Console.WriteLine($" NumberBool={NumberBool}");
            Console.WriteLine($" SignBool={SignBool}");
            Console.WriteLine($" DecimalPosition={DecimalPosition}");
            //Console.WriteLine($" 10^DecimalPosition={10^DecimalPosition}");
            //PrintElements();
            PrintSimplyElements();
            CurrentElement.Print();
            Console.WriteLine($"*********************************************\n>>");

        }
        public void TellAboutYourself()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("\nIt's yor multi - arguments calculator.");
            Console.WriteLine("You can enter fractions separated by a comma.");
            Console.WriteLine("Possible actions: +, -, *, /, %");
            Console.WriteLine("Enter {x1} {operation} {y2}... = or press q to escape.");
            Console.WriteLine("\n******************************************************************\n\n");
        }
    }
}
