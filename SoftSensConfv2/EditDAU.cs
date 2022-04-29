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
    public partial class EditDAU : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public EditDAU()
        {
            InitializeComponent();
        }

        private void EditDAU_Load(object sender, EventArgs e)
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
                Locationid.Items.Add(sqlQuery4);

            }
            con4.Close();
            SqlConnection con5 = new SqlConnection(conMCU);
            string sqlQuery5 = "SELECT DAU_ID FROM Arbeidskrav2OOP.dbo.Data_Acquisition_Unit WHERE RDC_ID LIKE (SELECT CURRENTID FROM Arbeidskrav2OOP.dbo.CurrentID)";
            SqlCommand sql5 = new SqlCommand(sqlQuery5, con5);
            con5.Open();
            SqlDataReader dr5 = sql5.ExecuteReader();
            while (dr5.Read() == true)
            {
                sqlQuery5 = dr5[0].ToString();
                DAUID.Items.Add(sqlQuery5);

            }
            con5.Close();
        }

        private void UpdateDAU_Click(object sender, EventArgs e)
        {
            if (DAUID.Text != "" && Locationid.Text != "")
            {
                string f1,f2;
                f1 = Locationid.Text;
                f2 = DAUID.Text;
                
                try
                {
                    //Oppretter en connection mot databasen med string definert i App.config:
                    SqlConnection con = new SqlConnection(conMCU);
                    string sqlQuery;
                    con.Open();
                    sqlQuery = String.Concat(@"UPDATE Data_Acquisition_Unit SET Location_id=('", f1, "') WHERE DAU_ID=('", f2, "')");
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Location Updated!");
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