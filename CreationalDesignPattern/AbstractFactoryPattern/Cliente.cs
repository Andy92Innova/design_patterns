using Pattern.AbstractFactory.Fabricas;
using Pattern.AbstractFactory.Interfaces;
using Domain;
using System;

namespace Pattern
{
    public class AbstractFactoryPattern : IPattern
    {
        public void Main()
        {
            Console.WriteLine("App: Probando la primera fábrica de tipo...");
            MetodoCliente(new FabricaConcreta1());
            Console.WriteLine("");
            Console.WriteLine("App: Probando el mismo metodo cliente con la segunda fábrica de tipo...");
            MetodoCliente(new FabricaConcreta2());
        }

        private void MetodoCliente(IAbstractFactory fabrica)
        {
            var productoA = fabrica.CrearProductoA();
            var productoB = fabrica.CrearProductoB();

            Console.WriteLine(productoB.UsoFuncionB());
            Console.WriteLine(productoB.OtroUsoFuncionB(productoA));
        }

    }
}
