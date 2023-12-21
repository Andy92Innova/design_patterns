namespace Pattern.Adapter.Inputs
{
    public class RoundPeg
    {
        private double _radius { get; set; }

        public RoundPeg() { }

        public RoundPeg(int radius)
        {
            _radius = radius;
        }

        public double GetRadius()
        {
            return _radius;
        }


    }
}
