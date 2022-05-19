using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ProductoConcreto2 : IProducto
    {
        public string Operacion()
        {
            return "{Resultado de producto concreto 2}";
        }
    }
}
