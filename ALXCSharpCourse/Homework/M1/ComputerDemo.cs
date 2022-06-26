using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class ComputerDemo
    {
        public static void Run()
        {
            Computer computer = new Computer
            (
                "Intel Core i7",
                16,
                4.0,
                "Windows 10 Pro"
            );

            computer.About();
              
        }
    }
}
