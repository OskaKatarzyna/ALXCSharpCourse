using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class PenBoxDemo
    {
        public static void Run()
        {
            

            Pencil pencil1 = new Pencil
                (
                "Crayola",
                Hardness.HB,
                20
                );

            Pencil pencil2 = new Pencil
                (
                "Kogucik",
                Hardness.H7,
                12
                );

            Crayon crayon1 = new Crayon
                (
                "Crayola",
                Color.RED,
                20
                );

            Crayon crayon2 = new Crayon
                (
                "Astra",
                Color.BLUE,
                30
                );

            Crayon crayon3 = new Crayon
                (
                "Astra",
                Color.YELLOW,
                13
                );

            PenBox penBox = new PenBox
                (
                "Coolpack",
                Color.BLACK,
                pencil1,
                pencil2,
                crayon1,
                crayon2,
                crayon3
                );

            penBox.About();
        }
    }
}
