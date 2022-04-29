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
    public partial class ViewData : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public ViewData()
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
                Tagfromdb.Items.Add(sqlQuery);
            }
            con.Close();
        }

        private void DataView_Click(object sender, EventArgs e)
        {
            if (Tagfromdb.Text != "")
            {
                string Combobox, sqlQuery;
                try
                {
                    //Oppretter en connection mot databasen med string definert i App.config:
                    SqlConnection con = new SqlConnection(conMCU);
                    Combobox = Tagfromdb.Text;        //Verdien som skal inn i databasen
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
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(conMCU);
                        SqlDataAdapter sda;
                        string sqlQuery1 = "SELECT * FROM Arbeidskrav2OOP.dbo.DataLog WHERE Instrument_tag LIKE (SELECT Instrument_Tag FROM Arbeidskrav2OOP.dbo.PLACEHOLDER_DATA)";
                        DataTable dt;
                        con.Open();
                        sda = new SqlDataAdapter(sqlQuery1, con);
                        dt = new DataTable();
                        sda.Fill(dt);
                        dataGrid.DataSource = dt;
                        con.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose one of the instrument tags avaiable");
            }
        }
    }
}
