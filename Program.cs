using System;
using FactoryPattern2.Classes.Factories;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CharacterFactory();
            Console.WriteLine("An example of the factory pattern.");
            Console.WriteLine("Enter the character you'd like to create: 1) Bob, 2) Dan.");
            var character = factory.Create(Console.ReadLine());
            Console.WriteLine("You selected: " + character.Name + ". " + character.Description);
        }
    }
}