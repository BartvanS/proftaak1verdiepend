using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoBluetoothFormController
{
    class protocol
    {
        String whatInput;

        public int inputInt(String input, String nameSearch)
        {
            if (input != "")
            {
                string[] getal = input.Split(':');
                if (getal.Length >= 2)
                {
                    String protocolName = getal[0];
                    String[] numbers = protocolName.Split('#');
                    if (numbers.Length > 1)
                    {
                        whatInput = numbers[1];
                    }
                    if (whatInput == nameSearch)
                    {
                        if (numbers.Length > 1)
                        {
                            return Convert.ToInt32(getal[1]);
                        }
                    }
                }
            }
            return 0;
        }
    }
}

