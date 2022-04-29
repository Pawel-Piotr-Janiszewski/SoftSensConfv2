namespace SoftSensConfv2
{
    partial class LiveAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveAlarm));
            this.label4 = new System.Windows.Forms.Label();
            this.DisconnectButt = new System.Windows.Forms.Button();
            this.ConnectButt = new System.Windows.Forms.Button();
            this.SerialLightStatus = new System.Windows.Forms.TextBox();
            this.SerialStatusTextBox = new System.Windows.Forms.Label();
            this.BitBox = new System.Windows.Forms.ComboBox();
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AlarmStatus = new System.Windows.Forms.Label();
            this.AlarmLightStatus = new System.Windows.Forms.TextBox();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(246, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Connect to the instrument";
            // 
            // DisconnectButt
            // 
            this.DisconnectButt.Location = new System.Drawing.Point(315, 98);
            this.DisconnectButt.Margin = new System.Windows.Forms.Padding(4);
            this.DisconnectButt.Name = "DisconnectButt";
            this.DisconnectButt.Size = new System.Drawing.Size(179, 42);
            this.DisconnectButt.TabIndex = 16;
            this.DisconnectButt.Text = "Disconnect";
            this.DisconnectButt.UseVisualStyleBackColor = true;
            this.DisconnectButt.Click += new System.EventHandler(this.DisconnectButt_Click);
            // 
            // ConnectButt
            // 
            this.ConnectButt.Location = new System.Drawing.Point(315, 53);
            this.ConnectButt.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectButt.Name = "ConnectButt";
            this.ConnectButt.Size = new System.Drawing.Size(179, 33);
            this.ConnectButt.TabIndex = 15;
            this.ConnectButt.Text = "Connect";
            this.ConnectButt.UseVisualStyleBackColor = true;
            this.ConnectButt.Click += new System.EventHandler(this.ConnectButt_Click);
            // 
            // SerialLightStatus
            // 
            this.SerialLightStatus.Location = new System.Drawing.Point(622, 53);
            this.SerialLightStatus.Margin = new System.Windows.Forms.Padding(4);
            this.SerialLightStatus.Name = "SerialLightStatus";
            this.SerialLightStatus.Size = new System.Drawing.Size(25, 20);
            this.SerialLightStatus.TabIndex = 14;
            // 
            // SerialStatusTextBox
            // 
            this.SerialStatusTextBox.AutoSize = true;
            this.SerialStatusTextBox.Location = new System.Drawing.Point(522, 58);
            this.SerialStatusTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialStatusTextBox.Name = "SerialStatusTextBox";
            this.SerialStatusTextBox.Size = new System.Drawing.Size(10, 13);
            this.SerialStatusTextBox.TabIndex = 13;
            this.SerialStatusTextBox.Text = "-";
            // 
            // BitBox
            // 
            this.BitBox.FormattingEnabled = true;
            this.BitBox.Location = new System.Drawing.Point(132, 95);
            this.BitBox.Margin = new System.Windows.Forms.Padding(4);
            this.BitBox.Name = "BitBox";
            this.BitBox.Size = new System.Drawing.Size(160, 21);
            this.BitBox.TabIndex = 12;
            // 
            // ComBox
            // 
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Location = new System.Drawing.Point(132, 53);
            this.ComBox.Margin = new System.Windows.Forms.Padding(4);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(160, 21);
            this.ComBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "BitRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ComPort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "AlarmStatus:";
            // 
            // AlarmStatus
            // 
            this.AlarmStatus.AutoSize = true;
            this.AlarmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.AlarmStatus.Location = new System.Drawing.Point(129, 184);
            this.AlarmStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlarmStatus.Name = "AlarmStatus";
            this.AlarmStatus.Size = new System.Drawing.Size(14, 17);
            this.AlarmStatus.TabIndex = 19;
            this.AlarmStatus.Text = "-";
            // 
            // AlarmLightStatus
            // 
            this.AlarmLightStatus.Location = new System.Drawing.Point(250, 181);
            this.AlarmLightStatus.Margin = new System.Windows.Forms.Padding(4);
            this.AlarmLightStatus.Name = "AlarmLightStatus";
            this.AlarmLightStatus.Size = new System.Drawing.Size(25, 20);
            this.AlarmLightStatus.TabIndex = 20;
            // 
            // LiveAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlarmLightStatus);
            this.Controls.Add(this.AlarmStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisconnectButt);
            this.Controls.Add(this.ConnectButt);
            this.Controls.Add(this.SerialLightStatus);
            this.Controls.Add(this.SerialStatusTextBox);
            this.Controls.Add(this.BitBox);
            this.Controls.Add(this.ComBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LiveAlarm";
            this.Text = "USN SoftSensConf v2.0 - LiveAlarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LiveAlarm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DisconnectButt;
        private System.Windows.Forms.Button ConnectButt;
        private System.Windows.Forms.TextBox SerialLightStatus;
        private System.Windows.Forms.Label SerialStatusTextBox;
        private System.Windows.Forms.ComboBox BitBox;
        private System.Windows.Forms.ComboBox ComBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AlarmStatus;
        private System.Windows.Forms.TextBox AlarmLightStatus;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.Timer AlarmTimer;
        private System.IO.Ports.SerialPort serialPort1;
    }
}