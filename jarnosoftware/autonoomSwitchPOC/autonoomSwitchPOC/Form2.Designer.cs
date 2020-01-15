namespace autonoomSwitchPOC
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.bakwardsButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.Autonoom = new System.Windows.Forms.GroupBox();
            this.autonoomOffRadio = new System.Windows.Forms.RadioButton();
            this.autonoomOnRadio = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Autonoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bruh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(532, 9);
            this.vScrollBar1.Maximum = 264;
            this.vScrollBar1.Minimum = 80;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(168, 432);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Value = 80;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(168, 245);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(94, 57);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "/\\";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // bakwardsButton
            // 
            this.bakwardsButton.Location = new System.Drawing.Point(168, 308);
            this.bakwardsButton.Name = "bakwardsButton";
            this.bakwardsButton.Size = new System.Drawing.Size(94, 59);
            this.bakwardsButton.TabIndex = 4;
            this.bakwardsButton.Text = "\\/";
            this.bakwardsButton.UseVisualStyleBackColor = true;
            this.bakwardsButton.Click += new System.EventHandler(this.BakwardsButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(68, 270);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(94, 59);
            this.leftButton.TabIndex = 5;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(268, 272);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(93, 57);
            this.rightButton.TabIndex = 6;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // Autonoom
            // 
            this.Autonoom.Controls.Add(this.autonoomOffRadio);
            this.Autonoom.Controls.Add(this.autonoomOnRadio);
            this.Autonoom.Location = new System.Drawing.Point(168, 15);
            this.Autonoom.Name = "Autonoom";
            this.Autonoom.Size = new System.Drawing.Size(200, 100);
            this.Autonoom.TabIndex = 7;
            this.Autonoom.TabStop = false;
            this.Autonoom.Text = "groupBox1";
            // 
            // autonoomOffRadio
            // 
            this.autonoomOffRadio.AutoSize = true;
            this.autonoomOffRadio.Checked = true;
            this.autonoomOffRadio.Location = new System.Drawing.Point(6, 48);
            this.autonoomOffRadio.Name = "autonoomOffRadio";
            this.autonoomOffRadio.Size = new System.Drawing.Size(48, 21);
            this.autonoomOffRadio.TabIndex = 1;
            this.autonoomOffRadio.TabStop = true;
            this.autonoomOffRadio.Text = "Off";
            this.autonoomOffRadio.UseVisualStyleBackColor = true;
            this.autonoomOffRadio.CheckedChanged += new System.EventHandler(this.AutonoomOffRadio_CheckedChanged);
            // 
            // autonoomOnRadio
            // 
            this.autonoomOnRadio.AutoSize = true;
            this.autonoomOnRadio.Location = new System.Drawing.Point(6, 21);
            this.autonoomOnRadio.Name = "autonoomOnRadio";
            this.autonoomOnRadio.Size = new System.Drawing.Size(48, 21);
            this.autonoomOnRadio.TabIndex = 0;
            this.autonoomOnRadio.Text = "On";
            this.autonoomOnRadio.UseVisualStyleBackColor = true;
            this.autonoomOnRadio.CheckedChanged += new System.EventHandler(this.AutonoomOnRadio_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM8";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 122);
            this.button2.TabIndex = 8;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1010, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 420);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(817, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(920, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Autonoom);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.bakwardsButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Autonoom.ResumeLayout(false);
            this.Autonoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button bakwardsButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.GroupBox Autonoom;
        private System.Windows.Forms.RadioButton autonoomOffRadio;
        private System.Windows.Forms.RadioButton autonoomOnRadio;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}