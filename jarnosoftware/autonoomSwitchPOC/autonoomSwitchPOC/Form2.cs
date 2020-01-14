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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = Convert.ToString(vScrollBar1.Value);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(vScrollBar1.Value);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vScrollBar1.RightToLeft = RightToLeft.Yes;
            serialPort1.Open();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("#forward:" + vScrollBar1.Value + "%");
        }

        private void BakwardsButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("#backward:" + vScrollBar1.Value + "%");
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("#right:" + vScrollBar1.Value + "%");
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("#left:" + vScrollBar1.Value + "%");
        }

        private void AutonoomOnRadio_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.Write("#autonoom:1%");
        }

        private void AutonoomOffRadio_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.Write("#autonoom:2%");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("#stop:1%");
        }
    }
}
