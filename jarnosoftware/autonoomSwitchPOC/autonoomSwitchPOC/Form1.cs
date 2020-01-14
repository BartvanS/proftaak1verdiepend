using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autonoomSwitchPOC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("o");
            Form2 f2 = new Form2(); 
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //serialPort1.Open();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("v");
        }
    }
}
