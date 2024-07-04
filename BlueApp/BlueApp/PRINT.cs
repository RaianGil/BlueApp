using System.Collections.Generic;
using XF.Bluetooth.Printer.Plugin.Abstractions;

namespace BlueApp
{
    public interface PRINT: IPrint
    {      
        List<string> DevicesConnected();
    }
}
