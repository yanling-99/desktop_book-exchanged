using desktopAPP.Staff_DataSetTableAdapters;
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
    }
}
