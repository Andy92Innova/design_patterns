using Domain;
using Pattern.Bridge.Implementation;

namespace Pattern
{
    public class BridgePattern : IPattern
    {
        public void Main()
        {
            var tv = new TVDevice() {
                IsPower = false,
                Channel = 1,
                Volumen = 0
            };
            var remoteTV = new RemoteControl(tv);

            remoteTV.TooglePower();
            Console.WriteLine($"Power: {tv.IsPower}");
            
            remoteTV.VolumeUp();
            remoteTV.VolumeUp();
            Console.WriteLine($"Volumen UP: {tv.Volumen}");
            
            remoteTV.VolumeDown();
            Console.WriteLine($"Volumen DOWN: {tv.Volumen}");
            
            remoteTV.ChannelUp();
            remoteTV.ChannelUp();
            remoteTV.ChannelUp();
            Console.WriteLine($"Channel UP: {tv.Channel}");
            
            
            remoteTV.ChannelDown();
            Console.WriteLine($"Channel DOWN: {tv.Channel}");


        }
    }
}