using System;


namespace diamante.Devices
{
    public abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessaDoc(string documento);
    }
}
