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
            
            Console.ReadKey(); // What happens if you run the app without this line?
            
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
