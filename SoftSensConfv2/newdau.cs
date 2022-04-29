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
    public partial class newdau : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public newdau()
        {
            InitializeComponent();
        }

        private void newdau_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT CURRENTID FROM CurrentID ORDER BY CURRENTID ASC";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                rdcid.Text = sqlQuery;
            }
            con.Close();

            SqlConnection con4 = new SqlConnection(conMCU);
            string sqlQuery4 = "SELECT Location_id FROM Location";
            SqlCommand sql4 = new SqlCommand(sqlQuery4, con4);
            con4.Open();
            SqlDataReader dr4 = sql4.ExecuteReader();
            while (dr4.Read() == true)
            {
                sqlQuery4 = dr4[0].ToString();
                LocationID.Items.Add(sqlQuery4);

            }
            con4.Close();
        }

        private void adddau_Click(object sender, EventArgs e)
        {
            if (dauid.Text != "" && LocationID.Text !="")
            {
                string f1, f2, f3;
                f1 = rdcid.Text;
                f2 = LocationID.Text;
                f3 = dauid.Text;
                try
                {
                    //Oppretter en connection mot databasen med string definert i App.config:
                    SqlConnection con = new SqlConnection(conMCU);
                    string sqlQuery;
                    sqlQuery = String.Concat(@"INSERT INTO Data_Acquisition_Unit (RDC_ID,Location_id,DAU_ID) VALUES('", f1, "','", f2, "','", f3,"')");
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New DAU Created!");
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Please type in the required data before proceeding");
            }
        }
    }
}
