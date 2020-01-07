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
        communicatie com = new communicatie();
       
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
           

            
            label1.Text = waardeultra.ToString();
            label2.Text =  waardetemp.ToString()  ;
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
            com.inputInt(inputall, "xpositie");
            if (com.inputInt(inputall, "xpositie") > 0)
            {
                waardeultra = com.inputInt(inputall, "xpositie");
            }

            if (com.inputInt(inputall, "ypositie") > 0)
            {
                waardetemp = com.inputInt(inputall, "ypositie");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
