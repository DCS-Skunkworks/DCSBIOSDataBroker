﻿namespace DCSBIOSDataBroker.Events.Args
{
    public class SettingsDirtyEventArgs : EventArgs
    {
        public bool IsDirty { get; init; }        
    }
}
