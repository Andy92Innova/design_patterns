namespace Pattern.Bridge.Abstraction
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolumen();
        void SetVolumen(int percentage);
        int GetChannel();
        void SetChannel(int percentage);

    }
}
