using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.Calculator
{
    internal class Element
    {
        public TypeOfElement TypeOfElement { get; set; }
        public double Value { get; set; }
        public Sign Sign { get; set; }

        public Element()
        {
            TypeOfElement = TypeOfElement.NULL;
            Value = 0;
            Sign = Sign.NULL;

        }

        public Element(TypeOfElement typeOfElement, double value, Sign sign)
        {
            TypeOfElement = typeOfElement;
            Value = value;
            Sign = sign;
        }

        public void Clear()
        {
            TypeOfElement = TypeOfElement.NULL;
            Value = 0;
            Sign = Sign.NULL;
        }

        public void Print()
        {
            Console.WriteLine($"\n({TypeOfElement}, {Value}, {Sign})");
        }

        public void Copy(Element element)
        {
            TypeOfElement = element.TypeOfElement;
            Value = element.Value;
            Sign = element.Sign;
        }


        public bool MultiplicationOrDivision(Element i)
        {
            return 
                ( 
                    (i.TypeOfElement == TypeOfElement.SIGN && i.Sign == Sign.MULT)
                    ||
                    (i.TypeOfElement == TypeOfElement.SIGN && i.Sign == Sign.DIV)
                    ||
                    (i.TypeOfElement == TypeOfElement.SIGN && i.Sign == Sign.MOD)
                );
        }
    }
}
