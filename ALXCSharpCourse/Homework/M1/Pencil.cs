using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class Pencil
    {
        public string Company { get; set; }
        public Hardness Hardness { get; set; }
        public int Lenght { get; set; }

        public Pencil(string company, Hardness hardness, int lenght)
        {
            Company = company;
            Hardness = hardness;
            Lenght = lenght;
        }

        public void Temper(int time)
        {
            Lenght = Lenght - time;
        }

        public void Write()
        {
            Console.WriteLine($"Kreślę z twardością {Hardness}");
        }

        public void About()
        {
            
            Console.WriteLine($"Jestem ołówek firmy {Company}, twardości {Hardness}, zostało mnie na {Lenght} temperowań");
        }
    }
}

