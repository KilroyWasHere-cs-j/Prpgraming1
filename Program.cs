using System;

namespace AbsractLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog dog = new Dog();
            Console.WriteLine(dog.Describe());
            Console.ReadKey();
            Console.WriteLine(dog.Energy());
            Console.ReadKey();
            Sockses socks = new Sockses();
            Console.WriteLine(socks.greenSocks().ToString());
            Console.WriteLine();
        }

        abstract class FourLeggedAnimal
        {
            public virtual string Describe()
            {
                return "Not much is known about this four legged animal!";
            }
        }

        class Dog : FourLeggedAnimal
        {
            public virtual string Energy()
            {
                return "High";
            }
        }

        abstract class Socks
        {
            public virtual long greenSocks()
            {
                return 10000000000000000;
            }
        }

        class Sockses : Socks
        {

        }
    }
}
