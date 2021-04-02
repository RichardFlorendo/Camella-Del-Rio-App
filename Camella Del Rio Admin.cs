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

namespace WindowsFormsApp1
{
    public partial class login_form : Form
    {
        SqlConnection con = new SqlConnection();
        public login_form()
        {
            InitializeComponent();
        }

        public static string SetValueForText1 = "";

        private void loginin_button_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5GGVMG1O\\RICHARD;Initial Catalog=admin;Persist Security Info=True;User ID=sa;Password=1522");
            SqlDataAdapter sd1 = new SqlDataAdapter("SELECT COUNT(*) FROM [dbo].[AdminLogin] WHERE Username='" + username_tb.Text + "' AND Password='" + password_tb.Text + "'", con);
            DataTable dt1 = new DataTable();
            sd1.Fill(dt1);

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT COUNT(*) FROM [dbo].[PMLogin] WHERE Username='" + username_tb.Text + "' AND Password='" + password_tb.Text + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            if (dt1.Rows[0][0].ToString() == "1")
            {
                SetValueForText1 = username_tb.Text;

                this.Hide();
                var adminlog = new admindashboard_form();
                adminlog.Closed += (s, args) => this.Close();
                adminlog.Show();
            }

            else if (dt2.Rows[0][0].ToString() == "1")
            {
                SetValueForText1 = username_tb.Text;

                this.Hide();
                var pmlog = new pmdashboard_form();
                pmlog.Closed += (s, args) => this.Close();
                pmlog.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void fpassowrd_linklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var forgot = new forgotpass_form();
            forgot.Closed += (s, args) => this.Close();
            forgot.Show();
        }
    }
}

