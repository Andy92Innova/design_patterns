using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Productos
{
    internal class ProductoConcretoB1 : IAbstractProductoB
    {
        public string UsoFuncionB() {
            return "Resultado del producto B1";
        }


        public string OtroUsoFuncionB(IAbstractProductoA colaborador) {
            var resultA = colaborador.UsoFuncionA();
            return $"Este es el resultado del producto B1 con colaboración de ({resultA})";
        }

    }
}