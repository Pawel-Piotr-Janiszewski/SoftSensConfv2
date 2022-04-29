using System;
using System.IO;
using System.Globalization;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftSensConfv2
{
    public partial class LiveAlarm : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public LiveAlarm()
        {
            InitializeComponent();
            ComBox.Items.AddRange(SerialPort.GetPortNames());                                       //List all avaiable serialports in combox
            ComBox.Text = "--Select--";                                                             //Placeholder text
            string[] bitRate = new string[] { "1200", "2400", "4800t", "9600",
                                              "19200", "38400", "57600", "115200" };                //Avaiable bitrates
            BitBox.Items.AddRange(bitRate);                                                         //The bitrates added to a list
            BitBox.SelectedIndex = BitBox.Items.IndexOf("9600");                                    //The default bitrate selected on startup
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);    //Initialization of DataRecievedHandler
            StatusTimer.Interval = 500;
            StatusTimer.Tick += new EventHandler(StatusTimer_Tick);                                 //Timer that checks connection status to the instrument
            AlarmTimer.Interval = 1500;
            AlarmTimer.Tick += new EventHandler(AlarmTimer_Tick);                                   //Timer for alarms (related to plotting and sensor data)

        }
        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)                      //DataRecievedHandler function
        {
            string RecievedData = ((SerialPort)sender).ReadLine();                                  //DataRecievedHandler saves all data to the string
            string[] recievedData = RecievedData.Split(';');                                        //which it later splits into an array that is used later in the software
            if (recievedData[0] == "readstatus" && recievedData[1] == "0\r")                        //OK alarm
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Ok";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Green;                                       //"light" status color changes depending on the alarm received
                });
            }
            if (recievedData[0] == "readstatus" && recievedData[1] == "1\r")                        //fail alarm
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Fail";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Red;
                });
            }

            if (recievedData[0] == "readstatus" && recievedData[1] == "2\r")                        //alarm low
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Alarm Low";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Yellow;
                });
            }

            if (recievedData[0] == "readstatus" && recievedData[1] == "3\r")                        //alarm high
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Alarm High";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Red;
                });
            }
        }


            private void ConnectButt_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.Close();
                serialPort1.PortName = ComBox.Text;
                StatusTimer.Start();
                AlarmTimer.Start();
                while (serialPort1.IsOpen) ;
                serialPort1.Open();
                string text = "Success";
                MessageBox.Show("Connection Successfull! ");
                SerialStatusTextBox.Text = text;
                SerialLightStatus.BackColor = Color.Green;

            }
            catch (Exception ex)                                                                //Exceptions
            {
                serialPort1.Close();
                if (ex is ArgumentException)
                {
                    string text = "Invalid Port!";
                    StatusTimer.Stop();
                    AlarmTimer.Stop();
                    MessageBox.Show("Invalid Port!");
                    SerialStatusTextBox.Text = text;
                    SerialLightStatus.BackColor = Color.Red;

                }
                else if (ex is UnauthorizedAccessException)
                {
                    string text = "Cant Connect!";
                    StatusTimer.Stop();
                    AlarmTimer.Stop();
                    MessageBox.Show("Cannot Connect! Port might be in use ");
                    SerialStatusTextBox.Text = text;
                    SerialLightStatus.BackColor = Color.Red;
                }
                else
                {
                    string text = "....";
                    StatusTimer.Stop();
                    AlarmTimer.Stop();
                    MessageBox.Show("Check if USB is connected!");
                    SerialStatusTextBox.Text = text;
                    SerialLightStatus.BackColor = Color.Yellow;

                    //throw;
                }
            }
        }
        private void updateComBox_MouseClick(object sender, MouseEventArgs e)                           //Update function for the serial port combox

        {
            ComBox.Items.Clear();
            ComBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void DisconnectButt_Click(object sender, EventArgs e)                                   //disconnect button pressed
        {
            string text = "Disconnected!";
            serialPort1.Close();
            StatusTimer.Stop();
            AlarmTimer.Stop();
            MessageBox.Show("Disconnected!");
            SerialStatusTextBox.Text = text;
            SerialLightStatus.BackColor = Color.Red;
            AlarmStatus.Text = text;
            AlarmLightStatus.BackColor = Color.Red;
        }
        private void StatusTimer_Tick(object sender, EventArgs e)                                   //Statustimer
        {
            if (serialPort1.IsOpen)                                                                 //If theres a connection to the instrument
            {
                string text = "Connected!";
                SerialStatusTextBox.Text = text;
                SerialLightStatus.BackColor = Color.Green;

            }
            else if (serialPort1.IsOpen == false)                                                  //if connection is lost to the instrument
            {
                StatusTimer.Stop();                                                                //The timer stops
                MessageBox.Show("Connection lost to the instrument!");
                string text = "Disconnected!";
                SerialStatusTextBox.Text = text;
                SerialLightStatus.BackColor = Color.Red;

            }
        }
            private void AlarmTimer_Tick(object sender, EventArgs e)               //alarm timer
            {
                serialPort1.WriteLine("readstatus");
            }

        private void LiveAlarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectButt_Click(sender, e);
        }
    }
    }

