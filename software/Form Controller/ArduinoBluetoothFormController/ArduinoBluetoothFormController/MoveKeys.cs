using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoBluetoothFormController
{
    class MoveKeys
    {
        private string keyname;
        public readonly string KeyTried;
        string[] getReturn = new string[16] { "stop", "stop", "forward", "backward", "left", "right", "stop", "stop", "rechtsvoor", "linksvoor", "rechtsachter", "linksachter", "forward", "left", "backward", "right" };
        string[] getKeyInput = new string[16] { "f", "wasd", "wad", "sad", "aws", "dws", "ws", "ad", "wa", "wd", "sa", "sd", "w", "a", "s", "d" };

        public string Keyname
        {
            get { return keyname; }
            set
            {
                if (value == "l" || value == "f" || value == "f" || value == "wasd" || value == "wad" || value == "sad" || value == "aws" || value == "dws" || value == "ws" || value == "ad" || value == "wa" || value == "wd" || value == "sa" || value == "sd" || value == "w" || value == "a" || value == "s" || value == "d" || value == "c")
                {
                    keyname = value;
                }
                else
                {
                    keyname = null;
                }
            }
        }

        public MoveKeys(string aKeyName)
        {

            KeyTried = aKeyName;
            Keyname = aKeyName;
            if(this.Keyname == null)
            {
                throw new Exception(this.KeyTried + " is not a valid key input");
            }
        }

        public string Send(int speed)
        {
            for (int i = 0; i < 17; i++)
            {
                if (this.Keyname == getKeyInput[i])
                {
                    String send = "#" + getReturn[i] + ":" + speed + "%";
                    Console.WriteLine(send);
                    return send;
                   
                }
            }
            throw new Exception("Unreadable key input try a different key")
            {

            };
        }

        public override string ToString()
        {
            if(this.Keyname == null)
            {
                return "IsNull";
            }
            else
            {
                return this.Keyname;
            }           
        }
    }
}
