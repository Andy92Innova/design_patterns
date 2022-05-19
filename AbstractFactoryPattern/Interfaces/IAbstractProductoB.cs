namespace AbstractFactoryPattern.Interfaces
{
    public interface IAbstractProductoB
    {
        string UsoFuncionB();

        string OtroUsoFuncionB(IAbstractProductoA colaborador);
    }
}