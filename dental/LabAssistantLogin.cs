using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental
{
    public partial class LabAssistantLogin : Form
    {
        public LabAssistantLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Name = txtUsername.Text;
            string password = txtPassword.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Dental.mdf;Integrated Security=True;Connect Timeout=30");
            String qry = "INSERT INTO LabAssistantLoginTable Values('" + Name + "','" + password + "')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
