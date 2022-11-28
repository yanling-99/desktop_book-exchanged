
using desktopAPP.EditTransDataSetTableAdapters;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.COLUMNS' 資料表。您可以視需要進行移動或移除。
            this.cOLUMNSTA_searchTran.Fill(this.trans_Search_DataSet.COLUMNS);
            // TODO: 這行程式碼會將資料載入 'product_Search_DataSet1.COLUMNS' 資料表。您可以視需要進行移動或移除。
            this.cOLUMNSTA_searchPro.Fill(this.product_Search_DataSet1.COLUMNS);
            // TODO: 這行程式碼會將資料載入 'editTransDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTA_editTran.Fill(this.editTransDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'editTransDataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTA_editTran.Fill(this.editTransDataSet.Users);
            // TODO: 這行程式碼會將資料載入 'editTransDataSet.Transaction' 資料表。您可以視需要進行移動或移除。
            this.transactionTA_editTran.Fill(this.editTransDataSet.Transaction);
            // TODO: 這行程式碼會將資料載入 'edit_User_DataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTA_editUser.Fill(this.edit_User_DataSet.Users);
            // TODO: 這行程式碼會將資料載入 'edit_Product_DataSet.Transaction' 資料表。您可以視需要進行移動或移除。
            this.transactionTA_editPro.Fill(this.edit_Product_DataSet.Transaction);
            // TODO: 這行程式碼會將資料載入 'edit_Product_DataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTA_editPro.Fill(this.edit_Product_DataSet.Product);
            // TODO: 這行程式碼會將資料載入 'edit_Product_DataSet.Region' 資料表。您可以視需要進行移動或移除。
            this.regionTA_editPro.Fill(this.edit_Product_DataSet.Region);
            // TODO: 這行程式碼會將資料載入 'edit_Product_DataSet.PaymentType' 資料表。您可以視需要進行移動或移除。
            this.paymentTypeTA_editPro.Fill(this.edit_Product_DataSet.PaymentType);
            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.TransStatus' 資料表。您可以視需要進行移動或移除。
            this.transStatusTA_searchTrans.Fill(this.trans_Search_DataSet.TransStatus);

            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTA_searchTrans.Fill(this.trans_Search_DataSet.Users);
            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTA_searchTrans.Fill(this.trans_Search_DataSet.Product);
            // TODO: 這行程式碼會將資料載入 'product_Search_DataSet.PaymentType' 資料表。您可以視需要進行移動或移除。
            this.paymentTA_searchPro.Fill(this.product_Search_DataSet.PaymentType);
            // TODO: 這行程式碼會將資料載入 'product_Search_DataSet.Region' 資料表。您可以視需要進行移動或移除。
            this.regionTA_searchPro.Fill(this.product_Search_DataSet.Region);
            // TODO: 這行程式碼會將資料載入 'product_Search_DataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTA_searchPro.Fill(this.product_Search_DataSet.Product);
            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.Transaction' 資料表。您可以視需要進行移動或移除。
            this.transactionTA_searchTrans.Fill(this.trans_Search_DataSet.Transaction);
        }


        //search product
        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.SelectedValue.ToString() == "id")
                    this.productTA_searchPro.FillBy(this.product_Search_DataSet.Product, ((long)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(long)))));
                else if (comboBox6.SelectedValue.ToString() == "title")
                    this.productTA_searchPro.FillBy1(this.product_Search_DataSet.Product, priceToolStripTextBox.Text);
                else if (comboBox6.SelectedValue.ToString() == "paymentID")
                    this.productTA_searchPro.FillBy3(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(int))))));
                else if (comboBox6.SelectedValue.ToString() == "countryID")
                    this.productTA_searchPro.FillBy2(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(int))))));
                else if (comboBox6.SelectedValue.ToString() == "condition")
                    this.productTA_searchPro.FillBy4(this.product_Search_DataSet.Product, int.Parse(priceToolStripTextBox.Text));
                else if (comboBox6.SelectedValue.ToString() == "price")
                {
                    if (radioButton2.Checked)
                        this.productTA_searchPro.FillBy5(this.product_Search_DataSet.Product, double.Parse(priceToolStripTextBox.Text));
                    else if (radioButton3.Checked)
                        this.productTA_searchPro.FillBy6(this.product_Search_DataSet.Product, double.Parse(priceToolStripTextBox.Text));
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //hidden price of search product
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "price")
            {
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                label4.Visible = false;
            }
        }

        //search trans
        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox7.SelectedValue.ToString() == "transID")
                    this.transactionTA_searchTrans.FillBy(this.trans_Search_DataSet.Transaction, int.Parse(findTranTool.Text));
                else if (comboBox7.SelectedValue.ToString() == "sellerID")
                    this.transactionTA_searchTrans.FillBy1(this.trans_Search_DataSet.Transaction, int.Parse(findTranTool.Text));
                else if (comboBox7.SelectedValue.ToString() == "productID")
                    this.transactionTA_searchTrans.FillBy2(this.trans_Search_DataSet.Transaction, int.Parse(findTranTool.Text));
                else if (comboBox7.SelectedValue.ToString() == "statusID")
                    this.transactionTA_searchTrans.FillBy3(this.trans_Search_DataSet.Transaction, int.Parse(findTranTool.Text));
                else if (comboBox7.SelectedValue.ToString() == "buyerID")
                    this.transactionTA_searchTrans.FillBy4(this.trans_Search_DataSet.Transaction, int.Parse(findTranTool.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //add product
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                productTA_editPro.InsertQuery(
                    textBox2.Text,
                    int.Parse(comboBox1.SelectedValue.ToString()),
                    int.Parse(comboBox2.SelectedValue.ToString()),
                    int.Parse(textBox3.Text),
                    double.Parse(textBox4.Text)
                );
                productTA_searchPro.Fill(product_Search_DataSet.Product);
                productTA_editPro.Fill(edit_Product_DataSet.Product);
                productTA_editTran.Fill(editTransDataSet.Product);
                productTA_searchTrans.Fill(trans_Search_DataSet.Product);
                MessageBox.Show("Successful");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //delete product
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                productTA_editPro.DeleteQuery(int.Parse(comboBox3.SelectedValue.ToString()));
                productTA_searchPro.Fill(product_Search_DataSet.Product);
                transactionTA_editPro.Fill(edit_Product_DataSet.Transaction);
                productTA_editPro.Fill(edit_Product_DataSet.Product);
                transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
                MessageBox.Show("Successful");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //update product
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                productTA_editPro.UpdateQuery(
                    textBox2.Text,
                    int.Parse(comboBox3.SelectedValue.ToString())
                );
            }

            if (comboBox1.SelectedValue.ToString() != "")
            {
                productTA_editPro.UpdateQuery1(
                    int.Parse(comboBox1.SelectedValue.ToString()),
                    int.Parse(comboBox3.SelectedValue.ToString())
                );
            }

            if (comboBox2.SelectedValue.ToString() != "")
            {
                productTA_editPro.UpdateQuery2(
                    int.Parse(comboBox2.SelectedValue.ToString()),
                    int.Parse(comboBox3.SelectedValue.ToString())
                );
            }

            if (textBox3.Text != "")
            {
                productTA_editPro.UpdateQuery3(
                    int.Parse(textBox3.Text.ToString()),
                    int.Parse(comboBox3.SelectedValue.ToString())
                );
            }

            if (textBox4.Text != "")
            {
                productTA_editPro.UpdateQuery4(
                    double.Parse(textBox4.Text.ToString()),
                    int.Parse(comboBox3.SelectedValue.ToString())
                );
            }
            productTA_searchPro.Fill(product_Search_DataSet.Product);
            productTA_editPro.Fill(edit_Product_DataSet.Product);
            productTA_editTran.Fill(editTransDataSet.Product);
            productTA_searchTrans.Fill(trans_Search_DataSet.Product);
            MessageBox.Show("Successful");
        }
     
        //Add user 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ismember;
                if (isMB_checkBox.Checked)
                    ismember = 2;
                else
                    ismember = 1;
                    
                usersTA_editUser.InsertQuery(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    emailTextBox.Text,
                    ismember
                );
                usersTA_editUser.Fill(edit_User_DataSet.Users);
                usersTA_editTran.Fill(editTransDataSet.Users);
                usersTA_searchTrans.Fill(trans_Search_DataSet.Users);
                MessageBox.Show("Successful");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //Delete user 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                usersTA_editUser.DeleteQuery(int.Parse(uidComboBox.SelectedValue.ToString()));
                usersTA_editUser.Fill(edit_User_DataSet.Users);
                usersTA_editTran.Fill(editTransDataSet.Users);
                usersTA_searchTrans.Fill(trans_Search_DataSet.Users);
                MessageBox.Show("Successful");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //update user 
        private void button2_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "")
            {
                usersTA_editUser.UpdateQuery(
                    firstNameTextBox.Text,
                    int.Parse(uidComboBox.SelectedValue.ToString())
                );
            }

            if (lastNameTextBox.Text != "")
            {
                usersTA_editUser.UpdateQuery1(
                    lastNameTextBox.Text,
                    int.Parse(uidComboBox.SelectedValue.ToString())
                );
            }

            if (emailTextBox.Text != "")
            {
                usersTA_editUser.UpdateQuery2(
                    emailTextBox.Text,
                    int.Parse(uidComboBox.SelectedValue.ToString())
                );
            }

            if (isMB_checkBox.Checked.ToString() != "")
            {
                int ismember;
                if (isMB_checkBox.Checked)
                    ismember = 2;//Y
                else
                    ismember = 1;//N

                usersTA_editUser.UpdateQuery3(
                    ismember,
                    int.Parse(comboBox3.SelectedValue.ToString())
                );
            }

            usersTA_editUser.Fill(edit_User_DataSet.Users);
            usersTA_editTran.Fill(editTransDataSet.Users);
            usersTA_searchTrans.Fill(trans_Search_DataSet.Users);
            MessageBox.Show("Successful");
        }

        //hidden trans buyerID
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox4.Visible = true;
                label16.Visible = true;
                membershipLabel2.Visible = true;
                label18.Visible = true;
            }
            else if (radioButton4.Checked)
            {
                comboBox4.Visible = false;
                label16.Visible = false;
                membershipLabel2.Visible = false;
                label18.Visible = false;
            }
        }

        //add trans
        private void button4_Click(object sender, EventArgs e)
        {
            int status;
            if (radioButton4.Checked)
                status = 1;//open
            else
                status = 0;//close

            double price;
            if (membershipLabel2.Text == "1")//No
                price = double.Parse(priceLabel1.Text);
            else//Yes
                price = 0.9 * double.Parse(priceLabel1.Text);//10% off

            transactionTA_editTran.InsertQuery(
                int.Parse(comboBox5.Text),
                int.Parse(idComboBox.Text),
                price,
                status
            );

            transactionTA_editTran.Fill(editTransDataSet.Transaction);
            transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
            MessageBox.Show("Successful");
        }

        //update trans
        private void button5_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "")
            {

            }

            transactionTA_editTran.Fill(editTransDataSet.Transaction);
            transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
            MessageBox.Show("Successful");
        }

        //delete trans
        private void button6_Click(object sender, EventArgs e)
        {
            transactionTA_editTran.Fill(editTransDataSet.Transaction);
            transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
            MessageBox.Show("Successful");
        }

    }
}
