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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desktopAPP
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }


        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.staff_DataSet);

        }

        private void log_in_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'staff_DataSet.staff' 資料表。您可以視需要進行移動或移除。
            this.staffTA.Fill(this.staff_DataSet.staff);

        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.home.Show();
        }
        private void SendutBT_Click(object sender, EventArgs e)
        {
            if(SendutBT.Text != "")
            {
                for (int i=0;i<staff_DataSet.staff.Rows.Count;i++)
                {
                    if (staff_DataSet.staff.Rows[i][0].ToString() == idTB.Text)
                    {
                        this.Close();
                        TextbookChangedSystem booksystem = new TextbookChangedSystem();
                        booksystem.Show();
                        booksystem.setHiLabel("Hi, "+staff_DataSet.staff.Rows[i][1].ToString());
                    }
                }
            }
            else
                MessageBox.Show("Please enter your ID!", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        bool idTBHasText = false;
        private void idTB_Enter(object sender, EventArgs e)
        {
            if (idTBHasText == false)
                idTB.Text = "";

            idTB.ForeColor = Color.Black;
            idTB.PasswordChar = '*';
        }
        private void idTB_Leave(object sender, EventArgs e)
        {
            if (idTB.Text == "")
            {
                idTB.Text = "e-mail";
                idTB.ForeColor = Color.DarkGray;
                idTBHasText = false;
            }
            else
                idTBHasText = true;
        }

    }

}
