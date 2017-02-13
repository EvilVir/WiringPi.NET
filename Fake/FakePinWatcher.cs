using System.Collections.Generic;

namespace WiringPiNet.Fake
{
    public class FakePinWatcher : IPinWatcher
    {
        public double Interval { get; set; }

        public event PinsStateChangedEventHandler PinsStateChanged;

        public void Add(params GpioPin[] pins)
        {
        }

        public bool Contains(params GpioPin[] pins)
        {
            return false;
        }

        public void Dispose()
        {
        }

        public GpioPin Get(int index)
        {
            return null;
        }

        public List<GpioPin> GetAll()
        {
            return new List<GpioPin>();
        }

        public void Probe()
        {
        }

        public void Remove(params GpioPin[] pins)
        {
        }

        public void RemoveAll()
        {
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}
