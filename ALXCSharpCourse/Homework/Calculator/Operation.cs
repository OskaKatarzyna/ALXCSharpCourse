using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.Calculator
{
    public class Operation
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Result { get; set; }
        public Sign Sign { get; set; }

        public Operation()
        {
            X = 0;
            Y = 0;
            Result = 0;
            Sign = Sign.NULL;

        }
    }
}
