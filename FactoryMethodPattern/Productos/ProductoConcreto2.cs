using FactoryMethodPattern.Interfaces;

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
