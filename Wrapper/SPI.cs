using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WiringPiNet.Wrapper
{
    public class SPI
    {
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPIGetFd")]
        public static extern int WiringPiSPIGetFd(int channel);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPIDataRW")]
        public static extern int WiringPiSPIDataRW(int channel, byte[] data, int len);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPISetup")]
        public static extern int WiringPiSPISetup(int channel, int speed);
    }
}
