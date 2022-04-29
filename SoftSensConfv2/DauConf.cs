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
    public partial class DauConf : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public DauConf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newdau dau = new newdau();
            dau.FormClosed += dau_FormClosed;
            dau.ShowDialog(this);
        }

       

            private void EditDAU_Click(object sender, EventArgs e)
        {
            EditDAU editdau = new EditDAU();
            editdau.FormClosed += editdau_FormClosed;
            editdau.ShowDialog(this);
        }

        private void DauConf_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT CURRENTID FROM CurrentID ORDER BY CURRENTID ASC";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                Currrdcid.Text = sqlQuery;
            }
            con.Close();
            try
            {

                SqlDataAdapter sda;
                string sqlQuery1 = "SELECT * FROM Arbeidskrav2OOP.dbo.Data_Acquisition_Unit WHERE RDC_ID LIKE (SELECT CURRENTID FROM Arbeidskrav2OOP.dbo.CurrentID)";
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery1, con);
                dt = new DataTable();
                sda.Fill(dt);
                avaiabledau.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
            private void dau_FormClosed(object sender, FormClosedEventArgs e)
            {
                try
                {
                SqlConnection con = new SqlConnection(conMCU);
                SqlDataAdapter sda;
                    string sqlQuery1 = "SELECT * FROM Arbeidskrav2OOP.dbo.Data_Acquisition_Unit WHERE RDC_ID LIKE (SELECT CURRENTID FROM Arbeidskrav2OOP.dbo.CurrentID)";
                    DataTable dt;
                    con.Open();
                    sda = new SqlDataAdapter(sqlQuery1, con);
                    dt = new DataTable();
                    sda.Fill(dt);
                    avaiabledau.DataSource = dt;
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        private void editdau_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conMCU);
                SqlDataAdapter sda;
                string sqlQuery1 = "SELECT * FROM Arbeidskrav2OOP.dbo.Data_Acquisition_Unit WHERE RDC_ID LIKE (SELECT CURRENTID FROM Arbeidskrav2OOP.dbo.CurrentID)";
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery1, con);
                dt = new DataTable();
                sda.Fill(dt);
                avaiabledau.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        }
    }
    

