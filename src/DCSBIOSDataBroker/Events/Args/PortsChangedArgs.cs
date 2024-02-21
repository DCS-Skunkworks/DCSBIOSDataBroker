﻿using DCSBIOSDataBroker.SerialPortClasses;

namespace DCSBIOSDataBroker.Events.Args
{
    public class PortsChangedArgs : EventArgs
    {
        public string[] SerialPorts { get; init; }
        public WindowsSerialPortEventType EventType { get; init; }
    }
}
