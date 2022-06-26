using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class Computer
    {
        public string Procesor { get; set; }
        public int Ram { get; set; }
        public double Clocking { get; set; }
        public string System { get; set; }
        public Computer(string procesor, int ram, double clocking, string system)
        {
            Procesor = procesor;
            Ram = ram;
            Clocking = clocking;
            System = system;
        }   
        
        public void About()
        {
            Console.WriteLine($"I am computer.\nMy procesor {Procesor} {Clocking} GHz.\nMy RAM {Ram} GB.\nMy system {System}."); 
        }
    }
}
