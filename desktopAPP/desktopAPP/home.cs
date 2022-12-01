using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopAPP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SighupBT_Click(object sender, EventArgs e)
        {
            sign_up Sighup = new sign_up();
            Sighup.Show();
            this.Hide();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            log_in Login = new log_in();
            Login.Show();
            this.Hide();
        }
    }
}
