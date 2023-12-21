namespace Pattern.AbstractFactory.Interfaces
{
    public interface IAbstractProductoB
    {
        string UsoFuncionB();

        string OtroUsoFuncionB(IAbstractProductoA colaborador);
    }
}