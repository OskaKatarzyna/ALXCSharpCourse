using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class Crayon
    {
        public string Company { get; set; }
        public Color Color { get; set; }
        public int Lenght { get; set; }

        public Crayon(string company, Color color, int lenght)
        {
            Company = company;
            Color = color;
            Lenght = lenght;
        }

        public void Temper(int time)
        {
            Lenght= Lenght-time;
        }

        public void Write()
        {
            Console.WriteLine($"Piszę w kolorze {Color}");
        }

        public void About()
        {
            Console.WriteLine($"Jestem kredka firmy {Company}, koloru {Color}, zostało mnie na {Lenght} temperowań");
        }
    }
}
