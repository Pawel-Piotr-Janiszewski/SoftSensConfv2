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
    public partial class AddMan : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public AddMan()
        {
            InitializeComponent();
        }

        private void newman_Click(object sender, EventArgs e)
        {
            if (makerid.Text != "" && makername.Text != "")
            {
                string f1, f2, sqlQuery;
                f1 = makerid.Text;
                f2 = makername.Text;
                try
                {

                    SqlConnection con = new SqlConnection(conMCU);
                    //hentes fra combobox og lagres i carMake-variabelen
                    /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                    sqlQuery = String.Concat(@"INSERT INTO Maker_Data (Maker_ID, Maker_Name) VALUES ('", f1, "','", f2, "')");
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Manufacturer has been added to the database!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter the data in the required fields!");
            }
        }
    }
    }

