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
    public partial class EditLoc : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public EditLoc()
        {
            InitializeComponent();
        }

        private void EditLoc_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery1;
                SqlConnection con = new SqlConnection(conMCU);
                SqlDataAdapter sda;
                sqlQuery1 = "SELECT * FROM Location";
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery1, con);
                dt = new DataTable();
                sda.Fill(dt);
                Locationdata.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void AddNewLoc_Click(object sender, EventArgs e)
        {
            NewLoc newloc = new NewLoc();
            newloc.FormClosed += newloc_FormClosed;
            newloc.Show(this);
        }
        private void newloc_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string sqlQuery1;
                SqlConnection con = new SqlConnection(conMCU);
                SqlDataAdapter sda;
                sqlQuery1 = "SELECT * FROM Location";
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery1, con);
                dt = new DataTable();
                sda.Fill(dt);
                Locationdata.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
