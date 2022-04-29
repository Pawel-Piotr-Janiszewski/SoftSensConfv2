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

    public partial class Form3 : Form
    {
        //Lists used for plotting 
        List<int> rawReading = new List<int>();
        List<float> ScaledReading = new List<float>();
        List<string> timeStampRaw = new List<string>();
        List<string> timeStampScaled = new List<string>();
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public Form3()
        {
            MessageBoxManager.Yes = "Database";
            MessageBoxManager.No = "File";
            MessageBoxManager.Register();

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
            MonitorTimer.Interval = 2000;
            MonitorTimer.Tick += new EventHandler(MonitorTimer_Tick);                               //Timer for plotting and sensor data
            AlarmTimer.Interval = 1500;
            AlarmTimer.Tick += new EventHandler(AlarmTimer_Tick);                                   //Timer for alarms (related to plotting and sensor data)

        }
        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)                      //DataRecievedHandler function
        {
            string RecievedData = ((SerialPort)sender).ReadLine();                                  //DataRecievedHandler saves all data to the string
            string[] recievedData = RecievedData.Split(';');                                        //which it later splits into an array that is used later in the software
            int iVab;                                                                               //placeholder int used in plotting


            if (recievedData[0] == "readconf")                                                      //if readconf is recieved
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate                                  //necessary so that cross-thread error is fixed
                {//Function replaces placeholder text in labels in current config with the data recieved from the instrument
                    SerialNum.Text = recievedData[1];
                    InstID.Text = SerialNum.Text;
                    UpperVal.Text = recievedData[3];
                    LowVal.Text = recievedData[2];
                    AlarmUp.Text = recievedData[5];
                    AlarmLow.Text = recievedData[4];

                });

            }

            if (recievedData[0] == "writeconf" && recievedData[1] == "1\r")                         //if writeconf is recieved and the password typed is correct
            {
                MessageBox.Show("Correct Password! Instrument Configuration has been changed!");
                serialPort1.WriteLine("readconf");                                                  //automatically displays the new current config

            }

            if (recievedData[0] == "writeconf" && recievedData[1] == "0\r")                          //if writeconf is recieved but the password is incorrect
            {
                MessageBox.Show("Wrong Password! Try again! Instrument Configuration has not been changed!");
            }
            //Readstatus function is used to display alarms from instrument. Below are the statements that display the alarms back to the user.

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

            if (recievedData[0] == "readraw")                                                      //if readraw is received
            {
                string f1, f2, f3, f4, f5, sqlQuery;
                f1 = DataLogID.Text;
                f2 = InstID.Text;
                f3 = DateTime.Now.ToString();
                f4 = recievedData[1];
                f5 = AlarmStatus.Text;

                MonitorList.Invoke((MethodInvoker)delegate
                {
                    MonitorList.Items.Add("RawData" + "," + DateTime.Now.ToString() + ", " + recievedData[1] + "\n"); //Data string displayed in the listbox
                    if (int.TryParse(recievedData[1], out iVab))
                    {   //Plotting
                        rawReading.Add(iVab);
                        timeStampRaw.Add(DateTime.Now.ToString());
                        MonitorList.Invoke((MethodInvoker)delegate
                        {
                            MonitorPlot.Series["Instrument Values"].Points.DataBindXY(timeStampRaw, rawReading);
                        });
                        MonitorList.Invoke((MethodInvoker)delegate
                        { MonitorPlot.Invalidate(); });
                    }
                    else
                    {   //User feedback if above fails
                        MessageBox.Show("Didnt work");
                    }
                });

                try
                {

                    SqlConnection con = new SqlConnection(conMCU);

                    //hentes fra combobox og lagres i carMake-variabelen
                    /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                    sqlQuery = String.Concat(@"INSERT INTO DataLog (DataLog_ID, Instrument_Tag,TimeStamp,RawData,AlarmStatus) VALUES ('", f1, "','", f2, "','", f3, "','", f4, "','", f5, "')");
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }

            if (recievedData[0] == "readscaled")                                                   //if readscaled is received
            {
                string f1, f2, f3, f4, f5, sqlQuery;
                f1 = DataLogID.Text;
                f2 = InstID.Text;
                f3 = DateTime.Now.ToString();
                f4 = recievedData[1];
                f5 = AlarmStatus.Text;
                float scaled;                                                                      //placeholder float variable
                MonitorList.Invoke((MethodInvoker)delegate
                {
                    MonitorList.Items.Add("ScaledData" + "," + DateTime.Now.ToString() + "," + recievedData[1] + "\n"); //Data string displayed in listbox
                    string data = recievedData[1];
                    scaled = float.Parse(data, CultureInfo.InvariantCulture);
                    timeStampScaled.Add(DateTime.Now.ToString());
                    ScaledReading.Add(scaled);
                    //Plotting
                    MonitorPlot.Series["Instrument Values"].Points.DataBindXY(timeStampScaled, ScaledReading);
                    MonitorPlot.Invalidate();

                });
                try
                {

                    SqlConnection con = new SqlConnection(conMCU);

                    //hentes fra combobox og lagres i carMake-variabelen
                    /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                    sqlQuery = String.Concat(@"INSERT INTO DataLog (DataLog_ID, Instrument_Tag,TimeStamp,ScaledData,AlarmStatus) VALUES ('", f1, "','", f2, "','", f3, "','", f4, "','", f5, "')");
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }


        private void ConnectButt_Click(object sender, EventArgs e)                                //Connect button pressed
        {
            try
            {
                serialPort1.Close();
                serialPort1.PortName = ComBox.Text;
                StatusTimer.Start();
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
                    MessageBox.Show("Invalid Port!");
                    SerialStatusTextBox.Text = text;
                    SerialLightStatus.BackColor = Color.Red;

                }
                else if (ex is UnauthorizedAccessException)
                {
                    string text = "Cant Connect!";
                    StatusTimer.Stop();
                    MessageBox.Show("Cannot Connect! Port might be in use ");
                    SerialStatusTextBox.Text = text;
                    SerialLightStatus.BackColor = Color.Red;
                }
                else
                {
                    string text = "....";
                    StatusTimer.Stop();
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
            MessageBox.Show("Disconnected!");
            SerialStatusTextBox.Text = text;
            SerialLightStatus.BackColor = Color.Red;
            ConStatus.Text = SerialStatusTextBox.Text;
            ConnectionLightStatus.BackColor = SerialLightStatus.BackColor;
            //duplicate status labels and "lights" so that the connection status is displayed in every tab for the user




        }

        private void CurrentConf_Click(object sender, EventArgs e)                                      //Current config clicked
        {
            MessageBox.Show("Current Config Loaded!");                                                 //User feedback
            serialPort1.WriteLine("readconf");                                                         //readconf sent to the instrument

        }


        private void StatusTimer_Tick(object sender, EventArgs e)                                   //Statustimer
        {
            if (serialPort1.IsOpen)                                                                 //If theres a connection to the instrument
            {
                string text = "Connected!";
                SerialStatusTextBox.Text = text;
                SerialLightStatus.BackColor = Color.Green;
                ConStatus.Text = SerialStatusTextBox.Text;
                ConnectionLightStatus.BackColor = SerialLightStatus.BackColor;
                //Displays the message in the duplicate labels and light boxes on other tabs

            }
            else if (serialPort1.IsOpen == false)                                                  //if connection is lost to the instrument
            {
                StatusTimer.Stop();                                                                //The timer stops
                MessageBox.Show("Connection lost to the instrument!");
                string text = "Disconnected!";
                SerialStatusTextBox.Text = text;
                SerialLightStatus.BackColor = Color.Red;
                ConStatus.Text = SerialStatusTextBox.Text;
                ConnectionLightStatus.BackColor = SerialLightStatus.BackColor;
                //Like above the status text and light color is duplicated accros the tabs
            

            }
        }
        private string getNewSerial()                                                             //Function returning new name input from user
        {

            return NewSerial.Text;


        }
        private float getNewUpperValue()                                                         //Function returning new upper value input from user
        {
            return float.Parse(NewUpper.Text);
        }

        private float getNewLowerValue()                                                        //Function returning new lower value input from user
        {
            return float.Parse(NewLower.Text);
        }

        private int getNewAlarmUpper()                                                         //Function returning new upper alarm input from user
        {
            return int.Parse(NewAlarmUP.Text);
        }
        private int getNewAlarmLower()                                                         //Function returning new lower alarm input from user
        {
            return int.Parse(NewAlarmLow.Text);
        }

        private string ValidateText(string n, float lv, float uv, int al, int au)           //Function that validates the new user inputs and runs a series
        {                                                                                   //of checks to ensure that the input is correct and can be used by the instrument
            if (n.Length == 0 || n.Length > 10)
            {
                MessageBox.Show("Serial Number Lenght is invalid! It cannot be longer than 10 characters or have 0 characters!");
                return " ";
            }
            if (lv < 0.0 || lv > 500.0)
            {
                MessageBox.Show("lower value is out of range 0.0 - 500");
                return " ";
            }
            if (uv > 1000.0)
            {
                MessageBox.Show("Upper value is out of range! (above 1000)");
                return " ";
            }
            if (uv == lv)
            {
                MessageBox.Show("The upper and lower value cannot be the same!");
                return " ";
            }
            if (uv < lv)
            {
                MessageBox.Show("The upper value cannot be smaller than lower value!");
            }
            if (al < 0.0 || al > 1000)
            {
                MessageBox.Show("Alarm Lower is out of range!(less than 0 or more than 1000");
                return " ";
            }
            if (au > 1000.0 || au < 0.0)
            {
                MessageBox.Show("Alarm Upper is out of range 0.0 - 1000.0");
                return " ";
            }
            if (au < al)
            {
                MessageBox.Show("Alarm Upper cannot be smaller than Alarm Lower!");
                return " ";
            }
            if (au == al)
            {
                MessageBox.Show("Alarm Upper and Alarm Lower cannot be the same!");
                return " ";
            }
            else                                                                                //If all the checks above are passed return the string
            {
                string newn = n.ToString();
                string newlv = lv.ToString();
                string newuv = uv.ToString();
                string newal = al.ToString();
                string newau = au.ToString();
                string[] newargs = { newn, newlv, newuv, newal, newau };
                string NewConf = string.Join(";", newargs);                                     //String joined with ; that the instrument needs
                return NewConf;                                                                 //New config returned 
                



            }
        }

        private void SendInstCont_Click(object sender, EventArgs e)                             //Send new config button is pressed
        {

            string n = getNewSerial();
            float lv = getNewLowerValue();
            float uv = getNewUpperValue();
            int al = getNewAlarmLower();
            int au = getNewAlarmUpper();
            string sendAll = ValidateText(n, lv, uv, al, au);                                   //Validate text function checks for user input
            string passwordbox = Interaction.InputBox("Authentication is required to update instrument values. Please enter password:", "Authentication Required", "..", 10, 10);
            serialPort1.WriteLine("writeconf" + ">" + passwordbox + ">" + sendAll);               //Combined command is sent to the instrument for final check


        }

        private void LoadConf_Click(object sender, EventArgs e)                             //If load config from file is pressed
        {
            DialogResult dborfile = MessageBox.Show("Would you like to load config from the database or file?", "", MessageBoxButtons.YesNoCancel);
            if (dborfile == DialogResult.No)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)                                //if file is chosed and opened
                {
                    string filename = openFileDialog1.FileName;
                    StreamReader inputfile = new StreamReader(@filename);

                    string text = inputfile.ReadLine();
                    string[] splitelements = text.Split(';');                                       //array consisting of splitted string from the file
                                                                                                    //The splitted elements are beign filled into the new config boxes
                    NewSerial.Text = splitelements[0];
                    NewUpper.Text = splitelements[2];
                    NewLower.Text = splitelements[1];
                    NewAlarmLow.Text = splitelements[3];
                    NewAlarmUP.Text = splitelements[4];
                    
                }
            }
            else if (dborfile == DialogResult.Yes)
            {
                Loadfromdb dbtag = new Loadfromdb();
                dbtag.FormClosed += dbtag_FormClosed;
                dbtag.ShowDialog(this);
                
            }


            
        }

        private void dbtag_FormClosed(object sender, FormClosedEventArgs e)
        {
            string curr_tag = "1";
            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT Instrument_Tag FROM PLACEHOLDER_DATA WHERE id = 1";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                curr_tag = sqlQuery;
            }
            con.Close();
            string sqlQueryAr = "1";
            string sqlQ1 = "2";
            string sqlQ2 = "3";
            string sqlQ3 = "4";
            
            
            SqlConnection con1 = new SqlConnection(conMCU);
            sqlQueryAr = "SELECT LowerVal, UpperVal, AlarmLow, AlarmHigh FROM Arbeidskrav2OOP.dbo.Instrument_Configuration WHERE Instrument_Tag LIKE (SELECT Instrument_Tag FROM Arbeidskrav2OOP.dbo.PLACEHOLDER_DATA)";
            SqlCommand sql1 = new SqlCommand(sqlQueryAr, con1);
            con1.Open();
            SqlDataReader dr1 = sql1.ExecuteReader();
            while (dr1.Read() == true)
            {
               sqlQueryAr = dr1[0].ToString();
               sqlQ1 = dr1[1].ToString();
               sqlQ2 = dr1[2].ToString();
               sqlQ3 = dr1[3].ToString();
                

            }
            con1.Close();
            
            NewSerial.Text = curr_tag;
            NewUpper.Text = sqlQ1  ;
            NewLower.Text = sqlQueryAr;
            NewAlarmUP.Text =sqlQ3;
            NewAlarmLow.Text =sqlQ2;

        }
        private void SaveConf_Click(object sender, EventArgs e)                                //Function that saves current config to file
        {

            string n = NewSerial.Text;
            string lv = NewLower.Text;
            string uv = NewUpper.Text;
            string al = NewAlarmLow.Text;
            string au = NewAlarmUP.Text;
            string[] sa = { n, lv, uv, al, au };
            string savearray = string.Join(";", sa);                                        //The array consisting of current config is joined into a string
            SaveFileDialog SaveConfigDialog = new SaveFileDialog();
            SaveConfigDialog.Filter = "txt files (.ssc)|.scc|All files (.)|.";              //File is saved as .ssc file
            SaveConfigDialog.Title = "Save Current Configuration";

            DialogResult dborfile = MessageBox.Show("Would you like to save config to the database or file?", "", MessageBoxButtons.YesNoCancel);
            if (dborfile == DialogResult.No)
            {
                if (SaveConfigDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream s = File.Open(SaveConfigDialog.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);
                    {
                        sw.Write(savearray);
                        sw.Close();
                    }
                    MessageBox.Show("File Saved Succesfully!");                                 //User feedback upon succes
                }


            }
            if (dborfile == DialogResult.Yes)
            {
                try
                {
                    string sqlQuery;
                    //Oppretter en connection mot databasen med string definert i App.config:
                    SqlConnection con = new SqlConnection(conMCU);
                    //hentes fra combobox og lagres i carMake-variabelen
                    /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                    sqlQuery = String.Concat(@"UPDATE PLACEHOLDER_DATA SET Instrument_Tag =('", sa[0], "'), LowerVal = ('", sa[1], "'), UpperVal = ('", sa[2], "'), AlarmLow= ('", sa[3], "'), AlarmHigh= ('", sa[4], "')  WHERE id = 1"); //Setter variabelen carMake inn i sql-spørringen
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                NewConfToDB confToDB = new NewConfToDB();
                confToDB.ShowDialog(this);
            }

        }

        private void Readraw_Click(object sender, EventArgs e)                              //Read raw data from the instrument
        {
            if (DataLogID.Text != "")
            {
                serialPort1.WriteLine("readconf");
                string text = "DataType,Timestamp,Values\n";                                    //Header for the MonitorList
                MonitorList.Items.Clear();
                DataLogID.Enabled = false;
                ScaledVal.Enabled = false;                                                      //Greying out of the scaled element (So that user wont accidentally press it while monitoring)
                MonitorTimer.Start();                                                           //Monitor and alarm timers start
                AlarmTimer.Start();
                MonitorList.Items.Add(text);                                                    //The header is added to the data feed
            }
            else
            {
                MessageBox.Show("DataLogID is required in order to start monitoring. Please enter it and start monitoring again");
            }
        }

        private void StopMonitoring_Click(object sender, EventArgs e)                       //Stop monitoring is pressed
        {
            ScaledVal.Enabled = true;  //The scaled element is avaiable to be used again
            DataLogID.Enabled = true;
            string text = "-";                                                              //Placeholder text for the alarm status
            MonitorTimer.Stop();                                                            //Monitor  and alarm timer stops
            AlarmTimer.Stop();
            MessageBox.Show("Monitoring stopped! All the data has been saved to the database automatically");
            AlarmStatus.Text = text;
            AlarmLightStatus.BackColor = Color.White;
        }

        private void SaveSensorData_Click(object sender, EventArgs e) //Save sensor data button (in case user accidentally clicks no after the reading is taken)
        {
            SaveFileDialog SaveMonitoringDialog = new SaveFileDialog();
            SaveMonitoringDialog.Filter = "CSV file (.csv)|.csv|All files (.)|.";   //Data is saved to a .csv file that Excel or other spreadsheet software can open
            SaveMonitoringDialog.Title = "Save Monitoring Data";


            if (SaveMonitoringDialog.ShowDialog() == DialogResult.OK)
            {
                string save;
                Stream s = File.Open(SaveMonitoringDialog.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(s);
                {

                    foreach (var item in MonitorList.Items)
                    {
                        save = item.ToString();
                        sw.Write(save);
                        
                    }

                    sw.Close();
                }
                MessageBox.Show("File Saved Succesfully!");
            }
        }

        private void MonitorTimer_Tick(object sender, EventArgs e)              //Monitor timer 
        {
            if (ScaledVal.Checked)                                              //If scaled checked
            {

                string text = "Scaled Data";
                serialPort1.WriteLine("readscaled");
                MonitorType.Text = text;


            }
            else                                                                //if scaled textbox is not checked (raw reading)
            {

                string text = "Raw Data";
                serialPort1.WriteLine("readraw");
                MonitorType.Text = text;
            }
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)               //alarm timer
        {
            serialPort1.WriteLine("readstatus");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT CURRENTID FROM CurrentID ORDER BY CURRENTID ASC";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                RDCIDINST.Text = sqlQuery;
            }
            con.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectButt_Click(sender ,e);
        }
    }
}
