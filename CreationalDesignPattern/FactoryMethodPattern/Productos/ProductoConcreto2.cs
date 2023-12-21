using Pattern.FactoryMethod.Interfaces;

namespace Pattern.FactoryMethod.Productos
{
    public class ProductoConcreto2 : IProducto
    {
        public string Operacion()
        {
            return "{Resultado de producto concreto 2}";
        }
    }
}
