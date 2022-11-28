﻿
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

       

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.transactionTA_searchTrans.FillBy(this.trans_Search_DataSet.Transaction, new System.Nullable<int>(((int)(System.Convert.ChangeType(fINDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTA_searchPro.FillBy(this.product_Search_DataSet.Product, ((long)(System.Convert.ChangeType(bookIDToolStripTextBox.Text, typeof(long)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTA_searchPro.FillBy1(this.product_Search_DataSet.Product, titleKeywordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTA_searchPro.FillBy2(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(regionIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTA_searchPro.FillBy3(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(paymentIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
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
                productTA_editPro.Fill(edit_Product_DataSet.Product);
                productTA_searchPro.Fill(product_Search_DataSet.Product);
                MessageBox.Show("Successful");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                productTA_editPro.DeleteQuery(int.Parse(comboBox3.SelectedValue.ToString()));
                transactionTA_editPro.Fill(edit_Product_DataSet.Transaction);
                transactionTA_searchTrans.Fill(trans_Search_DataSet.Transaction);
                productTA_editPro.Fill(edit_Product_DataSet.Product);
                productTA_searchPro.Fill(product_Search_DataSet.Product);
                MessageBox.Show("Successful");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

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

            
            productTA_editPro.Fill(edit_Product_DataSet.Product);
            productTA_searchPro.Fill(product_Search_DataSet.Product);
            MessageBox.Show("Successful");
            

        }
    }
}
