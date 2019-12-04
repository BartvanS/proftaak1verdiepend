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
        string[] getReturn = new string[16] { "l", "l", "w", "s", "a", "d", "l", "l", "rechtsvoor", "linksvoor", "rechtsachter", "linksachter", "w", "a", "s", "d" };
        string[] getKeyInput = new string[16] { "c", "wasd", "wad", "sad", "aws", "dws", "ws", "ad", "wa", "wd", "sa", "sd", "w", "a", "s", "d" };

        public string Keyname
        {
            get { return keyname; }
            set
            {
                if (value == "c" || value == "wasd" || value == "wad" || value == "sad" || value == "aws" || value == "dws" || value == "ws" || value == "ad" || value == "wa" || value == "wd" || value == "sa" || value == "sd" || value == "w" || value == "a" || value == "s" || value == "d")
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

        public string Send()
        {
            for (int i = 0; i < 16; i++)
            {
                if (this.Keyname == getKeyInput[i])
                {
                    return getReturn[i];
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
