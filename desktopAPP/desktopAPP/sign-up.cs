using desktopAPP.Staff_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desktopAPP
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.home.Show();
        }

        private void SendutBT_Click(object sender, EventArgs e)
        {
            if (idTB.Text != "" && idComTB.Text!="" && nameTB.Text != "" && emailTB.Text != "")
            {
                if(idComTB.Text != idTB.Text)
                {
                    MessageBox.Show("ID not correct!", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    staffTA.InsertQuery(
                        idTB.Text,
                        nameTB.Text,
                        emailTB.Text
                    );

                    DialogResult confirm = MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(confirm == DialogResult.OK)
                    {
                        this.Close();
                        Program.home.Show();
                    }
                }
                    
            }
            else
                MessageBox.Show("The information must be filled in completely!","Warning"
                    , MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'staff_DataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTA.Fill(this.staff_DataSet.staff);
        }

        //判斷textbox是否有字
        bool idTBHasText = false; 
        bool idcomTBHasText = false;
        bool nameTBHasText = false;
        bool emailTBHasText = false;

        //idTB獲得焦點
        private void idTB_Enter(object sender, EventArgs e)
        {
            if (idTBHasText == false)
                idTB.Text = "";

            idTB.ForeColor = Color.Black;
        }

        //idTB失去焦點
        private void idTB_Leave(object sender, EventArgs e)
        {
            if (idTB.Text == "")
            {
                idTB.Text = "staff ID";
                idTB.ForeColor = Color.DarkGray;
                idTBHasText = false;
            }
            else
                idTBHasText = true;
        }
        //idcomTB
        private void idComTB_Enter(object sender, EventArgs e)
        {
            if (idcomTBHasText == false)
                idComTB.Text = "";

            idComTB.ForeColor = Color.Black;
        }
        private void idComTB_Leave(object sender, EventArgs e)
        {
            if (idComTB.Text == "")
            {
                idComTB.Text = "staff ID confirm";
                idComTB.ForeColor = Color.DarkGray;
                idcomTBHasText = false;
            }
            else
                idcomTBHasText = true;
        }
        //nameTB
        private void nameTB_Enter(object sender, EventArgs e)
        {
            if (nameTBHasText == false)
                nameTB.Text = "";

            nameTB.ForeColor = Color.Black;
        }
        private void nameTB_Leave(object sender, EventArgs e)
        {
            if (nameTB.Text == "")
            {
                nameTB.Text = "name";
                nameTB.ForeColor = Color.DarkGray;
                nameTBHasText = false;
            }
            else
                nameTBHasText = true;
        }
        //emailTB
        private void emailTB_Enter(object sender, EventArgs e)
        {
            if (emailTBHasText == false)
                emailTB.Text = "";

            emailTB.ForeColor = Color.Black;
        }
        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (emailTB.Text == "")
            {
                emailTB.Text = "e-mail";
                emailTB.ForeColor = Color.DarkGray;
                emailTBHasText = false;
            }
            else
                emailTBHasText = true;
        }
    }
}
