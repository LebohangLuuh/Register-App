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

namespace Register_App
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sqlserver.dynamicdna.co.za;Initial Catalog=register-app-Lebohang;User ID=BBD;Password=123 ");
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtFname.Clear();

            txtFname.Focus();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


            try
            {

            con.Open();

            SqlCommand com = new SqlCommand("INSERT INTO Student VALUES( '"+txtFname.Text+"','"+txtEmail.Text+"' )", con);
           
            com.ExecuteNonQuery();

            MessageBox.Show("Registered!");
           
            con.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("failed to connect to database");
            }

            
        }
    }
}
