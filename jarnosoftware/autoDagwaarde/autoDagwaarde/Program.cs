using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoDagwaarde
{
    class Program
    {
        enum BrandstofSoort
        {
            benzineAuto = 100,
            dieselAuto = 150,
            lpgAuto = 90,
            elektrischAuto = 130
        }
        

        static void Main(string[] args)
        {

            List<Auto> autoList = new List<Auto>();

            autoList.Add(new Auto(Convert.ToInt32(BrandstofSoort.benzineAuto), 1199, "OAOA-33") { autoName = "auto1" });
            autoList.Add(new Auto(Convert.ToInt32(BrandstofSoort.elektrischAuto), 9229, "ROP-03") { autoName = "auto2" });
            autoList.Add(new Auto(Convert.ToInt32(BrandstofSoort.lpgAuto), 93219, "OAES-33") { autoName = "auto3" });
            autoList.Add(new Auto(Convert.ToInt32(BrandstofSoort.dieselAuto), 92139, "EAS-69") { autoName = "auto4" });


            foreach (Auto aAuto in autoList)
            {
                Console.WriteLine(aAuto.ToString());
            }
            Console.Read();
        }
    }
}
