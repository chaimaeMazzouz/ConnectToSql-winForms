using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace connectToSql_winForm
{
    public partial class Form1 : Form
    {
        SqlConnection oConnection;
        public Form1()
        {
            InitializeComponent();
            string strConnection = @"data source =DESKTOP-7TC9CTO\SQLEXPRESS;database=VolAvion;Integrated Security=True";
            oConnection = new SqlConnection(strConnection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                oConnection.Open();
                lblTest.Text = oConnection.State.ToString();
                lblTest.ForeColor = Color.Green;
            }
            catch (Exception exp)
            {
                MessageBox.Show("l'erreur suivante a été rencontrée : " + exp.Message);
            }
           
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            oConnection.Close();
            lblTest.Text = oConnection.State.ToString();
            lblTest.ForeColor = Color.Red;
        }
    }
}
