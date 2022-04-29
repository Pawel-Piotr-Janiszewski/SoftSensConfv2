namespace SoftSensConfv2
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.DisconnectButt = new System.Windows.Forms.Button();
            this.ConnectButt = new System.Windows.Forms.Button();
            this.SerialLightStatus = new System.Windows.Forms.TextBox();
            this.SerialStatusTextBox = new System.Windows.Forms.Label();
            this.BitBox = new System.Windows.Forms.ComboBox();
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SerialNum = new System.Windows.Forms.Label();
            this.AlarmLow = new System.Windows.Forms.Label();
            this.UpperVal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AlarmUp = new System.Windows.Forms.Label();
            this.LowVal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.NewAlarmLow = new System.Windows.Forms.TextBox();
            this.NewAlarmUP = new System.Windows.Forms.TextBox();
            this.NewLower = new System.Windows.Forms.TextBox();
            this.NewUpper = new System.Windows.Forms.TextBox();
            this.NewSerial = new System.Windows.Forms.TextBox();
            this.SendInstCont = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveConf = new System.Windows.Forms.Button();
            this.LoadConf = new System.Windows.Forms.Button();
            this.CurrentConf = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InstID = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.DataLogID = new System.Windows.Forms.TextBox();
            this.MonitorPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonitorType = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.MonitorList = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.AlarmStatus = new System.Windows.Forms.Label();
            this.AlarmLightStatus = new System.Windows.Forms.TextBox();
            this.SaveSensorData = new System.Windows.Forms.Button();
            this.ScaledVal = new System.Windows.Forms.CheckBox();
            this.StopMonitoring = new System.Windows.Forms.Button();
            this.Readraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConStatus = new System.Windows.Forms.Label();
            this.ConnectionLightStatus = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.MonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.RDCIDINST = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DisconnectButt);
            this.tabPage1.Controls.Add(this.ConnectButt);
            this.tabPage1.Controls.Add(this.SerialLightStatus);
            this.tabPage1.Controls.Add(this.SerialStatusTextBox);
            this.tabPage1.Controls.Add(this.BitBox);
            this.tabPage1.Controls.Add(this.ComBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1057, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Port Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(263, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Connect to the instrument";
            // 
            // DisconnectButt
            // 
            this.DisconnectButt.Location = new System.Drawing.Point(332, 112);
            this.DisconnectButt.Margin = new System.Windows.Forms.Padding(4);
            this.DisconnectButt.Name = "DisconnectButt";
            this.DisconnectButt.Size = new System.Drawing.Size(179, 42);
            this.DisconnectButt.TabIndex = 7;
            this.DisconnectButt.Text = "Disconnect";
            this.DisconnectButt.UseVisualStyleBackColor = true;
            this.DisconnectButt.Click += new System.EventHandler(this.DisconnectButt_Click);
            // 
            // ConnectButt
            // 
            this.ConnectButt.Location = new System.Drawing.Point(332, 67);
            this.ConnectButt.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectButt.Name = "ConnectButt";
            this.ConnectButt.Size = new System.Drawing.Size(179, 33);
            this.ConnectButt.TabIndex = 6;
            this.ConnectButt.Text = "Connect";
            this.ConnectButt.UseVisualStyleBackColor = true;
            this.ConnectButt.Click += new System.EventHandler(this.ConnectButt_Click);
            // 
            // SerialLightStatus
            // 
            this.SerialLightStatus.Location = new System.Drawing.Point(639, 67);
            this.SerialLightStatus.Margin = new System.Windows.Forms.Padding(4);
            this.SerialLightStatus.Name = "SerialLightStatus";
            this.SerialLightStatus.Size = new System.Drawing.Size(25, 23);
            this.SerialLightStatus.TabIndex = 5;
            // 
            // SerialStatusTextBox
            // 
            this.SerialStatusTextBox.AutoSize = true;
            this.SerialStatusTextBox.Location = new System.Drawing.Point(539, 72);
            this.SerialStatusTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialStatusTextBox.Name = "SerialStatusTextBox";
            this.SerialStatusTextBox.Size = new System.Drawing.Size(13, 17);
            this.SerialStatusTextBox.TabIndex = 4;
            this.SerialStatusTextBox.Text = "-";
            // 
            // BitBox
            // 
            this.BitBox.FormattingEnabled = true;
            this.BitBox.Location = new System.Drawing.Point(149, 109);
            this.BitBox.Margin = new System.Windows.Forms.Padding(4);
            this.BitBox.Name = "BitBox";
            this.BitBox.Size = new System.Drawing.Size(160, 25);
            this.BitBox.TabIndex = 3;
            // 
            // ComBox
            // 
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Location = new System.Drawing.Point(149, 67);
            this.ComBox.Margin = new System.Windows.Forms.Padding(4);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(160, 25);
            this.ComBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "BitRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ComPort";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.NewAlarmLow);
            this.tabPage2.Controls.Add(this.NewAlarmUP);
            this.tabPage2.Controls.Add(this.NewLower);
            this.tabPage2.Controls.Add(this.NewUpper);
            this.tabPage2.Controls.Add(this.NewSerial);
            this.tabPage2.Controls.Add(this.SendInstCont);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.SaveConf);
            this.tabPage2.Controls.Add(this.LoadConf);
            this.tabPage2.Controls.Add(this.CurrentConf);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1057, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instrument Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label20.Location = new System.Drawing.Point(318, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(237, 24);
            this.label20.TabIndex = 48;
            this.label20.Text = "Instrument Configuration";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SerialNum);
            this.groupBox1.Controls.Add(this.AlarmLow);
            this.groupBox1.Controls.Add(this.UpperVal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.AlarmUp);
            this.groupBox1.Controls.Add(this.LowVal);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(663, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(386, 335);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Current Config:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Serial Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Upper Value:";
            // 
            // SerialNum
            // 
            this.SerialNum.AutoSize = true;
            this.SerialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNum.Location = new System.Drawing.Point(240, 54);
            this.SerialNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Size = new System.Drawing.Size(14, 20);
            this.SerialNum.TabIndex = 12;
            this.SerialNum.Text = "-";
            // 
            // AlarmLow
            // 
            this.AlarmLow.AutoSize = true;
            this.AlarmLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmLow.Location = new System.Drawing.Point(240, 269);
            this.AlarmLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlarmLow.Name = "AlarmLow";
            this.AlarmLow.Size = new System.Drawing.Size(14, 20);
            this.AlarmLow.TabIndex = 21;
            this.AlarmLow.Text = "-";
            // 
            // UpperVal
            // 
            this.UpperVal.AutoSize = true;
            this.UpperVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperVal.Location = new System.Drawing.Point(240, 100);
            this.UpperVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperVal.Name = "UpperVal";
            this.UpperVal.Size = new System.Drawing.Size(14, 20);
            this.UpperVal.TabIndex = 14;
            this.UpperVal.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Alarm Lower:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Lower Value:";
            // 
            // AlarmUp
            // 
            this.AlarmUp.AutoSize = true;
            this.AlarmUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmUp.Location = new System.Drawing.Point(240, 208);
            this.AlarmUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlarmUp.Name = "AlarmUp";
            this.AlarmUp.Size = new System.Drawing.Size(14, 20);
            this.AlarmUp.TabIndex = 19;
            this.AlarmUp.Text = "-";
            // 
            // LowVal
            // 
            this.LowVal.AutoSize = true;
            this.LowVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowVal.Location = new System.Drawing.Point(240, 146);
            this.LowVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowVal.Name = "LowVal";
            this.LowVal.Size = new System.Drawing.Size(14, 20);
            this.LowVal.TabIndex = 16;
            this.LowVal.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 208);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Alarm Upper:";
            // 
            // NewAlarmLow
            // 
            this.NewAlarmLow.Location = new System.Drawing.Point(469, 349);
            this.NewAlarmLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewAlarmLow.Name = "NewAlarmLow";
            this.NewAlarmLow.Size = new System.Drawing.Size(148, 23);
            this.NewAlarmLow.TabIndex = 46;
            // 
            // NewAlarmUP
            // 
            this.NewAlarmUP.Location = new System.Drawing.Point(469, 287);
            this.NewAlarmUP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewAlarmUP.Name = "NewAlarmUP";
            this.NewAlarmUP.Size = new System.Drawing.Size(148, 23);
            this.NewAlarmUP.TabIndex = 45;
            // 
            // NewLower
            // 
            this.NewLower.Location = new System.Drawing.Point(469, 226);
            this.NewLower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewLower.Name = "NewLower";
            this.NewLower.Size = new System.Drawing.Size(148, 23);
            this.NewLower.TabIndex = 44;
            // 
            // NewUpper
            // 
            this.NewUpper.Location = new System.Drawing.Point(469, 164);
            this.NewUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewUpper.Name = "NewUpper";
            this.NewUpper.Size = new System.Drawing.Size(148, 23);
            this.NewUpper.TabIndex = 43;
            // 
            // NewSerial
            // 
            this.NewSerial.Location = new System.Drawing.Point(469, 103);
            this.NewSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewSerial.Name = "NewSerial";
            this.NewSerial.Size = new System.Drawing.Size(148, 23);
            this.NewSerial.TabIndex = 42;
            // 
            // SendInstCont
            // 
            this.SendInstCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendInstCont.Location = new System.Drawing.Point(456, 395);
            this.SendInstCont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendInstCont.Name = "SendInstCont";
            this.SendInstCont.Size = new System.Drawing.Size(161, 37);
            this.SendInstCont.TabIndex = 41;
            this.SendInstCont.Text = "Send to instrument";
            this.SendInstCont.UseVisualStyleBackColor = true;
            this.SendInstCont.Click += new System.EventHandler(this.SendInstCont_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(272, 349);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Alarm Lower:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(272, 287);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 39;
            this.label15.Text = "Alarm Upper:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(272, 226);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Lower Value:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(272, 164);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Upper Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "Serial Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(272, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "New Config:";
            // 
            // SaveConf
            // 
            this.SaveConf.Location = new System.Drawing.Point(44, 223);
            this.SaveConf.Name = "SaveConf";
            this.SaveConf.Size = new System.Drawing.Size(145, 35);
            this.SaveConf.TabIndex = 2;
            this.SaveConf.Text = "Save Config";
            this.SaveConf.UseVisualStyleBackColor = true;
            this.SaveConf.Click += new System.EventHandler(this.SaveConf_Click);
            // 
            // LoadConf
            // 
            this.LoadConf.Location = new System.Drawing.Point(44, 164);
            this.LoadConf.Name = "LoadConf";
            this.LoadConf.Size = new System.Drawing.Size(145, 38);
            this.LoadConf.TabIndex = 1;
            this.LoadConf.Text = "LoadConfig";
            this.LoadConf.UseVisualStyleBackColor = true;
            this.LoadConf.Click += new System.EventHandler(this.LoadConf_Click);
            // 
            // CurrentConf
            // 
            this.CurrentConf.Location = new System.Drawing.Point(44, 98);
            this.CurrentConf.Name = "CurrentConf";
            this.CurrentConf.Size = new System.Drawing.Size(145, 47);
            this.CurrentConf.TabIndex = 0;
            this.CurrentConf.Text = "Load Config from the Instrument";
            this.CurrentConf.UseVisualStyleBackColor = true;
            this.CurrentConf.Click += new System.EventHandler(this.CurrentConf_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.ScaledVal);
            this.tabPage3.Controls.Add(this.StopMonitoring);
            this.tabPage3.Controls.Add(this.Readraw);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1057, 568);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Current Values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label21.Location = new System.Drawing.Point(210, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(701, 24);
            this.label21.TabIndex = 11;
            this.label21.Text = "Sensor Monitoring (Monitoring data is saved automatically to the database)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.InstID);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.DataLogID);
            this.groupBox2.Controls.Add(this.MonitorPlot);
            this.groupBox2.Controls.Add(this.MonitorType);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.MonitorList);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.AlarmStatus);
            this.groupBox2.Controls.Add(this.AlarmLightStatus);
            this.groupBox2.Controls.Add(this.SaveSensorData);
            this.groupBox2.Location = new System.Drawing.Point(530, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 487);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // InstID
            // 
            this.InstID.AutoSize = true;
            this.InstID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InstID.Location = new System.Drawing.Point(431, 31);
            this.InstID.Name = "InstID";
            this.InstID.Size = new System.Drawing.Size(14, 20);
            this.InstID.TabIndex = 21;
            this.InstID.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.Location = new System.Drawing.Point(309, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "Instrument_ID:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.Location = new System.Drawing.Point(309, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 20);
            this.label22.TabIndex = 20;
            this.label22.Text = "DataLogID:";
            // 
            // DataLogID
            // 
            this.DataLogID.Location = new System.Drawing.Point(424, 54);
            this.DataLogID.Name = "DataLogID";
            this.DataLogID.Size = new System.Drawing.Size(100, 23);
            this.DataLogID.TabIndex = 19;
            // 
            // MonitorPlot
            // 
            this.MonitorPlot.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.MonitorPlot.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.Name = "Legend1";
            this.MonitorPlot.Legends.Add(legend1);
            this.MonitorPlot.Location = new System.Drawing.Point(11, 77);
            this.MonitorPlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MonitorPlot.Name = "MonitorPlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.Legend = "Legend1";
            series1.Name = "Instrument Values";
            this.MonitorPlot.Series.Add(series1);
            this.MonitorPlot.Size = new System.Drawing.Size(493, 201);
            this.MonitorPlot.TabIndex = 11;
            this.MonitorPlot.Text = "MonitorPlot";
            // 
            // MonitorType
            // 
            this.MonitorType.AutoSize = true;
            this.MonitorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorType.Location = new System.Drawing.Point(189, 28);
            this.MonitorType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonitorType.Name = "MonitorType";
            this.MonitorType.Size = new System.Drawing.Size(14, 20);
            this.MonitorType.TabIndex = 18;
            this.MonitorType.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Currently Monitoring:";
            // 
            // MonitorList
            // 
            this.MonitorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorList.FormattingEnabled = true;
            this.MonitorList.ItemHeight = 20;
            this.MonitorList.Location = new System.Drawing.Point(4, 297);
            this.MonitorList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MonitorList.Name = "MonitorList";
            this.MonitorList.Size = new System.Drawing.Size(520, 124);
            this.MonitorList.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(281, 445);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "Alarm Status:";
            // 
            // AlarmStatus
            // 
            this.AlarmStatus.AutoSize = true;
            this.AlarmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmStatus.Location = new System.Drawing.Point(394, 444);
            this.AlarmStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlarmStatus.Name = "AlarmStatus";
            this.AlarmStatus.Size = new System.Drawing.Size(14, 20);
            this.AlarmStatus.TabIndex = 16;
            this.AlarmStatus.Text = "-";
            // 
            // AlarmLightStatus
            // 
            this.AlarmLightStatus.Location = new System.Drawing.Point(487, 444);
            this.AlarmLightStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlarmLightStatus.Name = "AlarmLightStatus";
            this.AlarmLightStatus.Size = new System.Drawing.Size(30, 23);
            this.AlarmLightStatus.TabIndex = 17;
            // 
            // SaveSensorData
            // 
            this.SaveSensorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSensorData.Location = new System.Drawing.Point(7, 431);
            this.SaveSensorData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveSensorData.Name = "SaveSensorData";
            this.SaveSensorData.Size = new System.Drawing.Size(255, 48);
            this.SaveSensorData.TabIndex = 12;
            this.SaveSensorData.Text = "Save Data To File";
            this.SaveSensorData.UseVisualStyleBackColor = true;
            this.SaveSensorData.Click += new System.EventHandler(this.SaveSensorData_Click);
            // 
            // ScaledVal
            // 
            this.ScaledVal.AutoSize = true;
            this.ScaledVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaledVal.Location = new System.Drawing.Point(321, 87);
            this.ScaledVal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaledVal.Name = "ScaledVal";
            this.ScaledVal.Size = new System.Drawing.Size(77, 24);
            this.ScaledVal.TabIndex = 9;
            this.ScaledVal.Text = "Scaled";
            this.ScaledVal.UseVisualStyleBackColor = true;
            // 
            // StopMonitoring
            // 
            this.StopMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopMonitoring.Location = new System.Drawing.Point(25, 158);
            this.StopMonitoring.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopMonitoring.Name = "StopMonitoring";
            this.StopMonitoring.Size = new System.Drawing.Size(267, 48);
            this.StopMonitoring.TabIndex = 8;
            this.StopMonitoring.Text = "Stop The Monitoring";
            this.StopMonitoring.UseVisualStyleBackColor = true;
            this.StopMonitoring.Click += new System.EventHandler(this.StopMonitoring_Click);
            // 
            // Readraw
            // 
            this.Readraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Readraw.Location = new System.Drawing.Point(25, 81);
            this.Readraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Readraw.Name = "Readraw";
            this.Readraw.Size = new System.Drawing.Size(267, 48);
            this.Readraw.TabIndex = 7;
            this.Readraw.Text = "Start The Monitoring";
            this.Readraw.UseVisualStyleBackColor = true;
            this.Readraw.Click += new System.EventHandler(this.Readraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(741, 632);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection Status:";
            // 
            // ConStatus
            // 
            this.ConStatus.AutoSize = true;
            this.ConStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ConStatus.Location = new System.Drawing.Point(919, 632);
            this.ConStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConStatus.Name = "ConStatus";
            this.ConStatus.Size = new System.Drawing.Size(13, 17);
            this.ConStatus.TabIndex = 2;
            this.ConStatus.Text = "-";
            // 
            // ConnectionLightStatus
            // 
            this.ConnectionLightStatus.Location = new System.Drawing.Point(1052, 628);
            this.ConnectionLightStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectionLightStatus.Name = "ConnectionLightStatus";
            this.ConnectionLightStatus.Size = new System.Drawing.Size(29, 23);
            this.ConnectionLightStatus.TabIndex = 3;
            // 
            // StatusTimer
            // 
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // MonitorTimer
            // 
            this.MonitorTimer.Tick += new System.EventHandler(this.MonitorTimer_Tick);
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenConfigDialog
            // 
            this.OpenConfigDialog.FileName = "openFileDialog2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Your RDC_ID:";
            // 
            // RDCIDINST
            // 
            this.RDCIDINST.AutoSize = true;
            this.RDCIDINST.Location = new System.Drawing.Point(530, 633);
            this.RDCIDINST.Name = "RDCIDINST";
            this.RDCIDINST.Size = new System.Drawing.Size(13, 17);
            this.RDCIDINST.TabIndex = 5;
            this.RDCIDINST.Text = "-";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 666);
            this.Controls.Add(this.RDCIDINST);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConnectionLightStatus);
            this.Controls.Add(this.ConStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "USN SoftSensConf v.2.0 - Instrument Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DisconnectButt;
        private System.Windows.Forms.Button ConnectButt;
        private System.Windows.Forms.TextBox SerialLightStatus;
        private System.Windows.Forms.Label SerialStatusTextBox;
        private System.Windows.Forms.ComboBox BitBox;
        private System.Windows.Forms.ComboBox ComBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CurrentConf;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConStatus;
        private System.Windows.Forms.TextBox ConnectionLightStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.Timer MonitorTimer;
        private System.Windows.Forms.Timer AlarmTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenConfigDialog;
        private System.Windows.Forms.SaveFileDialog SaveConfigDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RDCIDINST;
        private System.Windows.Forms.Button SaveConf;
        private System.Windows.Forms.Button LoadConf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SerialNum;
        private System.Windows.Forms.Label AlarmLow;
        private System.Windows.Forms.Label UpperVal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AlarmUp;
        private System.Windows.Forms.Label LowVal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox NewAlarmLow;
        private System.Windows.Forms.TextBox NewAlarmUP;
        private System.Windows.Forms.TextBox NewLower;
        private System.Windows.Forms.TextBox NewUpper;
        private System.Windows.Forms.TextBox NewSerial;
        private System.Windows.Forms.Button SendInstCont;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ScaledVal;
        private System.Windows.Forms.Button StopMonitoring;
        private System.Windows.Forms.Button Readraw;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonitorPlot;
        private System.Windows.Forms.Label MonitorType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox MonitorList;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label AlarmStatus;
        private System.Windows.Forms.TextBox AlarmLightStatus;
        private System.Windows.Forms.Button SaveSensorData;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox DataLogID;
        private System.Windows.Forms.Label InstID;
        private System.Windows.Forms.Label label23;
    }
}