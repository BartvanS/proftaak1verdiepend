using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logboek
{
    class communicatie
    {
        
        String watInput;

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
                        watInput = joe[1];
                    }

                    if (watInput == wat)
                    {
                        if (joe.Length > 1)
                        {
                            int inputweg = Convert.ToInt32(getal[1]);
                            return inputweg;
                        }

                    }

                }


            }
            return 0;
        }
    }
}
