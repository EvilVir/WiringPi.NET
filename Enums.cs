using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiringPiNet
{
    public enum PinMode : int
    {
        Input = 0,
        Output = 1,
        PwmOutput = 2,
        GpioClock = 3,
        SoftPwmOutput = 4,
        SoftToneOutput = 5,
        PwmToneOutput = 6
    }

    public enum PinValue : int
    {
        Low = 0,
        High = 1,
    }

    public enum PullMode : int
    {
        Off = 0,
        Down = 1,
        Up = 2,
    }

    public enum PwmMode : int
    {
        Ms = 0,
        Bal = 1,
    }

    public enum InterruptLevel : int
    {
        EdgeSetup = 0,
        EdgeFalling = 1,
        EdgeRising = 2,
        EdgeBoth = 3,
    }

    public enum BoardModel : int
    {
        Unknown = 0,
        PiA = 1,
        PiB = 2,
        PiBP = 3,
        PiCM = 4,
        PiAP = 5,
        OdroidC = 6,
        OdroidXU34 = 7,
    }

    public enum BoardVersion : int
    {
        Unknown = 0,
        Version1 = 1,
        Version11 = 2,
        Version12 = 3,
        Version2 = 4,
    }

    public enum BoardMaker : int
    {
        Unknown = 0,
        EgoMan = 1,
        Sony = 2,
        Quisda = 3,
        HardKernel = 4,
    }
}
