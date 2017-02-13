using System;
using System.Collections.Generic;
using System.Linq;

namespace WiringPiNet
{
    public delegate void PinsStateChangedEventHandler(object sender, PinsStateChangedEventArgs e);
    public class PinsStateChangedEventArgs : EventArgs
    {
        public GpioPin[] Pins { get; protected set; }

        public PinsStateChangedEventArgs(IEnumerable<GpioPin> changedPins)
        {
            this.Pins = changedPins.ToArray();
        }
    }
}
