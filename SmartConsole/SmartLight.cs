using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    internal class SmartLight : SmartDevice
    {
        private double brightness;
        private string color;

        // public properties
        public double Brightness
        {
            get { return brightness; }
            set { brightness = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        // constructor
        public SmartLight(int deviceID, string deviceName, double brightness, string color) : base(deviceID, deviceName)
        {
            Brightness = brightness;
            Color = color;
        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine($"Brightness: {Brightness}%, Color: {Color}");
        }
    }
    }
}
