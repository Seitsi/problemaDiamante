using diamante.Devices;

Printer printer = new Printer() { SerialNumber = 155 };
printer.ProcessaDoc("Minha luta");
printer.Print("Minha luta");

Scanner scanner = new Scanner() { SerialNumber = 266 };
scanner.ProcessaDoc("Meu documento");
Console.WriteLine(scanner.Scan());

ComboDevice device = new ComboDevice() { SerialNumber = 377};
device.ProcessaDoc("DeviceCombo documento");
device.Print("DeviceCombo documento");
device.Scan();