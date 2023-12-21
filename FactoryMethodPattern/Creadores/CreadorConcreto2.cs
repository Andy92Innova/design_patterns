using Pattern.FactoryMethod.Interfaces;
using Pattern.FactoryMethod.Productos;

namespace Pattern.FactoryMethod.Creadores
{
    class CreadorConcreto2 : Creador
    {
        public override IProducto FactoryMethod()
        {
            return new ProductoConcreto2();
        }
    }
}
