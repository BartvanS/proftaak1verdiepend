using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ditgaat_fout
{
    class communicatie
    {
        int waardeultra;
        int waardepot;
        int waardetemp;
        int waardehum;

        String inputall;

        String inputhum;
        String inputtemp;
        String inputultra;
        String inputpot;
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
                    else
                    {
                        return 0;
                    }

                    if (watInput == wat)
                    {
                        if(joe.Length > 1)
                        {
                            int inputweg = Convert.ToInt32(getal[1]);
                            return inputweg;
                        }else
                        {
                            return 0;
                        }
                        
                    }
                    else
                    {
                        return 0;
                    }
                  
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                return 0;
            }
        }
    }
}
