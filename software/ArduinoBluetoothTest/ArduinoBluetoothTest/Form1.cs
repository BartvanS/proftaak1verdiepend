using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoBluetoothTest
{
    public partial class Form1 : Form
    {
        int count;

        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM8";
            serialPort1.BaudRate = 9600;

            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
        }

        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort spl = (SerialPort)sender;
                Console.Write("Data" + count + " " + spl.ReadLine() + "/n");
                count++;
            }
            catch(Exception ex)
            {

            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.Write(SerialSend.Text);
            SerialSend.Text = " ";
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Write("f");
        }
    }
}
