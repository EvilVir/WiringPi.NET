using System.Collections.Generic;

namespace WiringPiNet
{
    public interface IPinWatcher
    {
        double Interval { get; set; }

        event PinsStateChangedEventHandler PinsStateChanged;

        void Add(params GpioPin[] pins);
        bool Contains(params GpioPin[] pins);
        void Dispose();
        GpioPin Get(int index);
        List<GpioPin> Get(List<int> index);
        List<GpioPin> GetAll();
        void Probe();
        void Remove(params GpioPin[] pins);
        void RemoveAll();
        void Start();
        void Stop();
    }
}