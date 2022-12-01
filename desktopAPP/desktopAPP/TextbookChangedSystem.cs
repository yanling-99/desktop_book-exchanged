
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
    public partial class TextbookChangedSystem : Form
    {
        public TextbookChangedSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'order_DataSet.logCo' 資料表。您可以視需要進行移動或移除。
            this.logCoTA_order.Fill(this.order_DataSet.logCo);
            // TODO: 這行程式碼會將資料載入 'order_DataSet.order' 資料表。您可以視需要進行移動或移除。
            this.orderTA_order.Fill(this.order_DataSet.order);
            // TODO: 這行程式碼會將資料載入 'editTransDataSet.Product1' 資料表。您可以視需要進行移動或移除。
            this.productCopyTA_editTran.Fill(this.editTransDataSet.Product1);
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
                if (comboBox6.Text == "id")
                    this.productTA_searchPro.FillBy(this.product_Search_DataSet.Product, ((long)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(long)))));
                else if (comboBox6.Text == "title")
                    this.productTA_searchPro.FillBy1(this.product_Search_DataSet.Product, priceToolStripTextBox.Text);
                else if (comboBox6.Text == "paymentID")
                    this.productTA_searchPro.FillBy3(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(int))))));
                else if (comboBox6.Text == "countryID")
                    this.productTA_searchPro.FillBy2(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(priceToolStripTextBox.Text, typeof(int))))));
                else if (comboBox6.Text == "condition")
                    this.productTA_searchPro.FillBy4(this.product_Search_DataSet.Product, int.Parse(priceToolStripTextBox.Text));
                else if (comboBox6.Text == "price")
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

        // Enable price of search product
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "price")
            {
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                label4.Enabled = true;
            }
            else
            {
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                label4.Enabled = false;
            }
        }

        //search trans
        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox7.Text == "transID")
                    this.transactionTA_searchTrans.FillBy(this.trans_Search_DataSet.Transaction, int.Parse(fINDToolStripTextBox.Text));
                else if (comboBox7.Text == "sellerID")
                    this.transactionTA_searchTrans.FillBy1(this.trans_Search_DataSet.Transaction, int.Parse(fINDToolStripTextBox.Text));
                else if (comboBox7.Text == "productID")
                    this.transactionTA_searchTrans.FillBy2(this.trans_Search_DataSet.Transaction, new System.Nullable<long>(((long)(System.Convert.ChangeType(fINDToolStripTextBox.Text, typeof(long))))));
                else if (comboBox7.Text == "statusID")
                    this.transactionTA_searchTrans.FillBy3(this.trans_Search_DataSet.Transaction, int.Parse(fINDToolStripTextBox.Text));
                else if (comboBox7.Text == "buyerID")
                    this.transactionTA_searchTrans.FillBy4(this.trans_Search_DataSet.Transaction, int.Parse(fINDToolStripTextBox.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
       
        //add product
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="" && checkBox2.Checked && checkBox3.Checked && textBox3.Text!= ""
                && textBox4.Text!= "")
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
                MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed!!\nThe information must be filled in completely!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //delete product
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            productTA_editPro.DeleteQuery(int.Parse(comboBox3.SelectedValue.ToString()));
            productTA_searchPro.Fill(product_Search_DataSet.Product);
            transactionTA_editPro.Fill(edit_Product_DataSet.Transaction);
            productTA_editPro.Fill(edit_Product_DataSet.Product);
            transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
            MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //update product
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if(textBox2.Text != "")
            {
                //title
                productTA_editPro.UpdateQuery(
                    textBox2.Text,
                    int.Parse(comboBox3.Text)
                );
                flag++;
            }

            if (checkBox2.Checked)
            {
                //payment
                productTA_editPro.UpdateQuery1(
                    int.Parse(comboBox1.SelectedValue.ToString()),
                    int.Parse(comboBox3.Text)
                );
                flag++;
            }

            if (checkBox3.Checked)
            {
                //region
                productTA_editPro.UpdateQuery2(
                    int.Parse(comboBox2.Text),
                    int.Parse(comboBox3.Text)
                );
                flag++;
            }

            bool showSucceed = true;
            if(textBox3.Text != "")
            {
                if (int.Parse(textBox3.Text)>=1 && int.Parse(textBox3.Text)<=5)
                {
                    //condiition
                    productTA_editPro.UpdateQuery3(
                        int.Parse(textBox3.Text),
                        int.Parse(comboBox3.Text)
                    );
                    showSucceed = true;
                    flag++;
                }
                else
                {
                    MessageBox.Show("Condition update failed, but other update successful. " +
                        "Because condition value must be 1~5", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    showSucceed = false;
                }
            }
            
            if (textBox4.Text != "")
            {
                //price
                productTA_editPro.UpdateQuery4(
                    double.Parse(textBox4.Text),
                    int.Parse(comboBox3.Text)
                );
                flag++;
            }


            if(showSucceed && flag>0)
            {
                productTA_searchPro.Fill(product_Search_DataSet.Product);
                productTA_editPro.Fill(edit_Product_DataSet.Product);
                productTA_editTran.Fill(editTransDataSet.Product);
                productTA_searchTrans.Fill(trans_Search_DataSet.Product);
                MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nothing to upadated", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Add user 
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!= "" && textBox5.Text!= "" && textBox6.Text!= "")
            {
                int ismember;
                if (isMB_checkBox.Checked)
                    ismember = 2;
                else
                    ismember = 1;
                    
                usersTA_editUser.InsertQuery(
                    textBox1.Text,
                    textBox5.Text,
                    textBox6.Text,
                    ismember
                );
                usersTA_editUser.Fill(edit_User_DataSet.Users);
                usersTA_editTran.Fill(editTransDataSet.Users);
                usersTA_searchTrans.Fill(trans_Search_DataSet.Users);
                MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed!!\nThe information must be filled in completely!"
                    , "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Delete user 
        private void button3_Click(object sender, EventArgs e)
        {
            usersTA_editUser.DeleteQuery(int.Parse(uidComboBox.Text));
            usersTA_editUser.Fill(edit_User_DataSet.Users);
            usersTA_editTran.Fill(editTransDataSet.Users);
            usersTA_searchTrans.Fill(trans_Search_DataSet.Users);
            MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //update user 
        private void button2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (textBox1.Text != "")
            {
                //first name
                usersTA_editUser.UpdateQuery(
                    textBox1.Text,
                    int.Parse(uidComboBox.Text)
                );
                flag++;
            }

            if (textBox5.Text != "")
            {
                //last name
                usersTA_editUser.UpdateQuery1(
                    textBox5.Text,
                    int.Parse(uidComboBox.Text)
                );
                flag++;
            }

            if (textBox6.Text != "")
            {
                //email
                usersTA_editUser.UpdateQuery2(
                    textBox6.Text,
                    int.Parse(uidComboBox.Text)
                );
                flag++;
            }

            if (isMB_checkBox.Checked)
            {
                //member  //Yes
                usersTA_editUser.UpdateQuery3(
                    2,
                    int.Parse(uidComboBox.Text)
                );
                flag++;
            }
            else
            {
                //member  //No
                usersTA_editUser.UpdateQuery3(
                    1,
                    int.Parse(uidComboBox.Text)
                );
                flag++;
            }


            if(flag>0)
            {
                usersTA_editUser.Fill(edit_User_DataSet.Users);
                usersTA_editTran.Fill(editTransDataSet.Users);
                usersTA_searchTrans.Fill(trans_Search_DataSet.Users);
                MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nothing is updated", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //add trans
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked && checkBox5.Checked)
            {
                transactionTA_editTran.InsertQuery(
                    int.Parse(comboBox5.Text),
                    int.Parse(idComboBox.Text),
                    double.Parse(priceLabel2.Text),
                    1
                );

                productCopyTA_editTran.Fill(editTransDataSet.Product1);
                transactionTA_editTran.Fill(editTransDataSet.Transaction);
                transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
                orderTA_order.Fill(order_DataSet.order);


                MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed!!\nThe information must be filled in completely!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //update trans
        private void button5_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if (checkBox5.Checked)
            {
                //sale price
                transactionTA_editTran.UpdateQuery2(
                    double.Parse(priceLabel2.Text),
                    int.Parse(transIDComboBox.Text)
                );
                flag++;
            }

            if (radioButton4.Checked)
            {
                //statusID  //open
                transactionTA_editTran.UpdateQuery3(
                    1,
                    int.Parse(transIDComboBox.Text)
                );

                //如果重新open， buyerID 變成 NULL
                transactionTA_editTran.UpdateQuery5(
                    int.Parse(transIDComboBox.Text)
                );

                //如果沒有buyer，就刪除那筆order
                orderTA_order.DeleteQuery(int.Parse(transIDComboBox.Text));
                orderTA_order.Fill(order_DataSet.order);

                flag++;
            }
            else
            {
                //statusID  //close
                transactionTA_editTran.UpdateQuery3(
                    0,
                    int.Parse(transIDComboBox.Text)
                );

                flag++;
            }

            if (radioButton1.Checked)
            {
                //buyerID
                transactionTA_editTran.UpdateQuery4(
                    int.Parse(comboBox4.Text),
                    int.Parse(transIDComboBox.Text)
                );

                //discount
                if (membershipLabel2.Text == "2")//Yes, sb. ismembership
                {   
                    //show 10% off sale price
                    label23.Text = (0.9 * double.Parse(priceLabel3.Text)).ToString("0.00");
                    
                    MessageBox.Show("member price: " + label23.Text, "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*transactionTA_editTran.UpdateQuery2(
                        0.9 * double.Parse(priceLabel3.Text),
                        int.Parse(transIDComboBox.Text)
                    );*/

                    //如果close，訂單成立->新增order
                    orderTA_order.InsertQuery(
                        int.Parse(transIDComboBox.Text),
                        int.Parse(comboBox5.Text),
                        int.Parse(idComboBox.Text),
                        double.Parse(label23.Text),
                        int.Parse(comboBox4.Text),
                        DateTime.Today.ToString("d")
                     );
                }
                else if(membershipLabel2.Text == "1")
                {
                    //如果close，訂單成立->新增order
                    orderTA_order.InsertQuery(
                        int.Parse(transIDComboBox.Text),
                        int.Parse(comboBox5.Text),
                        int.Parse(idComboBox.Text),
                        double.Parse(priceLabel3.Text),
                        int.Parse(comboBox4.Text),
                        DateTime.Today.ToString("d")
                     );
                }

                orderTA_order.Fill(order_DataSet.order);

                flag++;
            }


            if (flag>0)
            {
                productCopyTA_editTran.Fill(editTransDataSet.Product1);
                transactionTA_editTran.Fill(editTransDataSet.Transaction);
                transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
                orderTA_order.Fill(order_DataSet.order);
                MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nothing is updated", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //delete trans
        private void button6_Click(object sender, EventArgs e)
        {
            transactionTA_editTran.DeleteQuery(int.Parse(transIDComboBox.Text));
            //如果刪除訂單，就刪除那筆order
            orderTA_order.DeleteQuery(int.Parse(transIDComboBox.Text));
            orderTA_order.Fill(order_DataSet.order);

            productCopyTA_editTran.Fill(editTransDataSet.Product1);
            transactionTA_editTran.Fill(editTransDataSet.Transaction);
            transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
            MessageBox.Show("Successful", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //EditPro 控制 region 欄位
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
                comboBox2.Enabled = true;
            else
                comboBox2.Enabled = false;
        }

        //EditPro 控制 payment 欄位
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                comboBox1.Enabled = true;
            else
                comboBox1.Enabled = false;
        }

        //EditTrans 控制 sellerID 欄位
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                comboBox5.Enabled = true;
            else
                comboBox5.Enabled = false;
        }

        //EditTrans 控制 productID 欄位
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                idComboBox.Enabled = true;
            else
                idComboBox.Enabled = false;
        }

        //Product tab control
        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void searchTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }
        private void editTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void orderLogisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        //Enable trans buyerID
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox4.Enabled = true;
                label16.Enabled = true;
                membershipLabel2.Enabled = true;
                label18.Enabled = true;
                label19.Enabled = true;
                priceLabel3.Enabled = true;
                label20.Enabled = true;
                label22.Enabled = true;
                label23.Enabled = true;
            }
            else if (radioButton4.Checked)
            {
                comboBox4.Enabled = false;
                label16.Enabled = false;
                membershipLabel2.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                priceLabel3.Enabled = false;
                label20.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
            }
        }

        //Enable LogID
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked)
                companyComboBox.Enabled = true;
            else
                companyComboBox.Enabled = false;
        }


        //Add LogID
        private void button7_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (checkBox6.Checked)
            {
                //sellerID
                orderTA_order.UpdateQuery(
                    int.Parse(companyComboBox.SelectedValue.ToString()),
                    int.Parse(transIDComboBox1.Text)
                );

                orderTA_order.Fill(order_DataSet.order);
                flag++;
            }
            if (flag > 0)
                MessageBox.Show("Updated Successful","Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nothing to Updated", "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void homeBT_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.home.Show();
        }

    }
}
