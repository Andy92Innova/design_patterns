using Pattern.FactoryMethod.Interfaces;

namespace Pattern.FactoryMethod.Creadores
{
    abstract class Creador
    {
        public abstract IProducto FactoryMethod();

        public string AlgunaOperacion()
        {
            var producto = FactoryMethod();
            var resultado = "Creador: El mismo código que la clase creador tiene, solo que se ejecuta con " + producto.Operacion();

            return resultado;
        }
    }
}
