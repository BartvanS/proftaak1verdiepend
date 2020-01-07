using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoBluetoothFormController
{
    class Status
    {
        int leftSpeed;
        int rightSpeed;
        int LeftSpeed
        {
            get; set;
        }
        int RightSpeed
        {
            get; set;
        }

        public Status(string data)
        {
            //data voorbeeld: #leftSpeed:200% 


        }
    }
}
