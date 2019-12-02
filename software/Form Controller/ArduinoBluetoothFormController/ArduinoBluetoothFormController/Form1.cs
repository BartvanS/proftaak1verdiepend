using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoBluetoothFormController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(new SerialPort("COM8", "ArduinoBot", 9600));
            listBox1.Items.Add(new SerialPort("COM7", "AndereConnectie", 9600));
        }

        void RunTest(string message)
        {
            MessageBox.Show(message);
        }

        //Writes to the serial any message you put in it
        void writeToSerial(string message)
        {
            serialPort1.Write(message);
        }

        //Writes to the serial with the textbox next to the send button
        void SerialWrite()
        {
            if(SerialMessage.Text == null)
            {
                MessageBox.Show("Please send something");
            }
            else
            {
                serialPort1.Write(SerialMessage.Text);
                SerialMessage.Text = null;
            }          
        }

        //Opens the port of the selected SerialPort in the listbox
        //if nothing is selected it will give a error message
        private void SerialConnect()
        {
            var curItem = listBox1.SelectedItem;
            if(curItem == null)
            {
                MessageBox.Show("Select a connection first.");
                return;
            }
            List<object> selecteditem = new List<object>();
            selecteditem.Add(curItem);

            foreach(SerialPort item in selecteditem)
            {
                serialPort1.PortName = item.Port;
                serialPort1.BaudRate = item.Baudrate;
            }
                       
        }

        //Opens the port that you selected in the listbox
        //If there already is a open port it will ask you to close it first
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Please disconnect first");
                return;
            }
            SerialConnect();          
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (serialPort1.IsOpen)
            {
                ConnectStatus.Text = "Connected";
                ConnectStatus.BackColor = Color.Green;
            }
        }

        //Disconnects the port if it is open otherwise it will ask you to open one first
        private void SerialDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                ConnectStatus.Text = "Disconnected";
                ConnectStatus.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Please connect first");
            }
        }

        //Sends the message that is written in the textbox when a connection is open
        //if no connection is open sends a message
        private void SerialWriteSend_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Please establish an connection first");
                return;
            }
            else
            {
                SerialWrite();
            }
        }

        //Zorgt ervoor dat wanneer je wil typen je niet de event afzet van ingedrukte knoppen
        //Zo kun je als je w intypt in de textbox de auto niet naar voren gaat
        private void SerialMessageEntered(object sender, EventArgs e)
        {
            KeyPreview = false;
        }

        //Dit zorgt dat de key events weer actief worden
        private void SerialMessageLeft(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

       //Dit kijkt of er een key is ingedrukt en voert dan een command naar de arduino
        void MoveKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                //writeToSerial("t");
                //RunTest("Vooruit");
                ForwardButton.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.S)
            {
                //writeToSerial("s");
                //RunTest("Achteruit");
                BackwardButton.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.D)
            {
                //writeToSerial("d");
                //RunTest("Links");
                RightButton.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.A)
            {
                //writeToSerial("a");
                //RunTest("Rechts");
                LeftButton.BackColor = Color.Red;
            }
            if (e.KeyCode == Keys.C)
            {
                //writeToSerial("l");
                KillSwitch.BackColor = Color.Red;
            }

            else
            {
                return;
            }           
        }
        private void MoveKeyReleased(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.A || e.KeyCode == Keys.D || e.KeyCode == Keys.S)
            {
                //RunTest("Iets anders is los gelaten");
                //writeToSerial(" ");
                BackwardButton.BackColor = Color.Blue;
                LeftButton.BackColor = Color.Blue;
                RightButton.BackColor = Color.Blue;
            }*/
            if (e.KeyCode == Keys.W)
            {
                //writeToSerial("u");
                //RunTest("Stop met vooruit");
                ForwardButton.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.S)
            {
                BackwardButton.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.A)
            {
                LeftButton.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D)
            {
                RightButton.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.C)
            {
                KillSwitch.BackColor = Color.Blue;
            }
        }
    }
}
