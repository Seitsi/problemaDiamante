using System;

namespace diamante.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string documento)
        {
            Console.WriteLine("ComboDevice impressão" + documento);
        }

        public override void ProcessaDoc(string documento)
        {
            Console.WriteLine("ComboDevice processando" + documento);
        }

        public string Scan()
        {
            return "ComboDevice resutaldo";
        }
    }
}
