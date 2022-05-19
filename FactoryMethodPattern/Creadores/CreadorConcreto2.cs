using FactoryMethodPattern.Creadores;
using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class CreadorConcreto2:Creador
    {
        public override IProducto FactoryMethod()
        {
            return new ProductoConcreto2();
        }
    }
}
