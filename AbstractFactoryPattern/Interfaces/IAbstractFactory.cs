using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Interfaces
{
    interface IAbstractFactory
    {
        IAbstractProductoA CrearProductoA();
        IAbstractProductoB CrearProductoB();
    }
}
