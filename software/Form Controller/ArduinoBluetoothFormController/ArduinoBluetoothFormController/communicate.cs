using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoBluetoothFormController
{
    
    class communicate
    {
        String whatIsInput;
        public int inputInt(String input, String wat)
        {
            if (input != "")
            {
                string[] valueInt = input.Split(':');

                if (valueInt.Length >= 2)
                {
                    String gekregen = valueInt[0];
                    String[] variableName = gekregen.Split('#');
                    if (variableName.Length > 1)
                    {
                        whatIsInput = variableName[1];
                    }


                    if (whatIsInput == wat)
                    {
                        if (variableName.Length > 1)
                        {
                            return Convert.ToInt32(valueInt[1]);
                        }

                    }


                }

            }
            return 0;

        }
    }
}
