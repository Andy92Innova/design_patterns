using BuilderPattern.Interfaces;

namespace BuilderPattern.Builders
{
    internal class BuilderDirector
    {
        private IBuilder _constructor;

        public IBuilder Constructor
        {
            set { _constructor = value; }
        }

        public void BuildPMV()
        {
            _constructor.BuildParteA();
        }

        public void BuildFullPartes()
        {
            _constructor.BuildParteA();
            _constructor.BuildParteB();
            _constructor.BuildParteC();
        }

    }
}
