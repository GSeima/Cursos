using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces201.Devices
{
    class Scanner : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
