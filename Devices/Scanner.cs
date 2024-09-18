using System;


namespace diamante.Devices
{
    public class Scanner : Device, IScanner
    {
        public override void ProcessaDoc(string documento)
        {
            Console.WriteLine("Processando scan: " + documento);
        }

        public string Scan()
        {
            return "Scanner scan resultado";
        }
    }
}
