using Pattern.Bridge.Abstraction;

namespace Pattern.Bridge.Implementation
{
    internal class TVDevice : IDevice
    {
        public bool IsPower { get; set; }
        public int Channel { get; set; }
        public int Volumen { get; set; }

        public void Disable()
        {
            IsPower = false;
        }

        public void Enable()
        {
            IsPower = true;
        }

        public int GetChannel()
        {
            return Channel;
        }

        public int GetVolumen()
        {
            return Volumen;
        }

        public bool IsEnabled()
        {
            return IsPower;
        }

        public void SetChannel(int percentage)
        {
            Channel = percentage;
        }

        public void SetVolumen(int percentage)
        {
            Volumen = percentage;
        }
    }
}
