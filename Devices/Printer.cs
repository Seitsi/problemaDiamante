using System;


namespace diamante.Devices
{
    public class Printer : Device, IPrinter
    {
        public override void ProcessaDoc(string documento)
        {
            Console.WriteLine("Processando impressão: " + documento);
        }
        public void Print(string documento)
        {
            Console.WriteLine("Impressora impressão: " + documento);
        }
    }
}
