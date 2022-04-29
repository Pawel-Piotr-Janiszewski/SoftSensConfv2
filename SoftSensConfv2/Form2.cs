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
    public partial class Menu1 : Form
    {
        string conMCU = ConfigurationManager.ConnectionStrings["conMCU"].ConnectionString;
        public Menu1()
        {
            InitializeComponent();
        }
        

        private void Open_DAU_Click(object sender, EventArgs e)
        {
            DauConf dau_conf = new DauConf();
            dau_conf.Show(this);
        }

        private void Menu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Menu1_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conMCU);
            string sqlQuery = "SELECT CURRENTID FROM CurrentID ORDER BY CURRENTID ASC";
            SqlCommand sql = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read() == true)
            {
                sqlQuery = dr[0].ToString();
                curr_RDCval.Text = sqlQuery;
            }
            con.Close();
        }

        private void Open_Inst_conf_Click(object sender, EventArgs e)
        {
            Form3 instconf = new Form3();
            instconf.Show(this);
        }

        private void ViewData_Click(object sender, EventArgs e)
        {
            ViewData viewdat = new ViewData();
            viewdat.Show(this);
        }

        private void EditLoc_Click(object sender, EventArgs e)
        {
            EditLoc editloca = new EditLoc();
            editloca.Show(this);
        }

        private void EditMan_Click(object sender, EventArgs e)
        {
            EditMan editmann = new EditMan();
            editmann.Show(this);

        }

        private void LiveAlarm_Click(object sender, EventArgs e)
        {
            LiveAlarm livealarm = new LiveAlarm();
            livealarm.Show(this);
        }
    }
}
