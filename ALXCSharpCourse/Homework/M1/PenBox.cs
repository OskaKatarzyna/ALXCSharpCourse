using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class PenBox
    {
        public string Company { get; set; }
        public Color Color { get; set; }
        public Pencil Pencil1 { get; set; }
        public Pencil Pencil2 { get; set; }
        public Crayon Crayon1 { get; set; }
        public Crayon Crayon2 { get; set; }
        public Crayon Crayon3 { get; set; }

        public PenBox(string company, Color color, Pencil pencil1, Pencil pencil2, Crayon crayon1, Crayon crayon2, Crayon crayon3)
        {
            Company = company;
            Color = color;
            Pencil1 = pencil1;
            Pencil2 = pencil2;
            Crayon1 = crayon1;
            Crayon2 = crayon2;
            Crayon3 = crayon3;
        }

        public void About()
        {
            Console.WriteLine($"Jestem piórnik firmy {Company} koloru {Color}");
            Console.WriteLine("Mam w sobie następujące elementy:");
            Pencil1.About();
            Pencil2.About();
            Crayon1.About();
            Crayon2.About();
            Crayon3.About();
        }
    }
}
