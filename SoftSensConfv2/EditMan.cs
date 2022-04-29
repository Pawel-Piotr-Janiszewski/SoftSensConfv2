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

    public partial class EditMan : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public EditMan()
        {
            InitializeComponent();
        }

        private void EditMan_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery1;
                SqlConnection con = new SqlConnection(conMCU);
                SqlDataAdapter sda;
                sqlQuery1 = "SELECT * FROM Maker_Data";
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery1, con);
                dt = new DataTable();
                sda.Fill(dt);
                Mandata.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void AddMan_Click(object sender, EventArgs e)
        {
            AddMan addmann = new AddMan();
            addmann.FormClosed += addmann_FormClosed;
            addmann.ShowDialog(this);
        }
        private void addmann_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string sqlQuery1;
                SqlConnection con = new SqlConnection(conMCU);
                SqlDataAdapter sda;
                sqlQuery1 = "SELECT * FROM Maker_Data";
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery1, con);
                dt = new DataTable();
                sda.Fill(dt);
                Mandata.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }
        }
}
