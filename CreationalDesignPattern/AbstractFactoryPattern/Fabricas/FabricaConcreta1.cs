using Pattern.AbstractFactory.Interfaces;
using Pattern.AbstractFactory.Productos;

namespace Pattern.AbstractFactory.Fabricas
{
    class FabricaConcreta1 : IAbstractFactory
    {
        public IAbstractProductoA CrearProductoA()
        {
            return new ProductoConcretoA1();
        }

        public IAbstractProductoB CrearProductoB()
        {
            return new ProductoConcretoB1();
        }
    }
}
