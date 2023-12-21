namespace Pattern.Adapter.Inputs
{
    public class RoundHole
    {
        private double _radius { get; set; }

        public RoundHole(double radius)
        {
            _radius = radius;
        }

        private double GetRadius()
        {
            return _radius;
        }

        public bool Fits(RoundPeg roundPeg)
        {
            return GetRadius() >= roundPeg.GetRadius();
        }
    }
}