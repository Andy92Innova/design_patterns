using Domain;
using Pattern.FactoryMethod.Creadores;
using System;

namespace Pattern
{
    public class FactoryMethodPattern : IPattern
    {
        public void Main()
        {
            Console.WriteLine("App: lanzada con la clase CreadorConcreto1");
            ClienteCode(new CreadorConcreto1());

            Console.WriteLine("");

            Console.WriteLine("App: lanzada con la clase CreadorConcreto2");
            ClienteCode(new CreadorConcreto2());
        }

        private void ClienteCode(Creador creador)
        {
            Console.WriteLine("Cliente: No conozco la clase del creador, pero sé que funciona.\n" + creador.AlgunaOperacion());

        }
    }
}
