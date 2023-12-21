using Pattern.Adapter.InputNonAccepted;
using Pattern.Adapter.Inputs;

namespace Pattern.Adapter.Apdater
{
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg _squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)
        {
            _squarePeg = squarePeg;
        }

        public new double GetRadius()
        {
            return _squarePeg.GetWith() * Math.Sqrt(2) / 2;
        }

    }

}
