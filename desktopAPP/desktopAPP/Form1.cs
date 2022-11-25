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
            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.TransStatus' 資料表。您可以視需要進行移動或移除。
            this.transStatusTableAdapter.Fill(this.trans_Search_DataSet.TransStatus);

            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter.Fill(this.trans_Search_DataSet.Users);
            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter1.Fill(this.trans_Search_DataSet.Product);
            // TODO: 這行程式碼會將資料載入 'product_Search_DataSet.PaymentType' 資料表。您可以視需要進行移動或移除。
            this.paymentTypeTableAdapter.Fill(this.product_Search_DataSet.PaymentType);
            // TODO: 這行程式碼會將資料載入 'product_Search_DataSet.Region' 資料表。您可以視需要進行移動或移除。
            this.regionTableAdapter.Fill(this.product_Search_DataSet.Region);
            // TODO: 這行程式碼會將資料載入 'product_Search_DataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.product_Search_DataSet.Product);
            // TODO: 這行程式碼會將資料載入 'trans_Search_DataSet.Transaction' 資料表。您可以視需要進行移動或移除。
            this.transactionTableAdapter.Fill(this.trans_Search_DataSet.Transaction);
            

        }

       

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.transactionTableAdapter.FillBy(this.trans_Search_DataSet.Transaction, new System.Nullable<int>(((int)(System.Convert.ChangeType(fINDToolStripTextBox.Text, typeof(int))))));
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
                this.productTableAdapter.FillBy(this.product_Search_DataSet.Product, ((long)(System.Convert.ChangeType(bookIDToolStripTextBox.Text, typeof(long)))));
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
                this.productTableAdapter.FillBy1(this.product_Search_DataSet.Product, titleKeywordToolStripTextBox.Text);
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
                this.productTableAdapter.FillBy2(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(regionIDToolStripTextBox.Text, typeof(int))))));
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
                this.productTableAdapter.FillBy3(this.product_Search_DataSet.Product, new System.Nullable<int>(((int)(System.Convert.ChangeType(paymentIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    
    }
}
