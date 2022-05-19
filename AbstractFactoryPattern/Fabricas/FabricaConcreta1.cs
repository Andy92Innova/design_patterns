using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Fabricas
{
    class FabricaConcreta1:IAbstractFactory
    {
        public IAbstractProductoA CrearProductoA() {
            return new ProductoConcretoA1();
        }

        public IAbstractProductoB CrearProductoB() {
            return new ProductoConcretoB1();
        }
    }
}
