using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoBluetoothFormController
{
    class SerialPort
    {
        private string port;
        public string Name;
        private int baudrate;

        public string Port
        {
            get
            {
                return port;
            }
            set
            {
                if (value == "COM1" || value == "COM2" || value == "COM3" || value == "COM4" || value == "COM5" || value == "COM6" || value == "COM7" || value == "COM8")
                {
                    port = value;
                }
                else
                {
                    port = "COM8";
                }

            }
        }

        public int Baudrate
        {
            get
            {
                return baudrate;
            }
            set
            {
                if (value == 110 || value == 300 || value == 600 || value == 1200 || value == 2400 || value == 4800 || value == 9600 || value == 14400 || value == 19200 || value == 38400 || value == 57600 || value == 115200 || value == 128000 || value == 256000)
                {
                    this.baudrate = value;
                }
                else
                {
                    this.baudrate = 9600;
                }
            }
        }



        public SerialPort(string aPort, string name, int aBaudrate)
        {
            Port = aPort;
            Name = name;
            Baudrate = aBaudrate;
        }

        public override string ToString()
        {
            return this.Name;
        }


    }
}
