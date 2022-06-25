using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Models
{
    public class Dog
    {
        public string Name 
        { 
            get; 
            set; 
        }
        public string Race 
        { 
            get; 
            set; 
        }

        public Dog()
            //konstruktor - wywołuje się przy starcie obiektu; taki jest z automatu tego nie trzeba pisać
        {
            Console.WriteLine("A new dog without arguments");
        }

        public Dog(string name, string race)
        {
            Console.WriteLine("A new dog with arguments");
            Name = race;
            Race = race;
        }

        public void Bark()
        {
            Console.WriteLine("Whoof! Whoof!");
        }

        public void Bite()
        {
            Console.WriteLine("Snap! Grr!");
        }

        public void Present()
        {
            Console.WriteLine($"Attention here is {Race} name {Name}");
        }

        public static void Run()
        {
            Console.WriteLine("[Dog] Running");
        }
    }
}
