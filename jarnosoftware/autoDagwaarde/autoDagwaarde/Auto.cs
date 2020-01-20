using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoDagwaarde
{
    class Auto
    {
        string soortAuto;
        int factor = 0;
        public Auto(int Brandstof, int KmStand, string Kenteken)
        {
            this.Kenteken = Kenteken;
            this.KmStand = KmStand;
            factor = Brandstof;
            switch (factor)
            {
                case 100:
                    soortAuto = "benzine ";
                    break;
                case 150:
                    soortAuto = "diesel ";
                    break;
                case 90:
                    soortAuto = "LPG ";
                    break;
                case 130:
                    soortAuto = "elektrische ";
                    break;
            }
        }

        public string autoName { get; set; }
        public int KmStand { get; set; }
        public string Kenteken { get; }

        public int DagWaarde { get { return (500000 / KmStand) * factor; } }

        public void RijdKilometers(int kmGereden)
        {
            if(kmGereden > 0)
            {
                this.KmStand = this.KmStand + kmGereden;
            }
        }
        public override string ToString() {
            return this.Kenteken + " " + soortAuto + "auto met " + this.KmStand + "km op de teller heeft een dagwaarde van " + this.DagWaarde + " euro.";
        }
    }
}
