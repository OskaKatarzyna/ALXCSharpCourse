using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class PencilDemo
    {
        public static void Run()
        {
            Pencil pencil1 = new Pencil
                (
                "Crayola",
                Hardness.HB,
                20
                );

            Console.WriteLine("------------------------------------------------------");
            pencil1.About();
            pencil1.Write();
            Console.Write("Ile mnie temperujesz: ");
            pencil1.Temper(Convert.ToInt32(Console.ReadLine()));
            pencil1.About();
            Console.WriteLine("------------------------------------------------------");

            Pencil pencil2 = new Pencil
                (
                "Crayola",
                Hardness.H7,
                12
                );

            Console.WriteLine("------------------------------------------------------");
            pencil2.About();
            pencil2.Write();
            Console.Write("Ile mnie temperujesz: ");
            pencil2.Temper(Convert.ToInt32(Console.ReadLine()));
            pencil2.About();
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
