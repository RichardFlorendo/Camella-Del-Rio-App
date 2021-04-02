using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class signin_form1 : Form
    {
        public signin_form1()
        {
            InitializeComponent();
        }

        private void lname_tb_Click(object sender, EventArgs e)
        {

        }

        private void next_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signin = new signin_form1();
            var signin2 = new signin_form2();
            signin2.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new login_form();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
