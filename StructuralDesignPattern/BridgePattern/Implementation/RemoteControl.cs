using Pattern.Bridge.Abstraction;
using System.Reflection.Metadata.Ecma335;

namespace Pattern.Bridge.Implementation
{
    public class RemoteControl
    {
        private IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TooglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }
        }

        public void VolumeUp()
        {
            int volumenCurrent = _device.GetVolumen();
            int newVolumen = ++volumenCurrent;

            _device.SetVolumen(newVolumen);
        }

        public void VolumeDown()
        {
            int volumenCurrent = _device.GetVolumen();
            int newVolumen = --volumenCurrent;
            if (newVolumen != 0)
            {
                _device.SetVolumen(newVolumen);
            }
        }

        public void ChannelUp()
        {
            int channelCurrent = _device.GetChannel();
            int newChannel = ++channelCurrent;

            _device.SetChannel(newChannel);
        }

        public void ChannelDown()
        {
            int channelCurrent = _device.GetChannel();
            int newChannel = --channelCurrent;
            
            _device.SetChannel(newChannel);
        }


    }
}
