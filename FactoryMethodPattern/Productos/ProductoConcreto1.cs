using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern
{
    public class ProductoConcreto1 : IProducto
    {
        public string Operacion()
        {
            return "{Resultado de producto concreto 1}";
        }
    }
}
