namespace Pattern.Adapter.InputNonAccepted
{
    public class SquarePeg
    {
        private double _width { get; set; }

        public SquarePeg(int width)
        {
            _width = width;
        }

        public double GetWith()
        {
            return _width;
        }
    }
}
