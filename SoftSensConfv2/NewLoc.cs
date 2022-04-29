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
    public partial class NewLoc : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public NewLoc()
        {
            InitializeComponent();
        }

        private void AddLoc_Click(object sender, EventArgs e)
        {
            if (LocationID.Text != "" && Desc.Text != "")
            {
                string f1, f2, sqlQuery;
                f1 = LocationID.Text;
                f2 = Desc.Text;
                try
                {

                    SqlConnection con = new SqlConnection(conMCU);
                    //hentes fra combobox og lagres i carMake-variabelen
                    /* Lagrer spørringen legger en ny "CarMake"-verdi i CARMAKER-tabellen */
                    sqlQuery = String.Concat(@"INSERT INTO Location (Location_ID, Location_description) VALUES ('", f1, "','", f2, "')");
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Location has been added to the database!");
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
