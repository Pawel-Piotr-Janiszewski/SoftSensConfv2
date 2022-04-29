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
    public partial class Form1 : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            ImportToComboBox();
        }
        void ImportToComboBox()
        {
            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT RDC_ID FROM Remote_Data_Collector ORDER BY RDC_ID ASC";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                StartscreenCheckbox.Items.Add(sqlQuery);
            }
            con.Close();

        }
        private void Continue_to_main_Click(object sender, EventArgs e)
        {

            {
                if (StartscreenCheckbox.Text != "")
                {
                    string Combobox, sqlQuery;
                    try
                    {
                        //Oppretter en connection mot databasen med string definert i App.config:
                        SqlConnection con = new SqlConnection(conMCU);
                        Combobox = StartscreenCheckbox.Text; //Verdien som skal inn i databasen
                                                             //hentes fra combobox og lagres i carMake-variabelen
                        /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                        sqlQuery = String.Concat(@"UPDATE CurrentID SET CURRENTID =('", Combobox, "') WHERE ID = 1"); //Setter variabelen carMake inn i sql-spørringen
                        con.Open();
                        SqlCommand command = new SqlCommand(sqlQuery, con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    Menu1 menu1 = new Menu1();
                    menu1.Show(this);
                    

                }

                else

                {
                    MessageBox.Show("Please choose one of the RDC_ID's avaiable");
                }
            }

        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog(this);
        }
       
    }
}
