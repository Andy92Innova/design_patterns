using Domain;
using System;
using System.Collections.Generic;
using Pattern;

namespace AppPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IPattern> patterns = new List<IPattern>
            {
                //Creational
                new AbstractFactoryPattern(),
                new BuilderPattern(),
                new FactoryMethodPattern(),
                new PrototypePattern(),
                new SingletonPattern(),
                //Structural
                new AdapterPattern(),
                new BridgePattern(),
                new CompositePattern(),
                new DecoratorPattern()
                //Behavioral
            };

            foreach (var pattern in patterns)
            {
                Console.WriteLine($"\n {"".PadLeft(10, '#')} Begin Pattern {pattern.GetType().Name} {"".PadRight(10, '#')}\n");
                pattern.Main();
                Console.WriteLine($"\n {"".PadLeft(10, '#')} End Pattern {pattern.GetType().Name} {"".PadRight(10, '#')}\n");
            }


            Console.ReadKey();
        }
    }
}
