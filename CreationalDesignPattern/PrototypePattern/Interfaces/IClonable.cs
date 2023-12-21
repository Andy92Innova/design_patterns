namespace Pattern.Prototype.Interfaces
{
    internal interface IClonable<out T> where T : class
    {
        T ClonacionSuperficial();
        T ClonacionProfunda();
    }
}
