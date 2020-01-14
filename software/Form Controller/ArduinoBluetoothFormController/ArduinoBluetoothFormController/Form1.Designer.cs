namespace ArduinoBluetoothFormController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SerialDisconnect = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ConnectStatus = new System.Windows.Forms.Label();
            this.SerialMessage = new System.Windows.Forms.TextBox();
            this.SerialWriteSend = new System.Windows.Forms.Button();
            this.SerialRecieve = new System.Windows.Forms.RichTextBox();
            this.RightButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.logboekList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scrollbarSpeed = new System.Windows.Forms.VScrollBar();
            this.StopKey = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SerialDisconnect);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.ConnectStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // SerialDisconnect
            // 
            this.SerialDisconnect.Location = new System.Drawing.Point(293, 36);
            this.SerialDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerialDisconnect.Name = "SerialDisconnect";
            this.SerialDisconnect.Size = new System.Drawing.Size(107, 37);
            this.SerialDisconnect.TabIndex = 13;
            this.SerialDisconnect.Text = "Disconnect";
            this.SerialDisconnect.UseVisualStyleBackColor = true;
            this.SerialDisconnect.Click += new System.EventHandler(this.SerialDisconnect_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(173, 36);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(107, 37);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 36);
            this.listBox1.TabIndex = 1;
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.BackColor = System.Drawing.Color.Red;
            this.ConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectStatus.Location = new System.Drawing.Point(645, 18);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(125, 68);
            this.ConnectStatus.TabIndex = 0;
            this.ConnectStatus.Text = "Disconnected";
            this.ConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialMessage
            // 
            this.SerialMessage.Location = new System.Drawing.Point(567, 274);
            this.SerialMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerialMessage.Name = "SerialMessage";
            this.SerialMessage.Size = new System.Drawing.Size(124, 22);
            this.SerialMessage.TabIndex = 1;
            this.SerialMessage.Enter += new System.EventHandler(this.SerialTextboxEntered);
            this.SerialMessage.Leave += new System.EventHandler(this.SerialTextboxLeft);
            // 
            // SerialWriteSend
            // 
            this.SerialWriteSend.Location = new System.Drawing.Point(697, 273);
            this.SerialWriteSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerialWriteSend.Name = "SerialWriteSend";
            this.SerialWriteSend.Size = new System.Drawing.Size(75, 23);
            this.SerialWriteSend.TabIndex = 2;
            this.SerialWriteSend.Text = "Send";
            this.SerialWriteSend.UseVisualStyleBackColor = true;
            this.SerialWriteSend.Click += new System.EventHandler(this.SerialWriteSend_Click);
            // 
            // SerialRecieve
            // 
            this.SerialRecieve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialRecieve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SerialRecieve.Location = new System.Drawing.Point(577, 302);
            this.SerialRecieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerialRecieve.Name = "SerialRecieve";
            this.SerialRecieve.ReadOnly = true;
            this.SerialRecieve.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SerialRecieve.Size = new System.Drawing.Size(205, 178);
            this.SerialRecieve.TabIndex = 3;
            this.SerialRecieve.Text = "";
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.Blue;
            this.RightButton.Location = new System.Drawing.Point(980, 361);
            this.RightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 74);
            this.RightButton.TabIndex = 5;
            this.RightButton.Text = "D";
            this.RightButton.UseVisualStyleBackColor = false;
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.Blue;
            this.ForwardButton.Location = new System.Drawing.Point(898, 281);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 74);
            this.ForwardButton.TabIndex = 9;
            this.ForwardButton.Text = "W";
            this.ForwardButton.UseVisualStyleBackColor = false;
            // 
            // BackwardButton
            // 
            this.BackwardButton.BackColor = System.Drawing.Color.Blue;
            this.BackwardButton.Location = new System.Drawing.Point(899, 359);
            this.BackwardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(75, 74);
            this.BackwardButton.TabIndex = 10;
            this.BackwardButton.Text = "S";
            this.BackwardButton.UseVisualStyleBackColor = false;
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.Color.Blue;
            this.LeftButton.Location = new System.Drawing.Point(818, 361);
            this.LeftButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 74);
            this.LeftButton.TabIndex = 11;
            this.LeftButton.Text = "A";
            this.LeftButton.UseVisualStyleBackColor = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Informatie Auto:";
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(305, 434);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(237, 46);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Power back on";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // logboekList
            // 
            this.logboekList.FormattingEnabled = true;
            this.logboekList.ItemHeight = 16;
            this.logboekList.Location = new System.Drawing.Point(12, 153);
            this.logboekList.Name = "logboekList";
            this.logboekList.Size = new System.Drawing.Size(278, 340);
            this.logboekList.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scrollbarSpeed
            // 
            this.scrollbarSpeed.Location = new System.Drawing.Point(888, 30);
            this.scrollbarSpeed.Maximum = 264;
            this.scrollbarSpeed.Minimum = 80;
            this.scrollbarSpeed.Name = "scrollbarSpeed";
            this.scrollbarSpeed.Size = new System.Drawing.Size(102, 192);
            this.scrollbarSpeed.TabIndex = 15;
            this.scrollbarSpeed.Value = 80;
            // 
            // StopKey
            // 
            this.StopKey.BackColor = System.Drawing.Color.Blue;
            this.StopKey.Location = new System.Drawing.Point(818, 447);
            this.StopKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopKey.Name = "StopKey";
            this.StopKey.Size = new System.Drawing.Size(237, 46);
            this.StopKey.TabIndex = 8;
            this.StopKey.Text = "F";
            this.StopKey.UseVisualStyleBackColor = false;
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(322, 153);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(111, 75);
            this.fileButton.TabIndex = 16;
            this.fileButton.Text = "Make file";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(322, 253);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 22);
            this.fileName.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 685);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.StopKey);
            this.Controls.Add(this.scrollbarSpeed);
            this.Controls.Add(this.logboekList);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.SerialRecieve);
            this.Controls.Add(this.SerialWriteSend);
            this.Controls.Add(this.SerialMessage);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MoveKeyReleased);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ConnectStatus;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox SerialMessage;
        private System.Windows.Forms.Button SerialWriteSend;
        private System.Windows.Forms.RichTextBox SerialRecieve;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button LeftButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SerialDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ListBox logboekList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.VScrollBar scrollbarSpeed;
        private System.Windows.Forms.Button StopKey;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox fileName;
    }
}

