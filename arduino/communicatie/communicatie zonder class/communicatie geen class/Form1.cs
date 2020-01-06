using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ditgaat_fout
{
    public partial class Form1 : Form
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
        String wat;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waardepot = Convert.ToInt32(inputpot);
            waardeultra = Convert.ToInt32(inputultra);
            //waardetemp = Convert.ToInt32(inputtemp);
            //waardehum = Convert.ToInt32(inputhum);

            
            label1.Text = "xpositie   :      " + waardeultra;
            label2.Text = "ypositie   :     " + inputpot  ;
            label3.Text = "buttonstate   :     " + inputtemp  ;

            if (waardeultra <= 255)
            {
                //progressBar1.Value = waardepot;
            }
        }
        String input;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                input = serialPort1.ReadTo("%");
                inputall = input;
            }

            if (input != "")
            {
                string[] getal = input.Split(':');

                if (getal.Length >= 2)
                {
                    String gekregen = getal[0];
                    String[] joe = gekregen.Split('#');
                    if (joe.Length >= 2)
                    {
                        wat = joe[1];
                        switch (wat)
                        {
                            case "xpositie":
                                inputultra = getal[1];
                                break;

                            case "ypositie":
                                inputpot = getal[1];
                                break;
                            case "buttonstate":
                                inputtemp = getal[1];
                                break;
                            case "humidity":
                                inputhum = getal[1];

                                break;
                        }
                    }

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
