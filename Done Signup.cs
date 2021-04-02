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
    public partial class signin_form2 : Form
    {
        public signin_form2()
        {
            InitializeComponent();
        }

        private void dsignup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var acceptance = new acceptance_form();
            acceptance.Closed += (s, args) => this.Close();
            acceptance.Show();
        }

        private void bsignup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signin1 = new signin_form1();
            signin1.Closed += (s, args) => this.Close();
            signin1.Show();
        }
    }
}
