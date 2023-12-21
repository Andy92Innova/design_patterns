using Pattern.FactoryMethod.Creadores;
using Pattern.FactoryMethod.Interfaces;
using Pattern.FactoryMethod.Productos;

namespace Pattern.FactoryMethod.Creadores
{
    class CreadorConcreto1 : Creador
    {
        public override IProducto FactoryMethod()
        {
            return new ProductoConcreto1();
        }
    }
}
