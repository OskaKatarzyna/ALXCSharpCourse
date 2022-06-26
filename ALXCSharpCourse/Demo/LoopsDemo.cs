using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class LoopsDemo
    {
        public static void Run()
        {
            int[] digitArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var sum1 = 0;
            Console.WriteLine("\nForeach..");
            foreach (int digit in digitArray)
            {
                sum1=sum1+digit;
                Console.WriteLine($"Suma cyfr: {sum1}");
            }

            Console.WriteLine("\nFor..");

            var sum = 0;
            for(int i = 0; i < digitArray.Length; i++)
            {
                sum=sum+digitArray[i];
                Console.WriteLine($"Suma cyfr: {sum}");
            }

            sum1 = 0;

            Console.WriteLine("\nFor do 40...");
            for (int i = 0; sum1+digitArray[i] < 40; i++)
           
            {
                sum1 = sum1 + digitArray[i];
                Console.WriteLine($"Suma cyfr: {sum1}");
            }

            sum1 = 0;
            var iterator = 0;
            Console.WriteLine("\nWhile do 20...");
            while (sum1 + digitArray[iterator] < 20)
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Suma cyfr: {sum1}");
                iterator++;
            }

            sum1 = 0;
            iterator = 0;
            Console.WriteLine("\nDo while do 20...");
            do
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Suma cyfr: {sum1}");
                iterator++;
            }
            while (sum1 + digitArray[iterator] < 20);


        }
    }
}
