// TuplesDemo.cs



// Tuples are like a quick way to hold a bunch of values without
// creating a full class or struct. I think of them like a quick bag
// where I can throw in different data types and carry them together.
//
// Example: (string, int) or (int, int, int) etc
//
// I will make some small examples here... may be with a few mistakes :)
// (good practice for debugging later)


using System;

namespace TuplesPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. First attempt - unnamed tuple
            var person = ("John", 25)
            Console.WriteLine(person.Item1); // expect John
            Console.WriteLine(person.Item2); // expect 25

            // 2. Named tuple (this looks cleaner)
            (string Name, int Age) student = ("Mary", 20);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age)

            // 3. Tuple returned from a method
            var car = GetCar();
            Console.WriteLine($"Car brand: {car.Brand}, Year: {car.Item2}"); // hmm mix up

            // 4. Another tuple, but I forgot if I can reassign easily??
            var point = (x: 2, y: 3);
            point.x = 5; // not sure if tuples are mutable??   check later
            Console.WriteLine(point);
        }

        // returns a tuple
        static (string, int) GetCar()
        {
            return ("Toyota", 2015);
        }
    }
}
