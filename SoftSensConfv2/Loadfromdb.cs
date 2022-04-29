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
    public partial class Loadfromdb : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public Loadfromdb()
        {
            InitializeComponent();
            ImportToComboBox();
        }
        void ImportToComboBox()
        {
            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT Instrument_Tag FROM Instrument_Configuration ORDER BY Instrument_Tag ASC";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                InstTagfromDB.Items.Add(sqlQuery);
            }
            con.Close();
        }
    
            private void ConfInstTag_Click(object sender, EventArgs e)
        {

            {
                if (InstTagfromDB.Text != "")
                {
                    string Combobox, sqlQuery;
                    try
                    {
                        //Oppretter en connection mot databasen med string definert i App.config:
                        SqlConnection con = new SqlConnection(conMCU);
                        Combobox = InstTagfromDB.Text;        //Verdien som skal inn i databasen
                                                             //hentes fra combobox og lagres i carMake-variabelen
                        /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                        sqlQuery = String.Concat(@"UPDATE PLACEHOLDER_DATA SET Instrument_Tag =('", Combobox, "') WHERE id = 1"); //Setter variabelen carMake inn i sql-spørringen
                        con.Open();
                        SqlCommand command = new SqlCommand(sqlQuery, con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    this.Close();


                }

                else

                {
                    MessageBox.Show("Please choose one of the Instrument tags avaiable!");
                }
            }
            }
    }
}
