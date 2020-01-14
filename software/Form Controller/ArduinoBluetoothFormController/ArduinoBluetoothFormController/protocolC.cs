using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoBluetoothFormController
{
    class protocolC
    {
        String whatInput;

        public int inputInt(String input, String wat)
        {
            if (input != "")
            {
                string[] getal = input.Split(':');

                if (getal.Length >= 2)
                {
                    String gekregen = getal[0];
                    String[] joe = gekregen.Split('#');
                    if (joe.Length > 1)
                    {
                        whatInput = joe[1];
                    }


                    if (whatInput == wat)
                    {
                        if (joe.Length > 1)
                        {
                            if(getal.Length > 1)
                            {
                                
                                return Convert.ToInt32(getal[1]);
                            }
                            return 0;

                        }

                    }


                }

            }
            return 0;

        }
    }
}


