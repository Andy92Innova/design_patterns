using FactoryMethodPattern.Creadores;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern
{
    class CreadorConcreto2 : Creador
    {
        public override IProducto FactoryMethod()
        {
            return new ProductoConcreto2();
        }
    }
}
