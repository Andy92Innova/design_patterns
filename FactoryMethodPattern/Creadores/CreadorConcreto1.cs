using FactoryMethodPattern.Creadores;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern
{
    class CreadorConcreto1 : Creador
    {
        public override IProducto FactoryMethod()
        {
            return new ProductoConcreto1();
        }
    }
}
