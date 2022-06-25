using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class FunctionsDemo
    {
        public static void Run()
        {
            Console.WriteLine("------ Functions Demo -----");
            WriteSentence();
            Console.WriteLine("\n----------\n");
            WriteSentence("Moje konkretne zdanie.");
            WriteSentence("Moje liczbowe zdanie", 4);
            WriteSentence("Moje liczbowe zdanie ze zwrotką", 2,0);
            int suma= AddNumbers(3, 4);
            Console.WriteLine(suma);
            string adress=FormatAdress("Jasna", "3", "12");
            Console.WriteLine(adress);
            Console.WriteLine(FormatAdress("Jasna", "3", "12"));

        }

        public static void WriteSentence()
        {
            Console.WriteLine("Nie podano zdania");
        }

        public static void WriteSentence(string sentence)
        //overload nazwy funkcji
        {
            Console.WriteLine(sentence);
        }

        public static void WriteSentence(string sentence, int number)
        //overload nazwy funkcji
        {
            Console.WriteLine($"{sentence} {number}");
        }

        public static int WriteSentence(string sentence, int number, int number2)
        //overload nazwy funkcji
        {
            Console.WriteLine($"{sentence} {number}");
            return 0;
        }

        public static int AddNumbers(int a, int b)
        //overload nazwy funkcji
        {
            return a+b;
        }

        public static string FormatAdress(string streatName, string buildingNumber, string flatNumber ) 
            //sygnatura funkcji: coZwraca Nazwa(argument);
        {
            return $"Ulica {streatName} {buildingNumber}/{flatNumber}"; 
        }
    }
}
