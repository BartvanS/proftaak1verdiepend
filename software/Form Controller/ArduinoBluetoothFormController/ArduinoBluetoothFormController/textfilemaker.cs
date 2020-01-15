using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logboek
{
    class textfilemaker
    {
        List<String> actions = new List<String>();

        public void makeFile(string name)
        {
            String time = DateTime.Now.ToString("h_mm_ss_tt");
            string filePath = "C://Users//jarno//Desktop//log//" + time + "_" + name + ".txt";
            StreamWriter File = new StreamWriter(filePath);
            foreach (var item in actions)
            {
                File.WriteLine(item);
            }
            File.Close();
        }

        public void addToFile(string action)
        {
            actions.Add(DateTime.Now.ToString("h:mm:ss tt") + " | " + action);
        }
    }
}
