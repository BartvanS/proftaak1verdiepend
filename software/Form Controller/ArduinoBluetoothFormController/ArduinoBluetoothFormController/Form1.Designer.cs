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
            this.KillSwitch = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SerialDisconnect);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.ConnectStatus);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(582, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // SerialDisconnect
            // 
            this.SerialDisconnect.Location = new System.Drawing.Point(220, 29);
            this.SerialDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialDisconnect.Name = "SerialDisconnect";
            this.SerialDisconnect.Size = new System.Drawing.Size(80, 30);
            this.SerialDisconnect.TabIndex = 13;
            this.SerialDisconnect.Text = "Disconnect";
            this.SerialDisconnect.UseVisualStyleBackColor = true;
            this.SerialDisconnect.Click += new System.EventHandler(this.SerialDisconnect_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(130, 29);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(80, 30);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 29);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 30);
            this.listBox1.TabIndex = 1;
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.BackColor = System.Drawing.Color.Red;
            this.ConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectStatus.Location = new System.Drawing.Point(484, 15);
            this.ConnectStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(94, 56);
            this.ConnectStatus.TabIndex = 0;
            this.ConnectStatus.Text = "Disconnected";
            this.ConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialMessage
            // 
            this.SerialMessage.Location = new System.Drawing.Point(433, 223);
            this.SerialMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialMessage.Name = "SerialMessage";
            this.SerialMessage.Size = new System.Drawing.Size(94, 20);
            this.SerialMessage.TabIndex = 1;
            this.SerialMessage.Enter += new System.EventHandler(this.SerialTextboxEntered);
            this.SerialMessage.Leave += new System.EventHandler(this.SerialTextboxLeft);
            // 
            // SerialWriteSend
            // 
            this.SerialWriteSend.Location = new System.Drawing.Point(530, 222);
            this.SerialWriteSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialWriteSend.Name = "SerialWriteSend";
            this.SerialWriteSend.Size = new System.Drawing.Size(56, 19);
            this.SerialWriteSend.TabIndex = 2;
            this.SerialWriteSend.Text = "Send";
            this.SerialWriteSend.UseVisualStyleBackColor = true;
            this.SerialWriteSend.Click += new System.EventHandler(this.SerialWriteSend_Click);
            // 
            // SerialRecieve
            // 
            this.SerialRecieve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialRecieve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SerialRecieve.Location = new System.Drawing.Point(433, 245);
            this.SerialRecieve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialRecieve.Name = "SerialRecieve";
            this.SerialRecieve.ReadOnly = true;
            this.SerialRecieve.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SerialRecieve.Size = new System.Drawing.Size(155, 145);
            this.SerialRecieve.TabIndex = 3;
            this.SerialRecieve.Text = "";
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.Blue;
            this.RightButton.Location = new System.Drawing.Point(149, 282);
            this.RightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(56, 60);
            this.RightButton.TabIndex = 5;
            this.RightButton.Text = "D";
            this.RightButton.UseVisualStyleBackColor = false;
            // 
            // KillSwitch
            // 
            this.KillSwitch.BackColor = System.Drawing.Color.Blue;
            this.KillSwitch.Location = new System.Drawing.Point(28, 352);
            this.KillSwitch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KillSwitch.Name = "KillSwitch";
            this.KillSwitch.Size = new System.Drawing.Size(178, 37);
            this.KillSwitch.TabIndex = 8;
            this.KillSwitch.Text = "C";
            this.KillSwitch.UseVisualStyleBackColor = false;
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.Blue;
            this.ForwardButton.Location = new System.Drawing.Point(88, 217);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(56, 60);
            this.ForwardButton.TabIndex = 9;
            this.ForwardButton.Text = "W";
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackwardButton
            // 
            this.BackwardButton.BackColor = System.Drawing.Color.Blue;
            this.BackwardButton.Location = new System.Drawing.Point(88, 282);
            this.BackwardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(56, 60);
            this.BackwardButton.TabIndex = 10;
            this.BackwardButton.Text = "S";
            this.BackwardButton.UseVisualStyleBackColor = false;
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.Color.Blue;
            this.LeftButton.Location = new System.Drawing.Point(28, 282);
            this.LeftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(56, 60);
            this.LeftButton.TabIndex = 11;
            this.LeftButton.Text = "A";
            this.LeftButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Informatie Auto:";
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(230, 352);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(178, 37);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Power back on";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.KillSwitch);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.SerialRecieve);
            this.Controls.Add(this.SerialWriteSend);
            this.Controls.Add(this.SerialMessage);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button KillSwitch;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button LeftButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SerialDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
    }
}

