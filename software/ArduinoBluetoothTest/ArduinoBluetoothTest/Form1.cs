using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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

            var WriteLineWorker = new BackgroundWorker();
            WriteLineWorker.DoWork += new DoWorkEventHandler(writeToSerialAchtergrond);
            

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
            //serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
            //WriteLineWorker.RunWorkerAsync();
        }

        void writeToSerialAchtergrond(object sender, DoWorkEventArgs e)
        {
            while (serialPort1.IsOpen)
            {
                serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
                Thread.Sleep(500);
            }
            
        }

        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort spl = (SerialPort)sender;
                SerialRecieve.Text = serialPort1.ReadLine();
                count++;
            }
            catch(Exception ex)
            {

            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            writeToSerial(SerialSend.Text);
            SerialSend.Text = " ";
        }

        private void writeToSerial(string SerialInput)
        {
            try
            {
                serialPort1.Write(SerialInput);
                // Console.WriteLine(SerialInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            writeToSerial("f");
        }

        private void MoveButtonReleased(object sender, MouseEventArgs e)
        {
            writeToSerial(" ");
        }

        private void ForwardMouseDown(object sender, MouseEventArgs e)
        {
            writeToSerial("w");
        }

        private void BackwardMouseDown(object sender, MouseEventArgs e)
        {
            writeToSerial("s");
        }

        private void LeftMouseDown(object sender, MouseEventArgs e)
        {
            writeToSerial("d");
        }

        private void RightMouseDown(object sender, MouseEventArgs e)
        {
            writeToSerial("a");
        }

        private void MoveKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                writeToSerial("t");
                ForwardButton.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.S)
            {
                writeToSerial("s");
                ForwardButton.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.D)
            {
                writeToSerial("d");
                ForwardButton.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.A)
            {
                writeToSerial("a");
                ForwardButton.BackColor = Color.Red;
            }

            else
            {
                return;
            }
        }

        private void MoveKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.D || e.KeyCode == Keys.S)
            {
                writeToSerial(" ");
            }
            if(e.KeyCode == Keys.W)
            {
                writeToSerial("u");
                ForwardButton.BackColor = Color.Blue;
            }
        }
    }
}
