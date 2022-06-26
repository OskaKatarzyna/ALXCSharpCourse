using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class ArraysAndLists
    {
        public static void Run()
        {
            int[] array1 = new int[7];
            array1[0] = 4;
            array1[1] = 2;
            array1[2] = 1;  
            array1[3] = 0;
            array1[4] = 3;
            array1[5] = 4;
            array1[6] = 1;
            int[] array2 = { 4, 2, 1, 0, 3, 4, 1 };


            Dog[] dogArray = new Dog[3];
            dogArray[0] = new Dog("Mickey", "golden");
            dogArray[1] = new Dog("Azor", "jamnik");
            dogArray[2] = new Dog("Burek", "mieszaniec");

            int[,] twoDArray = new int[2,7];
            twoDArray[0, 0] = 1;

            foreach (int number in array1) //foreach(typ element_name in array_name)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();    
            foreach (int number in array2) //foreach(typ element_name in array_name)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            foreach (Dog dog in dogArray) //foreach(typ element_name in array_name)
            {
                dog.Present();
                dog.Bark();
            }

            
        }
        public static void RunList()
        {
            Dog dog1 = new Dog("Mickey", "golden");
            Dog dog2 = new Dog("Azor", "jamnik");
            Dog dog3 = new Dog("Burek", "mieczykszaniec");
            Dog dog4 = new Dog("Czarek", "dalmatyńczyk");

            //List<Dog> dogs = new List<Dog>();
            var dogs = new List<Dog>();

            Console.WriteLine($"List Size {dogs.Count}");
            dogs.Add(dog2);
            Console.WriteLine($"List Size {dogs.Count}");
            dogs.Add(dog3);
            Console.WriteLine($"List Size {dogs.Count}");
            dogs.Add(dog1);
            Console.WriteLine($"List Size {dogs.Count}");
            dogs.Add(dog4);
            Console.WriteLine($"List Size {dogs.Count}");
            dogs.Remove(dog2);
            Console.WriteLine($"List Size {dogs.Count}");

            foreach(Dog dog in dogs)
            {
                dog.Present();
            }

            //Console.Writeline(numbers[1]);
        }

    }
}
