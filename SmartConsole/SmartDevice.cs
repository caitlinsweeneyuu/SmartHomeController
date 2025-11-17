using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    internal class SmartDevice
    {
        private int deviceId;
        private string deviceName;
        private bool status;

        // public properties
        public int DeviceId
        {
            get { return deviceId; }
            set { deviceId = value; }   
        }
        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        
        public SmartDevice(int id, string name, bool status)
        {
            this.deviceId = id;
            this.deviceName = name;
            this.status = status;
        }

        public void TurnOn()
        {
            Status = true;
            Console.WriteLine($"{deviceName} with device ID {DeviceId} is now on.");
        }

        public void TurnOff()
        {
            Status = false;
            Console.WriteLine($"{deviceName} with device ID {DeviceId} is now off.");
        }

        public virtual void GetStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}, Device Name: {deviceName}, Status (on or off): {(Status ? "On" : "Off")}");
        }
    }
}
