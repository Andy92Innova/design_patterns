using Pattern.Adapter.Apdater;
using Pattern.Adapter.InputNonAccepted;
using Pattern.Adapter.Inputs;
using Domain;

namespace Pattern
{
    public class AdapterPattern : IPattern
    {
        public void Main()
        {
            var roundHole = new RoundHole(10);

            var roundPeg = new RoundPeg(11);
            var squarePeg = new SquarePeg(10);

            var squarePeg2 = new SquarePeg(11);
            var squarePegAdapted = new SquarePegAdapter(squarePeg);

            Console.WriteLine($"Fits for {nameof(roundPeg)}: {roundHole.Fits(roundPeg)}");
            Console.WriteLine($"Fits for {nameof(squarePegAdapted)}: {roundHole.Fits(squarePegAdapted)}");
            //roundHole.Fits(squarePeg2); // type error here
        }
    }
}
