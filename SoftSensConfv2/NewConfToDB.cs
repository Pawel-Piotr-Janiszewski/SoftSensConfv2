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
    public partial class NewConfToDB : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public NewConfToDB()
        {
            InitializeComponent();
        }

        private void UploadtoDB_Click(object sender, EventArgs e)
        {
            string f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, sqlQuery;
            f1 = tagbox.Text;
            f2 = Makeridbox.Text;
            f3 = Channelnobox.Text;
            f4 = FrequencyBox.Text;
            f5 = ModelBox.Text;
            f6 = InstTypeBox.Text;
            f7 = ServDescBox.Text;
            f8 = LocationIDBox.Text;
            f9 = IOTypeBox.Text;
            f10 = LowerValBox.Text;
            f11 = UpperValBox.Text;
            f12 = AlarmLowBox.Text;
            f13 = AlarmHighBox.Text;
            f14 = DAU_IDBox.Text;
            try
            {
            
                SqlConnection con = new SqlConnection(conMCU);
                
                                           //hentes fra combobox og lagres i carMake-variabelen
                /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                sqlQuery = String.Concat(@"INSERT INTO Instrument_Configuration (Instrument_Tag,Maker_Name,ChannelNO,Frequency,Instrument_Model,Instrument_Type,ServiceDescription,Location_id,IO_Type,
                LowerVal,UpperVal,AlarmLow,AlarmHigh,DAU_ID) VALUES ('", f1, "','",f2,"','",f3,"','",f4,"','",f5,"','",f6,"','",f7,"','",f8,"','",f9,"','",f10,"','",f11,"','",f12,"','",f13,"','",f14,"')");
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Configuration Uploaded Successfully!");
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void NewConfToDB_Load(object sender, EventArgs e)
        {
            string curr_tag = "1";
            string sqlQueryAr = "1";
            string sqlQ1 = "2";
            string sqlQ2 = "3";
            string sqlQ3 = "4";
            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT Instrument_Tag, LowerVal, UpperVal,AlarmLow, AlarmHigh FROM PLACEHOLDER_DATA WHERE id = 1";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                curr_tag = dr[0].ToString();
                sqlQueryAr = dr[1].ToString();
                sqlQ1 = dr[2].ToString();
                sqlQ2 = dr[3].ToString();
                sqlQ3 = dr[4].ToString();
            }
            con.Close();

            tagbox.Text = curr_tag;
            UpperValBox.Text = sqlQ1;
            LowerValBox.Text = sqlQueryAr;
            AlarmHighBox.Text = sqlQ3;
            AlarmLowBox.Text = sqlQ2;

            SqlConnection con1 = new SqlConnection(conMCU);
            string sqlQuery1 = "SELECT Maker_Name FROM Maker_Data";
            SqlCommand sql1 = new SqlCommand(sqlQuery1, con1);
            con1.Open();
            SqlDataReader dr1 = sql1.ExecuteReader();
            while (dr1.Read() == true)
            {
                sqlQuery1 = dr1[0].ToString();
                Makeridbox.Items.Add(sqlQuery1);

            }
            con1.Close();

            SqlConnection con2 = new SqlConnection(conMCU);
            string sqlQuery2 = "SELECT ChannelNO FROM ChannelNO ORDER BY ChannelNO ASC";
            SqlCommand sql2 = new SqlCommand(sqlQuery2, con2);
            con2.Open();
            SqlDataReader dr2 = sql2.ExecuteReader();
            while (dr2.Read() == true)
            {
                sqlQuery2 = dr2[0].ToString();
                Channelnobox.Items.Add(sqlQuery2);

            }
            con2.Close();

            SqlConnection con3 = new SqlConnection(conMCU);
            string sqlQuery3 = "SELECT Frequency FROM Frequency ORDER BY Frequency ASC";
            SqlCommand sql3 = new SqlCommand(sqlQuery3, con3);
            con3.Open();
            SqlDataReader dr3 = sql3.ExecuteReader();
            while (dr3.Read() == true)
            {
                sqlQuery3 = dr3[0].ToString();
                FrequencyBox.Items.Add(sqlQuery3);

            }
            con3.Close();
            
            SqlConnection con4 = new SqlConnection(conMCU);
            string sqlQuery4 = "SELECT Location_id FROM Location";
            SqlCommand sql4 = new SqlCommand(sqlQuery4, con4);
            con4.Open();
            SqlDataReader dr4 = sql4.ExecuteReader();
            while (dr4.Read() == true)
            {
                sqlQuery4 = dr4[0].ToString();
                LocationIDBox.Items.Add(sqlQuery4);

            }
            con4.Close();

            SqlConnection con5 = new SqlConnection(conMCU);
            string sqlQuery5 = "SELECT IOType FROM IOType";
            SqlCommand sql5 = new SqlCommand(sqlQuery5, con5);
            con5.Open();
            SqlDataReader dr5 = sql5.ExecuteReader();
            while (dr5.Read() == true)
            {
                sqlQuery5 = dr5[0].ToString();
                IOTypeBox.Items.Add(sqlQuery5);

            }
            con5.Close();
            
            SqlConnection con6 = new SqlConnection(conMCU);
            string sqlQuery6 = "SELECT DAU_ID FROM Data_Acquisition_Unit";
            SqlCommand sql6 = new SqlCommand(sqlQuery6, con6);
            con6.Open();
            SqlDataReader dr6 = sql6.ExecuteReader();
            while (dr6.Read() == true)
            {
                sqlQuery6 = dr6[0].ToString();
                DAU_IDBox.Items.Add(sqlQuery6);

            }
            con6.Close();
            SqlConnection con7 = new SqlConnection(conMCU);
            string sqlQuery7 = "SELECT Instrument_Type FROM InstrumentType";
            SqlCommand sql7 = new SqlCommand(sqlQuery7, con7);
            con7.Open();
            SqlDataReader dr7 = sql7.ExecuteReader();
            while (dr7.Read() == true)
            {
                sqlQuery7 = dr7[0].ToString();
                InstTypeBox.Items.Add(sqlQuery7);

            }
            con7.Close();
        }

    }
}
