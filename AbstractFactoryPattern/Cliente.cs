using AbstractFactoryPattern.Fabricas;
using AbstractFactoryPattern.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Cliente : IPattern
    {
        public void Main() {
            Console.WriteLine("App: Probando la primera fábrica de tipo...");
            MetodoCliente(new FabricaConcreta1());
            Console.WriteLine("");
            Console.WriteLine("App: Probando el mismo metodo cliente con la segunda fábrica de tipo...");
            MetodoCliente(new FabricaConcreta2());
        }

        private void MetodoCliente(IAbstractFactory fabrica) {
            var productoA = fabrica.CrearProductoA();
            var productoB = fabrica.CrearProductoB();

            Console.WriteLine(productoB.UsoFuncionB());
            Console.WriteLine(productoB.OtroUsoFuncionB(productoA));
        }

    }
}
