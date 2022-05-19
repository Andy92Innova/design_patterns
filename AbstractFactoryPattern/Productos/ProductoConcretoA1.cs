using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Productos
{
    internal class ProductoConcretoA1 : IAbstractProductoA
    {
        public string UsoFuncionA() {
            return "Resultado del producto A1";
        }
    }
}