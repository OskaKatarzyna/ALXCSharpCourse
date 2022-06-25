using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Models
{
    public class ClassDemo
    {
        public static void Run()
        {
            //utworzenie obiektu - instancji klasy
            Dog westieDog = new Dog();
            westieDog.Name = "Skiper";
            westieDog.Race = "mieszaniec";
            westieDog.Present();
            westieDog.Bark();
            westieDog.Bite();

            Dog labradorDog = new Dog();
            labradorDog.Name = "Borys";
            labradorDog.Race = "labrador";
            labradorDog.Present();
            labradorDog.Bark();
            labradorDog.Bite();

            Dog goldenDog = new Dog
            {
                Name = "Misio",
                Race = "Golden Retriver"
            };
            goldenDog.Present();
            goldenDog.Bark();
            goldenDog.Bite();

            Dog borderColieDog = new Dog("Java", "Border Colie");
            borderColieDog.Present();
            borderColieDog.Bark();
            borderColieDog.Bite();
        }
    }
}
