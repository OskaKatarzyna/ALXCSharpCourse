using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class VariablesDemo
    {
        public static void Run()
        {
            //Console.WriteLine("Variables demo");
            int number = 10;
            bool booleanValue = true;
            bool booleanValue1 = false;
            //string name = "Kasia";
            double number2 = 0.22;
            float number3 = (float)number2;


            //Console.WriteLine(name);
            /*Console.WriteLine(1);
            Console.WriteLine(booleanValue);
            Console.WriteLine(number2);
            Console.WriteLine(number3);*/

            
            Console.WriteLine("Personal data");
            //name
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            //last name
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            //phone number
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            //height
            Console.Write("Enter Your high: ");
            double high = Convert.ToDouble( Console.ReadLine());
            //adress
            Console.Write("Enter streat name: ");
            string streetName = Console.ReadLine();
            Console.Write("Enter building number: ");
            string buildingNumber = Console.ReadLine();
            Console.Write("Enter flat number: ");
            string flatNumber = Console.ReadLine();
            Console.Write("Enter postal code: ");
            string postalCode = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Your data:");
            Console.WriteLine();
            Console.WriteLine(name + " " + lastName);
            Console.WriteLine("phone:" + phoneNumber);
            //Console.WriteLine("Ul."+streetName +" "+ buildingNumber+"/" + flatNumber +" "+ postalCode +" "+ city);
            string adress = $"Ul.{streetName} {buildingNumber}/{flatNumber} {postalCode} {city}";
            Console.WriteLine(adress); 
        }

        public static void RunCalculator()
        {
            Console.WriteLine("Console calculator: ");
            Console.Write("Enter x number: ");
            int x= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {Convert.ToDouble(x)/Convert.ToDouble(y)}");
            Console.WriteLine($"{x} modulo {y} = {x % y}");


        }

        public static void RunLogicCalculator()
        {
            Console.WriteLine("Console logic calculator: ");
            Console.Write("Enter x number: ");
            bool x = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter y number: ");
            bool y = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{x} AND {y} = {x && y}");
            Console.WriteLine($"{x} OR {y} = {x || y}");
            Console.WriteLine($"{x} XOR {y} = {x ^ y}");


        }
    }

}
