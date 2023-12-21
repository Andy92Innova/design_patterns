using Pattern.AbstractFactory.Interfaces;
using Pattern.AbstractFactory.Productos;

namespace Pattern.AbstractFactory.Fabricas
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
