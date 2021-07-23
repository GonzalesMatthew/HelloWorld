using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a greeting: Southern, Western, Spanish");
            string greeting = Console.ReadLine();

            if (greeting == "Southern")
            {
                Console.WriteLine("Howdy, Y'all!");
            }
            else if (greeting == "Western")
            {
                Console.WriteLine("Sup, peeps.");
            }
            else if (greeting == "Spanish")
            {
                Console.WriteLine("Hola! Soy, Dora!");
            }
            else
            {
                Console.WriteLine("Howdy, Y'all!");
            }

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}.");

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"Would you like to have a {color} triceratops?");
            
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            foreach(var animal in animals)
            {
                if (animal.Length > 5)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}
