using logboek;
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

        protocolC com = new protocolC();
        textfilemaker textFile = new textfilemaker();

        private string oldString = string.Empty;
       

        String command = "START";
        String input;

    

        bool KeyW = false;
        bool KeyA = false;
        bool KeyS = false;
        bool KeyD = false;
        bool KeyF = false;
        bool KeyL = false;
        MoveKeys PressedKeys = new MoveKeys("w");

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(new SerialPort("COM8", "ArduinoBot", 9600));
            listBox1.Items.Add(new SerialPort("COM5", "AndereConnectie", 9600));
            serialPort1.DataReceived += serialPort1_DataReceived;
            serialPort1.DtrEnable = true;
        }

        public string CheckMovementkeypressed(string Key)
        {
            if (Key == "l")
            {
                KeyPreview = false;
                SerialMessage.Enabled = false;
                ResetButton.Enabled = true;
                ResetButton.Visible = true;
                //StopKey.BackColor = Color.Blue;
                ForwardButton.BackColor = Color.Blue;
                BackwardButton.BackColor = Color.Blue;
                LeftButton.BackColor = Color.Blue;
                RightButton.BackColor = Color.Blue;
            }
            PressedKeys.Keyname = Key;
            string ReturnedKey = PressedKeys.Send(scrollbarSpeed.Value, isAutonom);

            return ReturnedKey;
        }

        //Een makkelijkere manier om te testen of iets werkt zonder de hele command opnieuw te typen
        void RunTest()
        {
            MessageBox.Show("Test complete");
        }
        void RunTest(string message)
        {
            MessageBox.Show(message);
        }

        //Writes to the serial any message you put in it
        public void writeToSerial(string message)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(message);
                //SerialRecieveData();
            }
            //RunTest(message);
            
        }

        void SerialRecieveData()
        {
            SerialRecieve.Text += serialPort1.ReadExisting() + Environment.NewLine;
        }
       
        int nummerke = 0;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
             input = serialPort1.ReadTo("%");
          
           
            
          //  nummerke = protocol.inputInt(input, "ultrasonic");

            
            com.inputInt(input, "forward");
            if (com.inputInt(input, "forward") > 0)
            {
                command = "forward";
            }

            com.inputInt(input, "backwards");
            if (com.inputInt(input, "backwards") > 0)
            {
                command = "backwards";

            }

            com.inputInt(input, "turnLeft");
            if (com.inputInt(input, "turnLeft") > 0)
            {
                command = "turnLeft";

            }

            com.inputInt(input, "turnForwardLeft");
            if (com.inputInt(input, "turnForwardLeft") > 0)
            {
                command = "turnForwardLeft";

            }

            com.inputInt(input, "turnRight");
            if (com.inputInt(input, "turnRight") > 0)
            {
                command = "turnRight";

            }

            com.inputInt(input, "turnForwardRight");
            if (com.inputInt(input, "turnRight") > 0)
            {
                command = "turnRight";

            }

            com.inputInt(input, "checkSpace");
            if (com.inputInt(input, "checkSpace") > 0)
            {
                command = "checkSpace";

            }

        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {

            //What to do with the received line here
            if (line.Contains("#"))
            {
                //line.Remove(int iets(line.Length)--);
            }

            SerialRecieve.Text += line + Environment.NewLine + Environment.NewLine;

        }

        //Writes to the serial with the textbox next to the send button
        void SerialTextbox()
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
                SerialTextbox();
            }
        }

        //Zorgt ervoor dat wanneer je wil typen je niet de event afzet van ingedrukte knoppen
        //Zo kun je als je w intypt in de textbox de auto niet naar voren gaat
        private void SerialTextboxEntered(object sender, EventArgs e)
        {
            KeyPreview = false;
        }

        //Dit zorgt dat de key events weer actief worden
        private void SerialTextboxLeft(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

       //Dit kijkt of er een key is ingedrukt en voert dan een command naar de arduino
        void MoveKeyDown(object sender, KeyEventArgs e)
        {
         
                if (e.KeyCode == Keys.W)
                {
                    ForwardButton.BackColor = Color.Red;
                    KeyW = true;
                }
                if (e.KeyCode == Keys.S)
                {
                    BackwardButton.BackColor = Color.Red;
                    KeyS = true;
                }
                if (e.KeyCode == Keys.D)
                {
                    RightButton.BackColor = Color.Red;
                    KeyD = true;
                }
                if (e.KeyCode == Keys.A)
                {
                    LeftButton.BackColor = Color.Red;
                    KeyA = true;
                }
                if (e.KeyCode == Keys.F)
                {
                    StopKey.BackColor = Color.Red;
                    KeyF = true;
                }
                if (e.KeyCode == Keys.L)
                {
                    KeyL = true;
                }
            

            if (KeyL == true)
            {
                writeToSerial(CheckMovementkeypressed("l")); 
            }

            if (KeyF == true)
            {
                writeToSerial(CheckMovementkeypressed("f"));
            }


            else if (KeyW == true && KeyA == true && KeyS == true && KeyD == true)
            {
                writeToSerial(CheckMovementkeypressed("wasd"));
            }


            else if (KeyW == true && KeyA == true && KeyD == true)

            {
                writeToSerial(CheckMovementkeypressed("wad"));
            }
            else if (KeyS == true && KeyA == true && KeyD == true)
            {
                writeToSerial(CheckMovementkeypressed("sad"));
            }
            else if (KeyA == true && KeyW == true && KeyS == true)
            {
                writeToSerial(CheckMovementkeypressed("aws"));
            }
            else if (KeyD == true && KeyW == true && KeyS == true)
            {
                writeToSerial(CheckMovementkeypressed("dws"));
            }


            else if (KeyW == true && KeyS == true)
            {
                writeToSerial(CheckMovementkeypressed("ws"));
            }
            else if (KeyA == true && KeyD == true)
            {
                writeToSerial(CheckMovementkeypressed("ad"));
            }
            else if (KeyW == true && KeyA == true)
            {
                writeToSerial(CheckMovementkeypressed("wa"));
            }
            else if (KeyW == true && KeyD == true)
            {
                writeToSerial(CheckMovementkeypressed("wd"));
            }
            else if (KeyS == true && KeyA == true)
            {
                writeToSerial(CheckMovementkeypressed("sa"));
            }
            else if (KeyS == true && KeyD == true)
            {
                writeToSerial(CheckMovementkeypressed("sd"));
            }


            else if (KeyW == true)
            {
                writeToSerial(CheckMovementkeypressed("w"));
            }
            else if (KeyS == true)
            {
                writeToSerial(CheckMovementkeypressed("s"));
            }
            else if (KeyD == true)
            {
                writeToSerial(CheckMovementkeypressed("d"));
            }
            else if (KeyA == true)
            {
                writeToSerial(CheckMovementkeypressed("a"));
            }


            else
            {
                return;
            }           
        }
        private void MoveKeyReleased(object sender, KeyEventArgs e)
        {
           
                if (e.KeyCode == Keys
                        .W)
                {
                    ForwardButton.BackColor = Color.Blue;
                    KeyW = false;
                }
                if (e.KeyCode == Keys.S)
                {
                    BackwardButton.BackColor = Color.Blue;
                    KeyS = false;
                }
                if (e.KeyCode == Keys.A)
                {
                    LeftButton.BackColor = Color.Blue;
                    KeyA = false;
                }
                if (e.KeyCode == Keys.D)
                {
                    RightButton.BackColor = Color.Blue;
                    KeyD = false;
                }
            
            if (e.KeyCode == Keys.F)
            {
                StopKey.BackColor = Color.Blue;
                KeyF = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            SerialMessage.Enabled = true;
            ResetButton.Enabled = false;
            ResetButton.Visible = false;
            KeyL = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lstBtn.Add(ForwardButton);
            lstBtn.Add(LeftButton);
            lstBtn.Add(RightButton);
            lstBtn.Add(BackwardButton);
            lstBtn.Add(StopKey);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(oldString != command)
            {
                logboekList.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " | " + command);
                logboekList.SelectedIndex = logboekList.Items.Count - 1;
                textFile.addToFile(command);
            }

            // Save the new value back into the temporary variable
            oldString = command;
          
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (fileName.Text != "")
            {
                textFile.makeFile(fileName.Text);
            }
            else
            {
                MessageBox.Show("Fill in a name!");
            }
        }
        List<Button> lstBtn = new List<Button>();
        bool isAutonom;
        private void SwitchStatebtn_Click(object sender, EventArgs e)
        {
            isAutonom = !isAutonom;
            if(isAutonom)
            {
                switchStatebtn.BackColor = Color.Green;
                switchStatebtn.Text = "Controller";
                serialPort1.Write("#autonoom:2%");
                KeyPreview = true;
            }else
            {
                switchStatebtn.BackColor = Color.Orange;
                switchStatebtn.Text = "Autonoom";
                serialPort1.Write("#autonoom:1%");
                KeyPreview = false;
            }
        }
    }
}
