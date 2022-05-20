using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Productos;

namespace AbstractFactoryPattern.Fabricas
{
    class FabricaConcreta2 : IAbstractFactory
    {
        public IAbstractProductoA CrearProductoA()
        {
            return new ProductoConcretoA2();
        }

        public IAbstractProductoB CrearProductoB()
        {
            return new ProductoConcretoB2();
        }
    }
}
