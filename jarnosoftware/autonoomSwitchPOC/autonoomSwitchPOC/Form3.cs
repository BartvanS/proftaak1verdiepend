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
using System.IO;

namespace logboek
{
    public partial class Form3 : Form
    {
        List<String> actions = new List<String>();
        communicatie com = new communicatie();
        textfilemaker textFile = new textfilemaker();

        String inputall;
        String command = "START";
        String input;
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textFile.makeFile(textBox1.Text);
            } else
            {
                MessageBox.Show("Fill in a name!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            timer1.Start();
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                input = serialPort1.ReadTo("%");
                inputall = input;
            }
            Console.WriteLine(input);
            com.inputInt(inputall, "forward");
            if (com.inputInt(inputall, "forward") > 0)
            {
                command = "forward";
            }

            com.inputInt(inputall, "backwards");
            if (com.inputInt(inputall, "backwards") > 0)
            {
                command = "backwards";

            }

            com.inputInt(inputall, "turnLeft");
            if (com.inputInt(inputall, "turnLeft") > 0)
            {
                command = "turnLeft";

            }

            com.inputInt(inputall, "turnForwardLeft");
            if (com.inputInt(inputall, "turnForwardLeft") > 0)
            {
                command = "turnForwardLeft";

            }

            com.inputInt(inputall, "turnRight");
            if (com.inputInt(inputall, "turnRight") > 0)
            {
                command = "turnRight";

            }

            com.inputInt(inputall, "turnForwardRight");
            if (com.inputInt(inputall, "turnRight") > 0)
            {
                command = "turnRight";

            }

            com.inputInt(inputall, "checkSpace");
            if (com.inputInt(inputall, "checkSpace") > 0)
            {
                command = "checkSpace";

            }
        }
        private string oldString = string.Empty;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (oldString != command)
            {
                listBox1.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " | " + command);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                textFile.addToFile(command);
            }

            // Save the new value back into the temporary variable
            oldString = command;
        }
    }
}

