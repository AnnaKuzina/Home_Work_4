using System;

namespace Home_Work_4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(1.10,1);
            Dog dog = new Dog(10.10, 1);
            Ostrich ostrich = new Ostrich(10.10, 1);
            Duck duck = new Duck(10.10, 1);
            Console.WriteLine("Cat:");
            cat.Eat();
            cat.Voice();
            Console.WriteLine("\nDog:");
            dog.Eat();
            dog.Voice();
            Console.WriteLine("\nOstrich:");
            ostrich.Eat();
            Console.WriteLine("\nDuck:");
            duck.Eat();
            duck.Move();
            Console.ReadKey();
        }
    }
}
