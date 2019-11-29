namespace ArduinoBluetoothTest
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.SerialSend = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.SerialRecieve = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(495, 37);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(92, 23);
            this.ButtonDisconnect.TabIndex = 1;
            this.ButtonDisconnect.Text = "Uit";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(397, 38);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(92, 23);
            this.ButtonConnect.TabIndex = 2;
            this.ButtonConnect.Text = "Stuur";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // SerialSend
            // 
            this.SerialSend.Location = new System.Drawing.Point(75, 38);
            this.SerialSend.Name = "SerialSend";
            this.SerialSend.Size = new System.Drawing.Size(113, 22);
            this.SerialSend.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SerialSend);
            this.groupBox1.Controls.Add(this.ButtonConnect);
            this.groupBox1.Controls.Add(this.ButtonDisconnect);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(281, 199);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 67);
            this.ForwardButton.TabIndex = 1;
            this.ForwardButton.Text = "W";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForwardMouseDown);
            this.ForwardButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveButtonReleased);
            // 
            // BackwardButton
            // 
            this.BackwardButton.Location = new System.Drawing.Point(281, 272);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(75, 67);
            this.BackwardButton.TabIndex = 2;
            this.BackwardButton.Text = "S";
            this.BackwardButton.UseVisualStyleBackColor = true;
            this.BackwardButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackwardMouseDown);
            this.BackwardButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveButtonReleased);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(200, 272);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 67);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "A";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightMouseDown);
            this.LeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveButtonReleased);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(362, 272);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 67);
            this.RightButton.TabIndex = 4;
            this.RightButton.Text = "D";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftMouseDown);
            this.RightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveButtonReleased);
            // 
            // SerialRecieve
            // 
            this.SerialRecieve.Location = new System.Drawing.Point(200, 365);
            this.SerialRecieve.Name = "SerialRecieve";
            this.SerialRecieve.Size = new System.Drawing.Size(237, 96);
            this.SerialRecieve.TabIndex = 5;
            this.SerialRecieve.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 543);
            this.Controls.Add(this.SerialRecieve);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MoveKeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.TextBox SerialSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.RichTextBox SerialRecieve;
    }
}

