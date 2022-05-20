using Domain;
using System;

namespace AppPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPattern _pattern;

            //_pattern = new AbstractFactoryPattern.Cliente();
            //_pattern = new BuilderPattern.Cliente();
            //_pattern = new FactoryMethodPattern.Cliente();
            _pattern = new PrototypePattern.Cliente();

            _pattern.Main();

            Console.ReadKey();
        }
    }
}
