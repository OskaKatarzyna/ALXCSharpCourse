using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class CrayonDemo
    {
        public static void Run()
        {
            Crayon crayon1 = new Crayon
                (
                "Crayola",
                Color.RED,
                20
                );

            Console.WriteLine("------------------------------------------------------");
            crayon1.About();
            crayon1.Write();
            Console.Write("Ile mnie temperujesz: ");
            crayon1.Temper(Convert.ToInt32(Console.ReadLine()));
            crayon1.About();
            Console.WriteLine("------------------------------------------------------");

            Crayon crayon2 = new Crayon
                (
                "Astra",
                Color.BLUE,
                30
                );

            Console.WriteLine("------------------------------------------------------");
            crayon2.About();
            crayon2.Write();
            Console.Write("Ile mnie temperujesz: ");
            crayon2.Temper(Convert.ToInt32(Console.ReadLine()));
            crayon2.About();
            Console.WriteLine("------------------------------------------------------");
        }

        
    }
}
