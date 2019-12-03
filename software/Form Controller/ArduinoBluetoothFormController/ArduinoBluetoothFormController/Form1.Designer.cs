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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RightButton = new System.Windows.Forms.Button();
            this.KillSwitch = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // SerialDisconnect
            // 
            this.SerialDisconnect.Location = new System.Drawing.Point(294, 36);
            this.SerialDisconnect.Name = "SerialDisconnect";
            this.SerialDisconnect.Size = new System.Drawing.Size(106, 37);
            this.SerialDisconnect.TabIndex = 13;
            this.SerialDisconnect.Text = "Disconnect";
            this.SerialDisconnect.UseVisualStyleBackColor = true;
            this.SerialDisconnect.Click += new System.EventHandler(this.SerialDisconnect_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(173, 36);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(106, 37);
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
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 36);
            this.listBox1.TabIndex = 1;
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.BackColor = System.Drawing.Color.Red;
            this.ConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectStatus.Location = new System.Drawing.Point(646, 18);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(124, 68);
            this.ConnectStatus.TabIndex = 0;
            this.ConnectStatus.Text = "Disconnected";
            this.ConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialMessage
            // 
            this.SerialMessage.Location = new System.Drawing.Point(577, 274);
            this.SerialMessage.Name = "SerialMessage";
            this.SerialMessage.Size = new System.Drawing.Size(124, 22);
            this.SerialMessage.TabIndex = 1;
            this.SerialMessage.Enter += new System.EventHandler(this.SerialMessageEntered);
            this.SerialMessage.Leave += new System.EventHandler(this.SerialMessageLeft);
            // 
            // SerialWriteSend
            // 
            this.SerialWriteSend.Location = new System.Drawing.Point(707, 273);
            this.SerialWriteSend.Name = "SerialWriteSend";
            this.SerialWriteSend.Size = new System.Drawing.Size(75, 23);
            this.SerialWriteSend.TabIndex = 2;
            this.SerialWriteSend.Text = "Send";
            this.SerialWriteSend.UseVisualStyleBackColor = true;
            this.SerialWriteSend.Click += new System.EventHandler(this.SerialWriteSend_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(577, 302);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(205, 177);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.Blue;
            this.RightButton.Location = new System.Drawing.Point(199, 347);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 74);
            this.RightButton.TabIndex = 5;
            this.RightButton.Text = "D";
            this.RightButton.UseVisualStyleBackColor = false;
            // 
            // KillSwitch
            // 
            this.KillSwitch.BackColor = System.Drawing.Color.Blue;
            this.KillSwitch.Location = new System.Drawing.Point(37, 433);
            this.KillSwitch.Name = "KillSwitch";
            this.KillSwitch.Size = new System.Drawing.Size(237, 46);
            this.KillSwitch.TabIndex = 8;
            this.KillSwitch.Text = "C";
            this.KillSwitch.UseVisualStyleBackColor = false;
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.Blue;
            this.ForwardButton.Location = new System.Drawing.Point(118, 267);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 74);
            this.ForwardButton.TabIndex = 9;
            this.ForwardButton.Text = "W";
            this.ForwardButton.UseVisualStyleBackColor = false;
            // 
            // BackwardButton
            // 
            this.BackwardButton.BackColor = System.Drawing.Color.Blue;
            this.BackwardButton.Location = new System.Drawing.Point(118, 347);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(75, 74);
            this.BackwardButton.TabIndex = 10;
            this.BackwardButton.Text = "S";
            this.BackwardButton.UseVisualStyleBackColor = false;
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.Color.Blue;
            this.LeftButton.Location = new System.Drawing.Point(37, 347);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 74);
            this.LeftButton.TabIndex = 11;
            this.LeftButton.Text = "A";
            this.LeftButton.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.KillSwitch);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SerialWriteSend);
            this.Controls.Add(this.SerialMessage);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button KillSwitch;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button LeftButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SerialDisconnect;
        private System.Windows.Forms.Label label2;
    }
}

